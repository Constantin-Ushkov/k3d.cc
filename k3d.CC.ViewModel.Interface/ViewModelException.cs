using k3d.Common;

namespace k3d.CC.ViewModel.Interface
{
    public class ViewModelException : k3dException
    {
        public ViewModelException(string message) :
            base(message)
        {
        }

        public ViewModelException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    }
}
