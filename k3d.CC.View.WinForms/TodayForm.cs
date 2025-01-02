
namespace k3d.CC.View.WinForms
{
    public partial class TodayForm : Form
    {
        public TodayForm()
        {
            InitializeComponent();

            // todo: setup data\model\model-view here
        }

        private void TodayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
