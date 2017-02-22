using System.Collections.Generic;
using LibraryPipelineXamarin.Intefaces;
using LibraryPipelineXamarin.Models;

namespace LibraryPipelineXamarin.Context
{
    public class ContextPhase:IBaseContext<List<WordPrase>>
    {
        public List<WordPrase> Entidad { get; set; }

        public string ResultText { set; get; }
    }
}