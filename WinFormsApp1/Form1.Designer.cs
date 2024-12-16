namespace WinFormsApp1
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            topPanelContainer = new Panel();
            topPanel = new Panel();
            newProjectButton = new Panel();
            sattingsButton = new Panel();
            button1 = new Button();
            projectPanelContainer = new Panel();
            projectPanel = new Panel();
            panelCurrentFolderContainer = new Panel();
            panelCurrentFolder = new Panel();
            labelCurrentFolder = new Label();
            topPanelContainer.SuspendLayout();
            topPanel.SuspendLayout();
            projectPanelContainer.SuspendLayout();
            projectPanel.SuspendLayout();
            panelCurrentFolderContainer.SuspendLayout();
            panelCurrentFolder.SuspendLayout();
            SuspendLayout();
            // 
            // topPanelContainer
            // 
            topPanelContainer.AutoSize = true;
            topPanelContainer.BackColor = Color.FromArgb(195, 0, 195);
            topPanelContainer.Controls.Add(topPanel);
            topPanelContainer.Dock = DockStyle.Top;
            topPanelContainer.ForeColor = Color.Cyan;
            topPanelContainer.ImeMode = ImeMode.NoControl;
            topPanelContainer.Location = new Point(0, 0);
            topPanelContainer.Margin = new Padding(0);
            topPanelContainer.MinimumSize = new Size(0, 57);
            topPanelContainer.Name = "topPanelContainer";
            topPanelContainer.Size = new Size(1262, 57);
            topPanelContainer.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(0, 17, 37);
            topPanel.Controls.Add(newProjectButton);
            topPanel.Controls.Add(sattingsButton);
            topPanel.Controls.Add(button1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.MaximumSize = new Size(0, 52);
            topPanel.MinimumSize = new Size(0, 52);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1262, 52);
            topPanel.TabIndex = 1;
            // 
            // newProjectButton
            // 
            newProjectButton.BackgroundImage = (Image)resources.GetObject("newProjectButton.BackgroundImage");
            newProjectButton.Cursor = Cursors.Hand;
            newProjectButton.Location = new Point(57, 9);
            newProjectButton.Name = "newProjectButton";
            newProjectButton.Size = new Size(30, 30);
            newProjectButton.TabIndex = 2;
            // 
            // sattingsButton
            // 
            sattingsButton.BackgroundImage = (Image)resources.GetObject("sattingsButton.BackgroundImage");
            sattingsButton.Cursor = Cursors.Hand;
            sattingsButton.ForeColor = SystemColors.ActiveCaptionText;
            sattingsButton.Location = new Point(12, 9);
            sattingsButton.Name = "sattingsButton";
            sattingsButton.Size = new Size(30, 30);
            sattingsButton.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 0, 0);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(9, 9);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 2;
            button1.Text = "sattingsButton";
            button1.UseVisualStyleBackColor = false;
            // 
            // projectPanelContainer
            // 
            projectPanelContainer.BackColor = Color.FromArgb(195, 0, 195);
            projectPanelContainer.Controls.Add(projectPanel);
            projectPanelContainer.Dock = DockStyle.Left;
            projectPanelContainer.Location = new Point(0, 57);
            projectPanelContainer.Name = "projectPanelContainer";
            projectPanelContainer.Padding = new Padding(0, 0, 10, 0);
            projectPanelContainer.Size = new Size(294, 616);
            projectPanelContainer.TabIndex = 1;
            // 
            // projectPanel
            // 
            projectPanel.BackColor = Color.FromArgb(0, 17, 37);
            projectPanel.Controls.Add(panelCurrentFolderContainer);
            projectPanel.Dock = DockStyle.Fill;
            projectPanel.Location = new Point(0, 0);
            projectPanel.Name = "projectPanel";
            projectPanel.Size = new Size(284, 616);
            projectPanel.TabIndex = 2;
            // 
            // panelCurrentFolderContainer
            // 
            panelCurrentFolderContainer.BackColor = Color.FromArgb(195, 0, 195);
            panelCurrentFolderContainer.Controls.Add(panelCurrentFolder);
            panelCurrentFolderContainer.Dock = DockStyle.Top;
            panelCurrentFolderContainer.Location = new Point(0, 0);
            panelCurrentFolderContainer.Name = "panelCurrentFolderContainer";
            panelCurrentFolderContainer.Padding = new Padding(0, 0, 0, 5);
            panelCurrentFolderContainer.Size = new Size(284, 48);
            panelCurrentFolderContainer.TabIndex = 2;
            // 
            // panelCurrentFolder
            // 
            panelCurrentFolder.BackColor = Color.FromArgb(0, 17, 37);
            panelCurrentFolder.Controls.Add(labelCurrentFolder);
            panelCurrentFolder.Dock = DockStyle.Fill;
            panelCurrentFolder.Location = new Point(0, 0);
            panelCurrentFolder.Name = "panelCurrentFolder";
            panelCurrentFolder.Size = new Size(284, 43);
            panelCurrentFolder.TabIndex = 2;
            // 
            // labelCurrentFolder
            // 
            labelCurrentFolder.AutoSize = true;
            labelCurrentFolder.FlatStyle = FlatStyle.System;
            labelCurrentFolder.Font = new Font("Segoe UI", 20F);
            labelCurrentFolder.ForeColor = Color.White;
            labelCurrentFolder.Location = new Point(12, -3);
            labelCurrentFolder.Name = "labelCurrentFolder";
            labelCurrentFolder.Size = new Size(110, 46);
            labelCurrentFolder.TabIndex = 2;
            labelCurrentFolder.Text = "/root/";
            labelCurrentFolder.Click += label1_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 17, 37);
            ClientSize = new Size(1262, 673);
            Controls.Add(projectPanelContainer);
            Controls.Add(topPanelContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "mainForm";
            Text = "mainForm";
            topPanelContainer.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            projectPanelContainer.ResumeLayout(false);
            projectPanel.ResumeLayout(false);
            panelCurrentFolderContainer.ResumeLayout(false);
            panelCurrentFolder.ResumeLayout(false);
            panelCurrentFolder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topPanelContainer;
        private Panel topPanel;
        private Panel projectPanelContainer;
        private Panel projectPanel;
        private Panel panelCurrentFolderContainer;
        private Panel panelCurrentFolder;
        private Label labelCurrentFolder;
        private Button button1;
        private Panel sattingsButton;
        private Panel newProjectButton;
    }
}
