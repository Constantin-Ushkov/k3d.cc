using k3d.CC.Model.Interface;
using k3d.CC.ViewModel.Interface;

namespace k3d.CC.View.WinForms
{
    public partial class RenameUserDialog : Form
    {
        public RenameUserDialog(IUserViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;

            viewModel.Changed += (sender, args) =>
            {
                if ((args.ChangedFields & UserModelField.Name) == UserModelField.Name)
                {
                    DialogResult = DialogResult.OK;
                }
            };
        }

        private void uiOkButton_Click(object sender, EventArgs e)
            => _viewModel.Rename(uiNameTextBox.Text, uiPasswordTextBox.Text);

        private void uiCancelButton_Click(object sender, EventArgs e)
            => DialogResult = DialogResult.Cancel;

        private void uiShowPasswordButton_MouseDown(object sender, MouseEventArgs e)
            => uiPasswordTextBox.PasswordChar = '\0';

        private void uiShowPasswordButton_MouseUp(object sender, MouseEventArgs e)
            => uiPasswordTextBox.PasswordChar = '*';

        private readonly IUserViewModel _viewModel;
    }
}
