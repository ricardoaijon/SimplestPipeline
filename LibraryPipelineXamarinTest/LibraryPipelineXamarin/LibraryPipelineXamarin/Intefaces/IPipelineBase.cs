using System.Threading.Tasks;

namespace LibraryPipelineXamarin.Intefaces
{
    public interface IPipelineBase
    {
        /// <summary>
        /// Set the input for this pipeline element
        /// </summary>
        /// <param name="inputContextOcr"></param>
        void SetInput(IBaseContext<object> inputContextOcr);

        /// <summary>
        /// The output of this element will be connected to the input of the next element.
        /// </summary>
        /// <param name="next">The next element to be connected</param>
        void Connect(IPipelineBase next);

        /// <summary>
        /// Is the processing complete with respect to this particular pipeline element.
        /// </summary>
        bool IsComplete
        {
            get; set;
        }

        Task<string> Process();
    }
}