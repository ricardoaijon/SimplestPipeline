using System.Collections.Generic;
using LibraryPipelineXamarin.Intefaces;
using LibraryPipelineXamarin.Models;

namespace UnitTestPipeline.TestClasses
{
    public class ContextPhase:IBaseContext<List<WordPrase>>, IBaseContext<object>
    {
        public List<WordPrase> Entidad { get; set; }

        public string ResultText { set; get; }
        object IBaseContext<object>.Entidad { set; get; }

    }
}