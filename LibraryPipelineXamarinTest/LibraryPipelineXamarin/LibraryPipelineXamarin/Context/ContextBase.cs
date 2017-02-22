using System;
using LibraryPipelineXamarin.Intefaces;

namespace LibraryPipelineXamarin.Context
{
    public class ContextBase <T>: IBaseContext<T> where T:class
    {
        public T Entidad { set; get; }
      
    }
}