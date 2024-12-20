using WinFormsApp1;

namespace ProjectMeneger
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TopPanel = new Panel();
            TopLabel = new Label();
            TopPanelConteiner = new Panel();
            DefaultCatalogLable = new Label();
            DefaultCatalogTextBox = new TextBox();
            DefaultCatalogTextBoxConteiner = new Panel();
            SaveSettingsButton = new Components.UserButton();
            TopPanel.SuspendLayout();
            TopPanelConteiner.SuspendLayout();
            DefaultCatalogTextBoxConteiner.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(0, 17, 37);
            TopPanel.Controls.Add(TopLabel);
            TopPanel.Dock = DockStyle.Fill;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(512, 63);
            TopPanel.TabIndex = 0;
            // 
            // TopLabel
            // 
            TopLabel.AutoSize = true;
            TopLabel.BackColor = Color.FromArgb(0, 17, 37);
            TopLabel.Font = new Font("Segoe UI", 24F);
            TopLabel.ForeColor = Color.White;
            TopLabel.Location = new Point(0, 9);
            TopLabel.Margin = new Padding(0);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(167, 54);
            TopLabel.TabIndex = 0;
            TopLabel.Text = "Settings";
            // 
            // TopPanelConteiner
            // 
            TopPanelConteiner.BackColor = Color.FromArgb(195, 0, 195);
            TopPanelConteiner.Controls.Add(TopPanel);
            TopPanelConteiner.Dock = DockStyle.Top;
            TopPanelConteiner.Location = new Point(0, 0);
            TopPanelConteiner.Name = "TopPanelConteiner";
            TopPanelConteiner.Padding = new Padding(0, 0, 0, 5);
            TopPanelConteiner.Size = new Size(512, 68);
            TopPanelConteiner.TabIndex = 1;
            // 
            // DefaultCatalogLable
            // 
            DefaultCatalogLable.AutoSize = true;
            DefaultCatalogLable.Font = new Font("Segoe UI", 16F);
            DefaultCatalogLable.ForeColor = Color.White;
            DefaultCatalogLable.Location = new Point(12, 82);
            DefaultCatalogLable.Name = "DefaultCatalogLable";
            DefaultCatalogLable.Size = new Size(198, 37);
            DefaultCatalogLable.TabIndex = 2;
            DefaultCatalogLable.Text = "Default catalog";
            // 
            // DefaultCatalogTextBox
            // 
            DefaultCatalogTextBox.BackColor = Color.FromArgb(0, 12, 26);
            DefaultCatalogTextBox.BorderStyle = BorderStyle.None;
            DefaultCatalogTextBox.Dock = DockStyle.Fill;
            DefaultCatalogTextBox.ForeColor = Color.White;
            DefaultCatalogTextBox.Location = new Point(10, 6);
            DefaultCatalogTextBox.Margin = new Padding(0);
            DefaultCatalogTextBox.Name = "DefaultCatalogTextBox";
            DefaultCatalogTextBox.Size = new Size(230, 20);
            DefaultCatalogTextBox.TabIndex = 3;
            DefaultCatalogTextBox.Text = Properties.Settings.Default.DefaultCatalog;
            DefaultCatalogTextBox.Click += DefaultCatalogTextBox_Click;
            DefaultCatalogTextBox.TextChanged += DefaultCatalogTextBox_TextChanged;
            DefaultCatalogTextBox.Select(int.MaxValue, 0);
            // 
            // DefaultCatalogTextBoxConteiner
            // 
            DefaultCatalogTextBoxConteiner.BackColor = Color.FromArgb(0, 12, 26);
            DefaultCatalogTextBoxConteiner.Controls.Add(DefaultCatalogTextBox);
            DefaultCatalogTextBoxConteiner.Location = new Point(250, 87);
            DefaultCatalogTextBoxConteiner.Name = "DefaultCatalogTextBoxConteiner";
            DefaultCatalogTextBoxConteiner.Padding = new Padding(10, 6, 10, 6);
            DefaultCatalogTextBoxConteiner.Size = new Size(250, 32);
            DefaultCatalogTextBoxConteiner.TabIndex = 4;
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.BackColor = Color.FromArgb(195, 0, 195);
            SaveSettingsButton.ButtonRoundRadius = 50;
            SaveSettingsButton.Font = new Font("Segoe UI", 14F);
            SaveSettingsButton.ForeColor = Color.White;
            SaveSettingsButton.Location = new Point(311, 268);
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.Size = new Size(184, 54);
            SaveSettingsButton.TabIndex = 5;
            SaveSettingsButton.Text = "Save";
            SaveSettingsButton.Click += SaveSettingsButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(0, 17, 37);
            ClientSize = new Size(512, 353);
            Controls.Add(SaveSettingsButton);
            Controls.Add(DefaultCatalogTextBoxConteiner);
            Controls.Add(DefaultCatalogLable);
            Controls.Add(TopPanelConteiner);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "SettingsForm";
            Text = "settingsForm";
            Load += settingsForm_Load;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            TopPanelConteiner.ResumeLayout(false);
            DefaultCatalogTextBoxConteiner.ResumeLayout(false);
            DefaultCatalogTextBoxConteiner.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Panel TopPanelConteiner;
        private Label TopLabel;
        private Label DefaultCatalogLable;
        private TextBox DefaultCatalogTextBox;
        private Panel DefaultCatalogTextBoxConteiner;
        private Components.UserButton SaveSettingsButton;
    }
}