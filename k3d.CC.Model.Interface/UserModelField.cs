
namespace k3d.CC.Model.Interface
{
    [Flags]
    public enum UserModelField
    {
        None = 0,
        Name = 1,
        Password = 1 << 1
    }
}
