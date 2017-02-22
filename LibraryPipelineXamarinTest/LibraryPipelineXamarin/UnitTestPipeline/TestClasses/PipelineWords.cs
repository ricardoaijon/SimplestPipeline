using System.Threading.Tasks;
using LibraryPipelineXamarin.Intefaces;

namespace UnitTestPipeline.TestClasses
{
    public abstract class PipelineWords : IPipelineElement
    {
        protected PipelineWords Ocrsuccessor;
        public ContextPhase Contexto;



        public void SetSuccessor(PipelineWords successor)
        {
            Ocrsuccessor = successor;
        }

        public abstract Task<string> GetText();

        public void SetInput(ContextPhase inputContextOcr)
        {
            Contexto = inputContextOcr;
        }

        public void SetInput(IBaseContext<object> inputContextOcr)
        {
            Contexto = (ContextPhase) inputContextOcr;
        }

        public abstract void Connect(IPipelineBase next);


        public abstract void Connect(IPipelineElement next);



        public bool IsComplete { get; set; }
        public abstract Task<string> Process();

    }
}