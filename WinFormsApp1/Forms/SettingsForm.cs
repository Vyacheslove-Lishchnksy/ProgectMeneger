using WinFormsApp1;

namespace ProjectMeneger
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }


        private void settingsForm_Load(object sender, EventArgs e)
        {

        }

        private void DefaultCatalogTextBox_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Виберіть папку";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    DefaultCatalogTextBox.Text = folderBrowserDialog.SelectedPath;
                    Properties.Settings.Default.DefaultCatalog = DefaultCatalogTextBox.Text;
                }
            }

        }

        private void DefaultCatalogTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Console.WriteLine(Properties.Settings.Default.DefaultCatalog);
            
            Close();
        }
    }
}
