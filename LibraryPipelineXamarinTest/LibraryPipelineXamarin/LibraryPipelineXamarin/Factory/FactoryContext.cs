using System.Collections.Generic;
using LibraryPipelineXamarin.Context;
using LibraryPipelineXamarin.Models;

namespace LibraryPipelineXamarin.Factory
{
    public class FactoryContext
    {
        public ContextPhase Contexto { get; }

        public FactoryContext()
        {
            Contexto = new ContextPhase();
        }

        public FactoryContext SetType(List<WordPrase> tipoString)
        {
            Contexto.Entidad = tipoString;
            return this;
        }

        public ContextPhase GetInstance()
        {
            return Contexto;
        }
    }
}

