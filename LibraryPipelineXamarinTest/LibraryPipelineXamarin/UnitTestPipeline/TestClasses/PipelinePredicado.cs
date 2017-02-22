using System;
using System.Threading.Tasks;
using LibraryPipelineXamarin.Intefaces;

namespace UnitTestPipeline.TestClasses
{
    internal class PipelinePredicado:PipelineWords
    {
        public override Task<string> GetText()
        {
            return null;
        }

        public new void SetInput(ContextPhase inputContextOcr)
        {
            Contexto = inputContextOcr;

        }

        public override void Connect(IPipelineBase next)
        {
            next.SetInput(Contexto);
        }

        public override void Connect(IPipelineElement next)
        {
            next.SetInput(Contexto);
        }
        
        public override Task<string> Process()
        {
            if (Contexto == null) return Task.FromResult(String.Empty);
            if (Contexto.Entidad.Count > 2)
            {
                Contexto.ResultText += Contexto.Entidad[2].Meaning+"!";
                IsComplete = true;
                return Task.FromResult(Contexto.ResultText);
            }
            return Task.FromResult(Contexto.ResultText);
        }
    }
}