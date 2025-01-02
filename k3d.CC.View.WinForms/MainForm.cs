using k3d.CC.ViewModel.Interface;

namespace k3d.CC.View.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _loginForm = new LoginForm
            {
                MdiParent = this
            };

            _loginForm.LoggedIn += (sender, args) => OnLogin(args);

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
        {
            OnLogout();
        }

        private void uiLoginMainMenuItem_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
        }

        private void uiTodayMainMenuItem_Click(object sender, EventArgs e)
        {
            _todayForm.Show();
        }

        #endregion // Main Menu Handlers

        private void OnLogin(LoginForm.LoggedInEventArgs args)
        {
            _viewModel = args.ViewModel;

            uiLogOutMenuItem.Enabled = true;
            uiTodayMainMenuItem.Enabled = true;
        }

        private void OnLogout()
        {
            uiLogOutMenuItem.Enabled = false;
            uiTodayMainMenuItem.Enabled = false;

            if (_todayForm.Visible)
            {
                _todayForm.Hide();
            }

            _viewModel = null;
        }

        private IViewModel? _viewModel;
        private readonly LoginForm _loginForm;
        private readonly TodayForm _todayForm;
    }
}
