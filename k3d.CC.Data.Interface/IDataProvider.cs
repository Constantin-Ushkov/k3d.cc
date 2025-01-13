namespace k3d.CC.Data.Interface
{
    public interface IDataProvider: IDisposable
    {
        IUserDataProvider Users { get; }
    }
}
