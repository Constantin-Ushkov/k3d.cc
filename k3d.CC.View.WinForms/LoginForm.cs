using k3d.CC.ViewModel.Interface;

namespace k3d.CC.View.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm(IUserViewModel userVm)
        {
            InitializeComponent();
            _userVm = userVm;

            // todo: general logging (to display in main form)
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
            => _userVm.Login(uiAccountNameComboBox.SelectedText, uiPasswordText.Text);

        private void uiCancelButton_Click(object sender, EventArgs e)
            => Hide();

        private readonly IUserViewModel _userVm;
    }
}
