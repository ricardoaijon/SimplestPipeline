namespace LibraryPipelineXamarin.Intefaces
{
    public interface IBaseContext<T>
    {
        T Entidad { set; get; }
    }
}