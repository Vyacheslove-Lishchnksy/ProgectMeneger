using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMeneger.Forms
{
    public partial class NewNodeForm : Form
    {

        bool isExpand;

        public NewNodeForm()
        {
            InitializeComponent();
        }

        private void CanselNewNodeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TamplateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DropListButton_Click(object sender, EventArgs e)
        {
            DropListTimer.Start();
        }

        private void DropListTimer_Tick(object sender, EventArgs e)
        {
            if (!isExpand)
            {
                ListBoxPanel.Height += 10;
                if (ListBoxPanel.Height > DropListButton.Size.Height * 3)
                {
                    isExpand = true;
                    DropListTimer.Stop();
                }
            }
            else
            {
                ListBoxPanel.Height -= 10;
                if (ListBoxPanel.Height <= DropListButton.Size.Height)
                {
                    isExpand = false;
                    DropListTimer.Stop();
                }
            }
        }
    }
}
