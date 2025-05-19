namespace FormView_Desktop.Forms
{
    partial class Settings
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
            tableLayoutPanel_mainLayout = new TableLayoutPanel();
            textBox_fileServer = new TextBox();
            label_fileServer = new Label();
            textBox_password = new TextBox();
            label_password = new Label();
            textBox_username = new TextBox();
            label_username = new Label();
            label_useCredentials = new Label();
            textBox_database = new TextBox();
            label_database = new Label();
            label_server = new Label();
            textBox_server = new TextBox();
            checkBox_defaultCredentials = new CheckBox();
            panel_formControls = new Panel();
            button_cancel = new Button();
            button_save = new Button();
            panel_mainContent = new Panel();
            tableLayoutPanel_mainLayout.SuspendLayout();
            panel_formControls.SuspendLayout();
            panel_mainContent.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel_mainLayout
            // 
            tableLayoutPanel_mainLayout.AutoSize = true;
            tableLayoutPanel_mainLayout.ColumnCount = 2;
            tableLayoutPanel_mainLayout.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel_mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_mainLayout.Controls.Add(textBox_fileServer, 1, 5);
            tableLayoutPanel_mainLayout.Controls.Add(label_fileServer, 0, 5);
            tableLayoutPanel_mainLayout.Controls.Add(textBox_password, 1, 4);
            tableLayoutPanel_mainLayout.Controls.Add(label_password, 0, 4);
            tableLayoutPanel_mainLayout.Controls.Add(textBox_username, 1, 3);
            tableLayoutPanel_mainLayout.Controls.Add(label_username, 0, 3);
            tableLayoutPanel_mainLayout.Controls.Add(label_useCredentials, 0, 2);
            tableLayoutPanel_mainLayout.Controls.Add(textBox_database, 1, 1);
            tableLayoutPanel_mainLayout.Controls.Add(label_database, 0, 1);
            tableLayoutPanel_mainLayout.Controls.Add(label_server, 0, 0);
            tableLayoutPanel_mainLayout.Controls.Add(textBox_server, 1, 0);
            tableLayoutPanel_mainLayout.Controls.Add(checkBox_defaultCredentials, 1, 2);
            tableLayoutPanel_mainLayout.Dock = DockStyle.Top;
            tableLayoutPanel_mainLayout.Location = new Point(0, 0);
            tableLayoutPanel_mainLayout.Name = "tableLayoutPanel_mainLayout";
            tableLayoutPanel_mainLayout.RowCount = 6;
            tableLayoutPanel_mainLayout.RowStyles.Add(new RowStyle());
            tableLayoutPanel_mainLayout.RowStyles.Add(new RowStyle());
            tableLayoutPanel_mainLayout.RowStyles.Add(new RowStyle());
            tableLayoutPanel_mainLayout.RowStyles.Add(new RowStyle());
            tableLayoutPanel_mainLayout.RowStyles.Add(new RowStyle());
            tableLayoutPanel_mainLayout.RowStyles.Add(new RowStyle());
            tableLayoutPanel_mainLayout.Size = new Size(405, 165);
            tableLayoutPanel_mainLayout.TabIndex = 0;
            // 
            // textBox_fileServer
            // 
            textBox_fileServer.Location = new Point(141, 139);
            textBox_fileServer.Name = "textBox_fileServer";
            textBox_fileServer.Size = new Size(261, 23);
            textBox_fileServer.TabIndex = 10;
            // 
            // label_fileServer
            // 
            label_fileServer.Anchor = AnchorStyles.Left;
            label_fileServer.AutoSize = true;
            label_fileServer.Location = new Point(3, 143);
            label_fileServer.Name = "label_fileServer";
            label_fileServer.Size = new Size(63, 15);
            label_fileServer.TabIndex = 9;
            label_fileServer.Text = "File Server:";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(141, 110);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(261, 23);
            textBox_password.TabIndex = 8;
            // 
            // label_password
            // 
            label_password.Anchor = AnchorStyles.Left;
            label_password.AutoSize = true;
            label_password.Location = new Point(3, 114);
            label_password.Name = "label_password";
            label_password.Size = new Size(60, 15);
            label_password.TabIndex = 7;
            label_password.Text = "Password:";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(141, 81);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(261, 23);
            textBox_username.TabIndex = 6;
            // 
            // label_username
            // 
            label_username.Anchor = AnchorStyles.Left;
            label_username.AutoSize = true;
            label_username.Location = new Point(3, 85);
            label_username.Name = "label_username";
            label_username.Size = new Size(63, 15);
            label_username.TabIndex = 5;
            label_username.Text = "Username:";
            // 
            // label_useCredentials
            // 
            label_useCredentials.Anchor = AnchorStyles.Left;
            label_useCredentials.AutoSize = true;
            label_useCredentials.Location = new Point(3, 60);
            label_useCredentials.Name = "label_useCredentials";
            label_useCredentials.Size = new Size(132, 15);
            label_useCredentials.TabIndex = 3;
            label_useCredentials.Text = "Use Default Credentials:";
            // 
            // textBox_database
            // 
            textBox_database.Location = new Point(141, 32);
            textBox_database.Name = "textBox_database";
            textBox_database.Size = new Size(261, 23);
            textBox_database.TabIndex = 2;
            // 
            // label_database
            // 
            label_database.Anchor = AnchorStyles.Left;
            label_database.AutoSize = true;
            label_database.Location = new Point(3, 36);
            label_database.Name = "label_database";
            label_database.Size = new Size(58, 15);
            label_database.TabIndex = 1;
            label_database.Text = "Database:";
            // 
            // label_server
            // 
            label_server.Anchor = AnchorStyles.Left;
            label_server.AutoSize = true;
            label_server.Location = new Point(3, 7);
            label_server.Name = "label_server";
            label_server.Size = new Size(42, 15);
            label_server.TabIndex = 0;
            label_server.Text = "Server:";
            // 
            // textBox_server
            // 
            textBox_server.Location = new Point(141, 3);
            textBox_server.Name = "textBox_server";
            textBox_server.Size = new Size(261, 23);
            textBox_server.TabIndex = 1;
            // 
            // checkBox_defaultCredentials
            // 
            checkBox_defaultCredentials.AutoSize = true;
            checkBox_defaultCredentials.Location = new Point(141, 61);
            checkBox_defaultCredentials.Name = "checkBox_defaultCredentials";
            checkBox_defaultCredentials.Size = new Size(15, 14);
            checkBox_defaultCredentials.TabIndex = 4;
            checkBox_defaultCredentials.UseVisualStyleBackColor = true;
            checkBox_defaultCredentials.CheckedChanged += checkBox_defaultCredentials_CheckedChanged;
            // 
            // panel_formControls
            // 
            panel_formControls.AutoSize = true;
            panel_formControls.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_formControls.Controls.Add(button_cancel);
            panel_formControls.Controls.Add(button_save);
            panel_formControls.Dock = DockStyle.Bottom;
            panel_formControls.Location = new Point(0, 166);
            panel_formControls.Name = "panel_formControls";
            panel_formControls.Size = new Size(405, 29);
            panel_formControls.TabIndex = 1;
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_cancel.Location = new Point(327, 3);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(75, 23);
            button_cancel.TabIndex = 1;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Location = new Point(3, 3);
            button_save.Name = "button_save";
            button_save.Size = new Size(75, 23);
            button_save.TabIndex = 0;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // panel_mainContent
            // 
            panel_mainContent.AutoScroll = true;
            panel_mainContent.Controls.Add(tableLayoutPanel_mainLayout);
            panel_mainContent.Dock = DockStyle.Fill;
            panel_mainContent.Location = new Point(0, 0);
            panel_mainContent.Name = "panel_mainContent";
            panel_mainContent.Size = new Size(405, 166);
            panel_mainContent.TabIndex = 2;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_cancel;
            ClientSize = new Size(405, 195);
            Controls.Add(panel_mainContent);
            Controls.Add(panel_formControls);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            tableLayoutPanel_mainLayout.ResumeLayout(false);
            tableLayoutPanel_mainLayout.PerformLayout();
            panel_formControls.ResumeLayout(false);
            panel_mainContent.ResumeLayout(false);
            panel_mainContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_mainLayout;
        private Label label_server;
        private TextBox textBox_server;
        private Panel panel_formControls;
        private Button button_cancel;
        private Button button_save;
        private Panel panel_mainContent;
        private TextBox textBox_password;
        private Label label_password;
        private TextBox textBox_username;
        private Label label_username;
        private Label label_useCredentials;
        private TextBox textBox_database;
        private Label label_database;
        private CheckBox checkBox_defaultCredentials;
        private TextBox textBox_fileServer;
        private Label label_fileServer;
    }
}