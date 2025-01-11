using k3d.CC.ViewModel.Interface;

namespace k3d.CC.View.WinForms
{
    public partial class RegisterDialog : Form
    {
        public string UserName => uiAccountNameTextBox.Text;
        public string Password => uiPasswordTextBox.Text;

        public RegisterDialog(IUserViewModel userVm)
        {
            InitializeComponent();

            _userVm = userVm;
            _userVm.Registered += (sender, args) =>
            {
                DialogResult = DialogResult.OK;
            };
        }

        private void uiShowPasswordButton_MouseDown(object sender, MouseEventArgs e)
        {
            uiPasswordTextBox.PasswordChar = '\0';
            uiPassword2TextBox.PasswordChar = '\0';
        }

        private void uiShowPasswordButton_MouseUp(object sender, MouseEventArgs e)
        {
            uiPasswordTextBox.PasswordChar = '*';
            uiPassword2TextBox.PasswordChar = '*';
        }

        private void uiCreateAccountButton_Click(object sender, EventArgs e)
            => _userVm.Register(
                uiAccountNameTextBox.Text,
                uiPasswordTextBox.Text,
                uiPassword2TextBox.Text);

        private readonly IUserViewModel _userVm;
    }
}
