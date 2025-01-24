using k3d.CC.ViewModel.Interface;
using k3d.Common.Diagnostics;

namespace k3d.CC.View.WinForms
{
    public partial class ChangePasswordDialog : Form
    {
        public ChangePasswordDialog(IUserViewModel userVm)
        {
            Assert.Argument.IsNotNull(userVm, nameof(userVm));

            _userVm = userVm;

            InitializeComponent();

            _userVm.Changed += (sender, args) =>
            {
                if ((args.ChangedFields & Model.Interface.UserModelField.Password) == Model.Interface.UserModelField.Password)
                {
                    DialogResult = DialogResult.OK;
                }
            };
        }

        private void uiCancelButton_Click(object sender, EventArgs e)
            => DialogResult = DialogResult.Cancel;

        private void uiChangePasswordButton_Click(object sender, EventArgs e)
            => _userVm.ChangePassword(uiCurrentPasswordText.Text, uiNewPasswordText.Text, uiNewPasswordRepeatText.Text);

        private void uiShowPasswordButton_MouseDown(object sender, MouseEventArgs e)
        {
            uiCurrentPasswordText.PasswordChar = '\0';
            uiNewPasswordText.PasswordChar = '\0';
            uiNewPasswordRepeatText.PasswordChar = (char)0;
        }

        private void uiShowPasswordButton_MouseUp(object sender, MouseEventArgs e)
        {
            uiCurrentPasswordText.PasswordChar = '*';
            uiNewPasswordText.PasswordChar = '*';
            uiNewPasswordRepeatText.PasswordChar = '*';
        }

        private readonly IUserViewModel _userVm;
    }
}
