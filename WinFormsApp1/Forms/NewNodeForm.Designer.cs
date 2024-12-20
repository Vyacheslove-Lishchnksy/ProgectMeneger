namespace ProjectMeneger.Forms
{
    partial class NewNodeForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNodeForm));
            TopPanelContainer = new Panel();
            TopPanel = new Panel();
            TopLabel = new Label();
            NameLabel = new Label();
            NameTextBoxConteiner = new Panel();
            NameTextBox = new TextBox();
            TamplateLabel = new Label();
            CreateNewNodeButton = new Components.UserButton();
            CanselNewNodeButton = new Components.UserButton();
            DropListButtonContaineer = new Panel();
            DropListButton = new Button();
            ListBoxPanel = new FlowLayoutPanel();
            DropListTimer = new System.Windows.Forms.Timer(components);
            TopPanelContainer.SuspendLayout();
            TopPanel.SuspendLayout();
            NameTextBoxConteiner.SuspendLayout();
            DropListButtonContaineer.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanelContainer
            // 
            TopPanelContainer.BackColor = Color.FromArgb(195, 0, 195);
            TopPanelContainer.Controls.Add(TopPanel);
            TopPanelContainer.Dock = DockStyle.Top;
            TopPanelContainer.Location = new Point(0, 0);
            TopPanelContainer.Name = "TopPanelContainer";
            TopPanelContainer.Padding = new Padding(0, 0, 0, 5);
            TopPanelContainer.Size = new Size(482, 68);
            TopPanelContainer.TabIndex = 0;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(0, 17, 37);
            TopPanel.Controls.Add(TopLabel);
            TopPanel.Dock = DockStyle.Fill;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(482, 63);
            TopPanel.TabIndex = 0;
            // 
            // TopLabel
            // 
            TopLabel.AutoSize = true;
            TopLabel.Font = new Font("Segoe UI", 24F);
            TopLabel.ForeColor = Color.White;
            TopLabel.Location = new Point(3, 9);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(324, 54);
            TopLabel.TabIndex = 0;
            TopLabel.Text = "Create new node";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 16F);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(12, 84);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(88, 37);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // NameTextBoxConteiner
            // 
            NameTextBoxConteiner.BackColor = Color.FromArgb(0, 12, 26);
            NameTextBoxConteiner.Controls.Add(NameTextBox);
            NameTextBoxConteiner.Location = new Point(220, 89);
            NameTextBoxConteiner.Name = "NameTextBoxConteiner";
            NameTextBoxConteiner.Padding = new Padding(10, 6, 10, 6);
            NameTextBoxConteiner.Size = new Size(250, 32);
            NameTextBoxConteiner.TabIndex = 5;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(0, 12, 26);
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Cursor = Cursors.IBeam;
            NameTextBox.Dock = DockStyle.Fill;
            NameTextBox.ForeColor = Color.White;
            NameTextBox.Location = new Point(10, 6);
            NameTextBox.Margin = new Padding(0);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(230, 20);
            NameTextBox.TabIndex = 3;
            NameTextBox.Text = "NewNode";
            NameTextBox.Select(int.MaxValue, int.MaxValue);
            // 
            // TamplateLabel
            // 
            TamplateLabel.AutoSize = true;
            TamplateLabel.Font = new Font("Segoe UI", 16F);
            TamplateLabel.ForeColor = Color.White;
            TamplateLabel.Location = new Point(12, 135);
            TamplateLabel.Name = "TamplateLabel";
            TamplateLabel.Size = new Size(125, 37);
            TamplateLabel.TabIndex = 6;
            TamplateLabel.Text = "Tamplate";
            // 
            // CreateNewNodeButton
            // 
            CreateNewNodeButton.BackColor = Color.FromArgb(195, 0, 195);
            CreateNewNodeButton.ButtonRoundRadius = 50;
            CreateNewNodeButton.Font = new Font("Segoe UI", 14F);
            CreateNewNodeButton.ForeColor = Color.White;
            CreateNewNodeButton.Location = new Point(286, 268);
            CreateNewNodeButton.Name = "CreateNewNodeButton";
            CreateNewNodeButton.Size = new Size(184, 54);
            CreateNewNodeButton.TabIndex = 7;
            CreateNewNodeButton.Text = "Save";
            // 
            // CanselNewNodeButton
            // 
            CanselNewNodeButton.BackColor = Color.FromArgb(107, 0, 107);
            CanselNewNodeButton.ButtonRoundRadius = 50;
            CanselNewNodeButton.Font = new Font("Segoe UI", 14F);
            CanselNewNodeButton.ForeColor = Color.White;
            CanselNewNodeButton.Location = new Point(12, 268);
            CanselNewNodeButton.Name = "CanselNewNodeButton";
            CanselNewNodeButton.Size = new Size(184, 54);
            CanselNewNodeButton.TabIndex = 8;
            CanselNewNodeButton.Text = "Cansel";
            CanselNewNodeButton.Click += CanselNewNodeButton_Click;
            // 
            // DropListButtonContaineer
            // 
            DropListButtonContaineer.Controls.Add(DropListButton);
            DropListButtonContaineer.Location = new Point(220, 140);
            DropListButtonContaineer.Margin = new Padding(0);
            DropListButtonContaineer.Name = "DropListButtonContaineer";
            DropListButtonContaineer.Size = new Size(250, 29);
            DropListButtonContaineer.TabIndex = 10;
            // 
            // DropListButton
            // 
            DropListButton.BackColor = Color.FromArgb(0, 12, 26);
            DropListButton.Dock = DockStyle.Fill;
            DropListButton.FlatStyle = FlatStyle.Popup;
            DropListButton.ForeColor = Color.White;
            DropListButton.Image = (Image)resources.GetObject("DropListButton.Image");
            DropListButton.ImageAlign = ContentAlignment.MiddleRight;
            DropListButton.ImeMode = ImeMode.NoControl;
            DropListButton.Location = new Point(0, 0);
            DropListButton.Name = "DropListButton";
            DropListButton.Padding = new Padding(3, 0, 3, 0);
            DropListButton.Size = new Size(250, 29);
            DropListButton.TabIndex = 0;
            DropListButton.Text = "button2";
            DropListButton.TextAlign = ContentAlignment.MiddleLeft;
            DropListButton.UseVisualStyleBackColor = false;
            DropListButton.Click += DropListButton_Click;
            // 
            // ListBoxPanel
            // 
            ListBoxPanel.BackColor = Color.FromArgb(0, 12, 26);
            ListBoxPanel.Location = new Point(220, 140);
            ListBoxPanel.Name = "ListBoxPanel";
            ListBoxPanel.Size = new Size(250, 32);
            ListBoxPanel.TabIndex = 9;
            // 
            // DropListTimer
            // 
            DropListTimer.Interval = 1;
            DropListTimer.Tick += DropListTimer_Tick;
            // 
            // NewNodeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 17, 37);
            ClientSize = new Size(482, 353);
            Controls.Add(DropListButtonContaineer);
            Controls.Add(ListBoxPanel);
            Controls.Add(CanselNewNodeButton);
            Controls.Add(CreateNewNodeButton);
            Controls.Add(TamplateLabel);
            Controls.Add(NameTextBoxConteiner);
            Controls.Add(NameLabel);
            Controls.Add(TopPanelContainer);
            Name = "NewNodeForm";
            Text = "Create new node";
            TopPanelContainer.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            NameTextBoxConteiner.ResumeLayout(false);
            NameTextBoxConteiner.PerformLayout();
            DropListButtonContaineer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanelContainer;
        private Panel TopPanel;
        private Label TopLabel;
        private Label NameLabel;
        private Panel NameTextBoxConteiner;
        private TextBox NameTextBox;
        private Label TamplateLabel;
        private Components.UserButton CreateNewNodeButton;
        private Components.UserButton CanselNewNodeButton;
        private Panel DropListButtonContaineer;
        private Button DropListButton;
        private FlowLayoutPanel ListBoxPanel;
        private System.Windows.Forms.Timer DropListTimer;
    }
}