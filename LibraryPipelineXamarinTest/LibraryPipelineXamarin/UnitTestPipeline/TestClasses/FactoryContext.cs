using System.Collections.Generic;
using LibraryPipelineXamarin.Models;

namespace UnitTestPipeline.TestClasses
{
    public class FactoryContext
    {
        private ContextPhase _contexto;

        public FactoryContext()
        {
            _contexto = new ContextPhase();
        }

        public void SetType(List<WordPrase> palabras)
        {
            _contexto.Entidad = palabras;
        }

        public ContextPhase GetInstance()
        {
            return _contexto;
        }

       
    }
}

