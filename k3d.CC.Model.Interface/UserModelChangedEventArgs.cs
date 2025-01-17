
namespace k3d.CC.Model.Interface
{
    public class UserModelChangedEventArgs: EventArgs
    {
        public UserModelField ChangedFields { get; }

        public UserModelChangedEventArgs(UserModelField changedFields)
        {
            ChangedFields = changedFields;
        }
    }
}
