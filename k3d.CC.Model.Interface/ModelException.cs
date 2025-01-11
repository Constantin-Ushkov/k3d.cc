using k3d.Common;

namespace k3d.CC.Model.Interface
{
    public class ModelException : k3dException
    {
        public ModelException(string message) :
            base(message)
        {
        }

        public ModelException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    }
}
