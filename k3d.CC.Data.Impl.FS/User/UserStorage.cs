
namespace k3d.CC.Data.Impl.FS.User
{
    internal class UserStorage
    {
        public static IUserStorage Create(string baseFolder, string userName, byte[] passwordHash)
        {

        }

        public static IUserStorage Open(string baseFolder, string userName)
        {
            // create folder name from user name
            // root data folder
            // check root + \ + users + \ + user_folder
            // if exists - create userStorage instance pointing to this folder and return it
        }
    }
}
