
namespace k3d.CC.ViewModel.Interface
{
    public class ErrorEventArgs(string message, Exception? exception) : EventArgs
    {
        public string Message { get; } = message;
        public Exception? Exception { get; } = exception;

        public ErrorEventArgs(Exception exception) :
            this(exception.Message, exception)
        {
        }
    }
}
