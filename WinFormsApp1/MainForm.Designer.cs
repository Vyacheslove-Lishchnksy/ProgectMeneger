using ProjectMeneger.Properties;

namespace WinFormsApp1
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TopPanelContainer = new Panel();
            TopPanel = new Panel();
            NewNodeButton = new Panel();
            SettingsButton = new Panel();
            ProjectPanelContainer = new Panel();
            ProjectPanel = new Panel();
            PanelCurrentFolderContainer = new Panel();
            PanelCurrentFolder = new Panel();
            CurrentFolderLable = new Label();
            DropListTimer = new System.Windows.Forms.Timer(components);
            TopPanelContainer.SuspendLayout();
            TopPanel.SuspendLayout();
            ProjectPanelContainer.SuspendLayout();
            ProjectPanel.SuspendLayout();
            PanelCurrentFolderContainer.SuspendLayout();
            PanelCurrentFolder.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanelContainer
            // 
            resources.ApplyResources(TopPanelContainer, "TopPanelContainer");
            TopPanelContainer.BackColor = Color.FromArgb(195, 0, 195);
            TopPanelContainer.Controls.Add(TopPanel);
            TopPanelContainer.ForeColor = Color.Cyan;
            TopPanelContainer.Name = "TopPanelContainer";
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(0, 17, 37);
            TopPanel.Controls.Add(NewNodeButton);
            TopPanel.Controls.Add(SettingsButton);
            resources.ApplyResources(TopPanel, "TopPanel");
            TopPanel.Name = "TopPanel";
            // 
            // NewNodeButton
            // 
            resources.ApplyResources(NewNodeButton, "NewNodeButton");
            NewNodeButton.Cursor = Cursors.Hand;
            NewNodeButton.Name = "NewNodeButton";
            NewNodeButton.Click += NewProjectButton_Click;
            // 
            // SettingsButton
            // 
            resources.ApplyResources(SettingsButton, "SettingsButton");
            SettingsButton.Cursor = Cursors.Hand;
            SettingsButton.ForeColor = SystemColors.ActiveCaptionText;
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Click += SettingsButton_Click;
            // 
            // ProjectPanelContainer
            // 
            ProjectPanelContainer.BackColor = Color.FromArgb(195, 0, 195);
            ProjectPanelContainer.Controls.Add(ProjectPanel);
            resources.ApplyResources(ProjectPanelContainer, "ProjectPanelContainer");
            ProjectPanelContainer.Name = "ProjectPanelContainer";
            // 
            // ProjectPanel
            // 
            ProjectPanel.BackColor = Color.FromArgb(0, 17, 37);
            ProjectPanel.Controls.Add(PanelCurrentFolderContainer);
            resources.ApplyResources(ProjectPanel, "ProjectPanel");
            ProjectPanel.Name = "ProjectPanel";
            // 
            // PanelCurrentFolderContainer
            // 
            PanelCurrentFolderContainer.BackColor = Color.FromArgb(195, 0, 195);
            PanelCurrentFolderContainer.Controls.Add(PanelCurrentFolder);
            resources.ApplyResources(PanelCurrentFolderContainer, "PanelCurrentFolderContainer");
            PanelCurrentFolderContainer.Name = "PanelCurrentFolderContainer";
            // 
            // PanelCurrentFolder
            // 
            PanelCurrentFolder.BackColor = Color.FromArgb(0, 17, 37);
            PanelCurrentFolder.Controls.Add(CurrentFolderLable);
            resources.ApplyResources(PanelCurrentFolder, "PanelCurrentFolder");
            PanelCurrentFolder.Name = "PanelCurrentFolder";
            // 
            // CurrentFolderLable
            // 
            resources.ApplyResources(CurrentFolderLable, "CurrentFolderLable");
            CurrentFolderLable.FlatStyle = FlatStyle.System;
            CurrentFolderLable.ForeColor = Color.White;
            CurrentFolderLable.Name = "CurrentFolderLable";
            // 
            // DropListTimer
            // 
            DropListTimer.Interval = 1;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 17, 37);
            Controls.Add(ProjectPanelContainer);
            Controls.Add(TopPanelContainer);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            TopPanelContainer.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            ProjectPanelContainer.ResumeLayout(false);
            ProjectPanel.ResumeLayout(false);
            PanelCurrentFolderContainer.ResumeLayout(false);
            PanelCurrentFolder.ResumeLayout(false);
            PanelCurrentFolder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanelContainer;
        private Panel TopPanel;
        private Panel ProjectPanelContainer;
        private Panel ProjectPanel;
        private Panel PanelCurrentFolderContainer;
        private Panel PanelCurrentFolder;
        private Label CurrentFolderLable;
        private Panel SettingsButton;
        private Panel NewNodeButton;
        private System.Windows.Forms.Timer DropListTimer;
    }
}
