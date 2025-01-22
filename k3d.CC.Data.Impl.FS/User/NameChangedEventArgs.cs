
namespace k3d.CC.Data.Impl.FS.User
{
    internal class NameChangedEventArgs: EventArgs
    {
        public string OldName { get; }
        public IUserStorage User { get; }

        public NameChangedEventArgs(IUserStorage user, string oldName)
        {
            User = user;
            OldName = oldName;
        }
    }
}
