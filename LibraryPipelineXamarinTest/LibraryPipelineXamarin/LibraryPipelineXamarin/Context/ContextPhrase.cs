using System;
using System.Collections.Generic;
using LibraryPipelineXamarin.Intefaces;
using LibraryPipelineXamarin.Models;

namespace LibraryPipelineXamarin.Context
{
    public class ContextPhrase:IBaseContext<WordPrase>
    {
        public List<WordPrase> WordsList=new List<WordPrase>(); 
        public WordPrase Entidad { get; set; }

        public void Add(WordPrase word)
        {
            WordsList.Add(word);
        }
    }
}