using k3d.CC.ViewModel.Impl;
using k3d.CC.ViewModel.Interface;
using k3d.CC.Model.Impl;
using k3d.CC.Data.Impl.FS;

namespace k3d.CC.View.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _vmFactory = new ViewModelFactory(new ModelFactory(new DataProvider()));
            _userVm = _vmFactory.CreateUserViewModel();

            _userVm.LoggedIn += OnLogin;
            _userVm.LoggedOut += OnLogout;

            _loginForm = new LoginForm(_userVm)
            {
                MdiParent = this
            };

            _todayForm = new TodayForm
            {
                MdiParent = this
            };
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            _loginForm.Show();
        }

        #region Main Menu Handlers

        private void uiLogOutMenuItem_Click(object sender, EventArgs e)
            => _userVm.Logout();

        private void uiLoginMainMenuItem_Click(object sender, EventArgs e)
            => _loginForm.Show();

        private void uiTodayMainMenuItem_Click(object sender, EventArgs e)
            => _todayForm.Show();

        #endregion // Main Menu Handlers

        private void OnLogin(object? sender, EventArgs args)
        {
            _loginForm.Hide();
            _vm = _vmFactory.CreateViewModel(_userVm);

            uiLogOutMenuItem.Enabled = true;
            uiTodayMainMenuItem.Enabled = true;
        }

        private void OnLogout(object? sender, EventArgs args)
        {
            uiLogOutMenuItem.Enabled = false;
            uiTodayMainMenuItem.Enabled = false;

            if (_todayForm.Visible)
            {
                _todayForm.Hide();
            }

            _vm = null;
        }

        private readonly IViewModelFactory _vmFactory;
        private readonly IUserViewModel _userVm;
        private IViewModel? _vm;
        private readonly LoginForm _loginForm;
        private readonly TodayForm _todayForm;
    }
}
