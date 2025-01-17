using k3d.CC.Model.Interface;
using k3d.CC.ViewModel.Interface;
using k3d.Common.Diagnostics;
using k3d.Logging.Interface;

// todo: logging!

namespace k3d.CC.ViewModel.Impl
{
    internal class UserViewModel : IUserViewModel
    {
        public event EventHandler? LoggedIn;
        public event EventHandler? LoggedOut;
        public event EventHandler? Registered;
        public event EventHandler<UserModelChangedEventArgs>? Changed;
        public event EventHandler<Interface.ErrorEventArgs>? Error;

        public UserViewModel(ILogger log, IModelFactory modelFactory)
        {
            Assert.Argument.IsNotNull(log, nameof(log));
            Assert.Argument.IsNotNull(modelFactory, nameof(modelFactory));

            _modelFactory = modelFactory;
            _log = log;
        }

        public void Register(string name, string password1, string password2)
        {
            try
            {
                _user = _modelFactory.Register(name, password1, password2);
                _user.Changed += (sender, args) => Changed?.Invoke(this, args);

                Registered?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Error?.Invoke(this, new Interface.ErrorEventArgs(ex));
            }
        }

        public void Delete()
            => throw new NotImplementedException();

        public IUserModel GetUser()
            => _user ?? throw new ViewModelException("Not logged in.");

        public void Login(string name, string password)
        {
            try
            {
                _user = _modelFactory.Login(name, password);
                _user.Changed += (sender, args) => Changed?.Invoke(this, args);

                LoggedIn?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Error?.Invoke(this, new Interface.ErrorEventArgs(ex));
            }
        }

        public void Logout()
        {
            // assert user != null

            _user!.Logout();
            _user = null;

            LoggedOut?.Invoke(this, EventArgs.Empty);
        }

        public void Rename(string newName, string password)
            => _user?.Rename(newName, password);

        public void ChangePassword(string currentPassword, string newPassword, string newPasswordRepeat)
            => _user?.ChangePassword(newPassword, newPasswordRepeat, currentPassword);

        public void Dispose()
        {
        }

        private readonly ILogger _log;
        private readonly IModelFactory _modelFactory;
        private IUserModel? _user;
    }
}
