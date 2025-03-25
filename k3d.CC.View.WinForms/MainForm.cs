using k3d.CC.ViewModel.Interface;
using k3d.Common.Diagnostics;
using k3d.Logging.Interface;
using k3d.CC.Data.Interface;
using k3d.CC.View.WinForms.Configuration;
using k3d.CC.ViewModel.Interface.MainView;

namespace k3d.CC.View.WinForms
{
    public partial class MainForm : Form
    {
        private static class Constants
        {
            public const string Title = "Control Center";
        }

        public MainForm(IViewModelController vmController, IMainView viewModel)
        {
            /* debug
            var tempConfig = AppConfig.CreateDefault();
            tempConfig.SaveToFile(System.Environment.ProcessPath + ".cfg");
            */

            _vmController = vmController;
            _viewModel = viewModel;

            _vmController.ShowView += OnShowView;
            _vmController.ShowModalView += OnShowViewModal;

            InitializeComponent();

            _vmController.LoggedIn += OnLogin;
            _vmController.LoggedOut += OnLogout;
            _vmController.Error += OnError;

            _viewModel.QuitAction.IsEnabled.Changed += OnQuitActionEnabledChanged;
            _viewModel.LogOutAction.IsEnabled.Changed += OnLogoutActionEnabledChanged;

            /*
            _config = AppConfig.FromExeConfigFile();
            _logging = Logging.Impl.Factory.CreateLoggingService();

            var dataFactory = new DataFactory(_config.DataConfiguration, _logging.Loggers.GetLogger("data", ""));
            _storage = dataFactory.CreateDataProvider();

            var hasher = new SHA256Hasher();
            var modelFactory = new ModelFactory(_logging.Loggers.GetLogger("model", ""), _storage, hasher);

            _vmFactory = new ViewModelFactory(_logging.Loggers.GetLogger("view-model", ""), modelFactory);
            _userVm = _vmFactory.CreateUserViewModel();

            _userVm.Error += (sender, args) =>
            {
#if DEBUG
                MessageBox.Show(args.Exception.ToDetailedString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(args.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            };

            _userVm.LoggedIn += OnLogin;
            _userVm.LoggedOut += OnLogout;

            _loginForm = new LoginDialog(_config, _userVm);
            _todayForm = new TodayForm
            {
                MdiParent = this
            };
            */
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            _viewModel.OnShown();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            _vm?.Dispose();
            _userVm?.Dispose();
            _storage?.Dispose();
            */
            _viewModel.OnClosing();
        }

        private void OnLogoutActionEnabledChanged(object? sender, ActivePropertyChangedEventArgs<bool> e)
            => uiUserLogoutMenuItem.Enabled = e.Property.Value;

        private void OnQuitActionEnabledChanged(object? sender, ActivePropertyChangedEventArgs<bool> e)
            => uiQuitMenuItem.Enabled = e.Property.Value;

        private void OnError(object? sender, ViewModel.Interface.ErrorEventArgs args)
        {
#if DEBUG
            MessageBox.Show(args.Exception!.ToDetailedString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
            MessageBox.Show(args.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
        }

        private void OnShowView(object? sender, ShowViewEventArgs e)
        {
            if (_showViewActions.TryGetValue(e.ViewModel.ViewType, out var presenter))
            {
                presenter?.Invoke(e.ViewModel);
            }
            else
            {
                _vmController.ReportError(
                    $"No view is registered to show for {e.ViewModel.ViewType} view-model type.");
            }
        }

        private void OnShowViewModal(object? sender, ShowViewEventArgs e)
        {
            if (_showModalViewActions.TryGetValue(e.ViewModel.ViewType, out var presenter))
            {
                presenter?.Invoke(e.ViewModel);
            }
            else
            {
                _vmController.ReportError(
                    $"No view is registered to show modal for {e.ViewModel.ViewType} view-model type.");
            }
        }

        #region Main Menu Handlers

        private void uiQuitMenuItem_Click(object sender, EventArgs e)
            => Close();

        private void uiLogOutMenuItem_Click(object sender, EventArgs e)
            => _userVm.Logout();

        private void uiLoginMainMenuItem_Click(object sender, EventArgs e)
            => _loginForm.ShowDialog();

        private void uiTodayMainMenuItem_Click(object sender, EventArgs e)
            => _todayForm.Show();

        private void uiUserLoginMenuItem_Click(object sender, EventArgs e)
            => _loginForm.ShowDialog();

        private void uiUserLogoutMenuItem_Click(object sender, EventArgs e)
            => _userVm.Logout();

        private void uiUserRenameMenuItem_Click(object sender, EventArgs e)
            => new RenameUserDialog(_userVm).ShowDialog();

        private void uiUserChangePasswordMenuItem_Click(object sender, EventArgs e)
            => new ChangePasswordDialog(_userVm).ShowDialog();

        #endregion // Main Menu Handlers

        private void OnLogin(object? sender, EventArgs args)
        {
            Text = $"{Constants.Title} - {_userVm.GetUser().Name}";

            _vm = _vmFactory.CreateViewModel(_userVm);

            uiUserLoginMenuItem.Enabled = false;
            uiUserLogoutMenuItem.Enabled = true;
            uiUserRenameMenuItem.Enabled = true;
            uiUserChangePasswordMenuItem.Enabled = true;

            uiTodayMainMenuItem.Enabled = true;
        }

        private void OnLogout(object? sender, EventArgs args)
        {
            Text = Constants.Title;

            uiUserLoginMenuItem.Enabled = true;
            uiUserLogoutMenuItem.Enabled = false;
            uiUserRenameMenuItem.Enabled = false;
            uiUserChangePasswordMenuItem.Enabled = false;

            uiTodayMainMenuItem.Enabled = false;

            if (_todayForm.Visible)
            {
                _todayForm.Hide();
            }

            _vm = null;
        }

        private readonly IViewModelController _vmController;
        private readonly IMainView _viewModel;
        private readonly Dictionary<ViewType, Action<IViewModel2?>> _showViewActions = [];
        private readonly Dictionary<ViewType, Action<IViewModel2?>> _showModalViewActions = new() {
            {ViewType.Login, viewModel => { new LoginDialog(viewModel as ILoginView).ShowDialog(); }}
        };

        private readonly IApplicationConfiguration _config;
        private readonly ILoggingService _logging;
        private readonly IDataProvider _storage;
        private readonly IUserViewModel _userVm;
        private IViewModel? _vm;
        private readonly LoginDialog _loginForm;
        private readonly TodayForm _todayForm;
    }
}
