using k3d.CC.View.WinForms.Configuration;
using k3d.CC.ViewModel.Interface;
using k3d.Common.Diagnostics;

namespace k3d.CC.View.WinForms
{
    public partial class LoginDialog : Form
    {
        public LoginDialog(ILoginView? viewModel)
        {
            InitializeComponent();
        }

        public LoginDialog(IApplicationConfiguration config, IUserViewModel userVm)
        {
            Assert.Argument.IsNotNull(config, nameof(config));
            Assert.Argument.IsNotNull(userVm, nameof(userVm));

            InitializeComponent();

            _config = config;
            _userVm = userVm;

            // todo: general logging (to display in main form)

            _userVm.LoggedIn += (sender, args) =>
            {
                DialogResult = DialogResult.OK;
            };
        }

        private void LoginDialog_Shown(object sender, EventArgs e)
            => uiDataLocationText.Text = _config.DataConfiguration.BaseFolder;

        private void uiBrowseDataLocationButton_Click(object sender, EventArgs e)
        {
            if (uiDataLocationFolderDialog.ShowDialog() == DialogResult.OK)
            {
                uiDataLocationText.Text = uiDataLocationFolderDialog.SelectedPath;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void uiLoginButton_Click(object sender, EventArgs e)
            => _userVm.Login(uiAccountNameComboBox.Text, uiPasswordText.Text);

        private void uiCancelButton_Click(object sender, EventArgs e)
            => Hide();

        private void uiNewAccountButton_Click(object sender, EventArgs e)
        {
            var registerDlg = new RegisterDialog(_userVm);

            if (registerDlg.ShowDialog() == DialogResult.OK)
            {
                uiAccountNameComboBox.Text = registerDlg.UserName;
                uiPasswordText.Text = registerDlg.Password;
            }
        }

        private void uiShowPasswordButton_MouseDown(object sender, MouseEventArgs e)
            => uiPasswordText.PasswordChar = '\0';

        private void uiShowPasswordButton_MouseUp(object sender, MouseEventArgs e)
            => uiPasswordText.PasswordChar = '*';

        private readonly IApplicationConfiguration _config;
        private readonly IUserViewModel _userVm;
    }
}
