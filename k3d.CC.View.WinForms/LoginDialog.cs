using k3d.CC.ViewModel.Interface;

namespace k3d.CC.View.WinForms
{
    public partial class LoginDialog : Form
    {
        public LoginDialog(IUserViewModel userVm)
        {
            InitializeComponent();
            _userVm = userVm;

            // todo: general logging (to display in main form)

            _userVm.LoggedIn += (sender, args) =>
            {
                DialogResult = DialogResult.OK;
            };
        }

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

        private readonly IUserViewModel _userVm;
    }
}
