using System.Threading.Tasks;

namespace LibraryPipelineXamarin.Intefaces
{
    /// <summary>
    /// Interface for a pipeline element. 
    /// </summary>
    public interface IPipelineElement : IPipelineBase
    {

        /// <summary>
        /// The pipeline elements processing function. Implement your processing here.
        /// </summary>
        Task<string> GetText();


    }
}