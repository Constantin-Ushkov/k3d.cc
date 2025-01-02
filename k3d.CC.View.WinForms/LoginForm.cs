using k3d.CC.ViewModel.Interface;

namespace k3d.CC.View.WinForms
{
    public partial class LoginForm : Form
    {
        public class LoggedInEventArgs : EventArgs
        {
            public IViewModel ViewModel { get; }

            public LoggedInEventArgs(IViewModel viewModel)
            {
                ViewModel = viewModel;
            }
        }

        public event EventHandler<LoggedInEventArgs> LoggedIn;

        public LoginForm()
        {
            InitializeComponent();

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
        {
            Hide();
            LoggedIn?.Invoke(this, new LoggedInEventArgs(null));
        }

        private void uiCancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
