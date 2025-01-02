namespace k3d.CC.View.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _todayForm = new TodayForm
            {
                MdiParent = this
            };
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            var loginForm = new LoginForm
            {
                MdiParent = this
            };

            loginForm.Show();

            // _modelView = loginForm.Login(this);
            // _modelView.Goals.Added += () => {};
            // _modelView.Goals.Removed += () => {};
        }

        private void uiLogOutMenuItem_Click(object sender, EventArgs e)
        {
            LogIn(false);
        }

        private void uiTodayMainMenuItem_Click(object sender, EventArgs e)
        {
            _todayForm.Show();
        }

        private void LogIn(bool logIn) // IModelView 
        {
            uiLogOutMenuItem.Enabled = logIn;
        }

        private readonly TodayForm _todayForm;
    }
}
