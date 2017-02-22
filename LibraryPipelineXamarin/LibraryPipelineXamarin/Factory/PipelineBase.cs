using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryPipelineXamarin.Intefaces;

namespace LibraryPipelineXamarin.Factory
{
    public class PipelineBase
    {
        public readonly List<IPipelineBase> PipelineList = new List<IPipelineBase>();

        private object Result { set; get; }
        /// <summary>
        /// This is the main processing method. It runs the pipeline until all the 
        /// elements declare completion.
        /// </summary>
        public async Task ExecutePipeline()
        {
            try
            {
                await Task.Factory.StartNew(() =>
                {
                    foreach (var t in PipelineList)
                    {
                        Result = t.Process().Result;
                        if (!t.IsComplete) break;

                    }


                });
            }
            catch (AggregateException)
            {
                
            }
           


        }

        public object GetResult()
        {
            return Result;
        }
    }
}