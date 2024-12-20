using ProjectMeneger;
using ProjectMeneger.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {

        bool isExpand = false;

        List<string> list = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            NewNodeForm newProjectForm = new NewNodeForm();
            newProjectForm.ShowDialog();
        }


        
    }
}
