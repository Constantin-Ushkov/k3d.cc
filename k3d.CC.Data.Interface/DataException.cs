using k3d.Common;

namespace k3d.CC.Data.Interface
{
    public class DataException : k3dException
    {
        public DataException(string message) :
            base(message)
        {
        }

        public DataException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    }
}
