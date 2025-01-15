using k3d.Common;

namespace k3d.CC.View.WinForms
{
    internal class ControlCenterException : k3dException
    {
        public ControlCenterException(string message)
            : base(message)
        {
        }

        public ControlCenterException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
