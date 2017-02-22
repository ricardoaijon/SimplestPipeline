using System;
using LibraryPipelineXamarin.Intefaces;

namespace LibraryPipelineXamarin.Factory
{
    public class FactoryPipeline<T>
    {
        private T Contexto { set; get; }

        
        private PipelineBase Pipeline { set; get; }

        public FactoryPipeline()
        {
            Pipeline=new PipelineBase();
        }
        public FactoryPipeline<T> SetContext(T contexto)
        {
            Contexto = contexto;
            return this;
        } 

      
        public void Add(IPipelineBase anElement)
        {
            Pipeline.PipelineList.Add(anElement);
            if (Pipeline.PipelineList.Count > 1)
                Pipeline.PipelineList[Pipeline.PipelineList.Count - 2].Connect(Pipeline.PipelineList[Pipeline.PipelineList.Count - 1]);
        }

        public PipelineBase GetPipeline()
        {
            return Pipeline;
        }

        public FactoryPipeline<T> AddPipeline<TElement>()
        {
            var activator =(IPipelineBase) Activator.CreateInstance(typeof (TElement));
            Pipeline.PipelineList.Add(activator);
            if (Pipeline.PipelineList.Count > 1)
                Pipeline.PipelineList[Pipeline.PipelineList.Count - 2].Connect(Pipeline.PipelineList[Pipeline.PipelineList.Count - 1]);
            return this;
        }
    }
}