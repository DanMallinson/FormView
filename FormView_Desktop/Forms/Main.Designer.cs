namespace FormView_Desktop.Forms
{
    partial class Main
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
            menuStrip_mainMenu = new MenuStrip();
            toolStripMenuItem_settings = new ToolStripMenuItem();
            label_formNumber = new Label();
            textBox_formNumber = new TextBox();
            panel_sideBar = new Panel();
            panel_results = new Panel();
            panel_search = new Panel();
            button_search = new Button();
            panel_view = new Panel();
            panel_currentForm = new Panel();
            panel_pages = new Panel();
            panel_viewSpecific = new Panel();
            label_viewTotal = new Label();
            label_of = new Label();
            numericUpDown_currentPage = new NumericUpDown();
            button_viewNext = new Button();
            button_viewLast = new Button();
            button_viewPrevious = new Button();
            button_viewFirst = new Button();
            button_viewAll = new Button();
            panel_spacer = new Panel();
            menuStrip_mainMenu.SuspendLayout();
            panel_sideBar.SuspendLayout();
            panel_search.SuspendLayout();
            panel_view.SuspendLayout();
            panel_pages.SuspendLayout();
            panel_viewSpecific.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_currentPage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip_mainMenu
            // 
            menuStrip_mainMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_settings });
            menuStrip_mainMenu.Location = new Point(0, 0);
            menuStrip_mainMenu.Name = "menuStrip_mainMenu";
            menuStrip_mainMenu.Size = new Size(800, 24);
            menuStrip_mainMenu.TabIndex = 0;
            menuStrip_mainMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem_settings
            // 
            toolStripMenuItem_settings.Name = "toolStripMenuItem_settings";
            toolStripMenuItem_settings.Size = new Size(61, 20);
            toolStripMenuItem_settings.Text = "Settings";
            toolStripMenuItem_settings.Click += toolStripMenuItem_settings_Click;
            // 
            // label_formNumber
            // 
            label_formNumber.AutoSize = true;
            label_formNumber.Location = new Point(12, 3);
            label_formNumber.Name = "label_formNumber";
            label_formNumber.Size = new Size(85, 15);
            label_formNumber.TabIndex = 2;
            label_formNumber.Text = "Form Number:";
            // 
            // textBox_formNumber
            // 
            textBox_formNumber.Location = new Point(3, 21);
            textBox_formNumber.Name = "textBox_formNumber";
            textBox_formNumber.Size = new Size(194, 23);
            textBox_formNumber.TabIndex = 2;
            textBox_formNumber.KeyUp += textBox_formNumber_KeyUp;
            // 
            // panel_sideBar
            // 
            panel_sideBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_sideBar.BorderStyle = BorderStyle.FixedSingle;
            panel_sideBar.Controls.Add(panel_results);
            panel_sideBar.Controls.Add(panel_search);
            panel_sideBar.Dock = DockStyle.Left;
            panel_sideBar.Location = new Point(0, 24);
            panel_sideBar.Name = "panel_sideBar";
            panel_sideBar.Size = new Size(202, 426);
            panel_sideBar.TabIndex = 1;
            // 
            // panel_results
            // 
            panel_results.Dock = DockStyle.Fill;
            panel_results.Location = new Point(0, 75);
            panel_results.Name = "panel_results";
            panel_results.Size = new Size(200, 349);
            panel_results.TabIndex = 3;
            // 
            // panel_search
            // 
            panel_search.AutoSize = true;
            panel_search.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_search.Controls.Add(button_search);
            panel_search.Controls.Add(textBox_formNumber);
            panel_search.Controls.Add(label_formNumber);
            panel_search.Dock = DockStyle.Top;
            panel_search.Location = new Point(0, 0);
            panel_search.Name = "panel_search";
            panel_search.Size = new Size(200, 75);
            panel_search.TabIndex = 2;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_search.Location = new Point(4, 46);
            button_search.Name = "button_search";
            button_search.Size = new Size(192, 23);
            button_search.TabIndex = 0;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // panel_view
            // 
            panel_view.Controls.Add(panel_currentForm);
            panel_view.Controls.Add(panel_pages);
            panel_view.Dock = DockStyle.Fill;
            panel_view.Location = new Point(202, 24);
            panel_view.Name = "panel_view";
            panel_view.Size = new Size(598, 426);
            panel_view.TabIndex = 2;
            // 
            // panel_currentForm
            // 
            panel_currentForm.Dock = DockStyle.Fill;
            panel_currentForm.Location = new Point(0, 0);
            panel_currentForm.Name = "panel_currentForm";
            panel_currentForm.Size = new Size(598, 391);
            panel_currentForm.TabIndex = 1;
            // 
            // panel_pages
            // 
            panel_pages.BorderStyle = BorderStyle.FixedSingle;
            panel_pages.Controls.Add(panel_viewSpecific);
            panel_pages.Controls.Add(button_viewNext);
            panel_pages.Controls.Add(button_viewLast);
            panel_pages.Controls.Add(button_viewPrevious);
            panel_pages.Controls.Add(button_viewFirst);
            panel_pages.Controls.Add(button_viewAll);
            panel_pages.Controls.Add(panel_spacer);
            panel_pages.Dock = DockStyle.Bottom;
            panel_pages.Location = new Point(0, 391);
            panel_pages.Name = "panel_pages";
            panel_pages.Size = new Size(598, 35);
            panel_pages.TabIndex = 0;
            panel_pages.Visible = false;
            // 
            // panel_viewSpecific
            // 
            panel_viewSpecific.AutoSize = true;
            panel_viewSpecific.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_viewSpecific.Controls.Add(label_viewTotal);
            panel_viewSpecific.Controls.Add(label_of);
            panel_viewSpecific.Controls.Add(numericUpDown_currentPage);
            panel_viewSpecific.Location = new Point(250, 2);
            panel_viewSpecific.Name = "panel_viewSpecific";
            panel_viewSpecific.Size = new Size(115, 31);
            panel_viewSpecific.TabIndex = 5;
            panel_viewSpecific.SizeChanged += panel_viewSpecific_SizeChanged;
            // 
            // label_viewTotal
            // 
            label_viewTotal.AutoSize = true;
            label_viewTotal.Location = new Point(87, 9);
            label_viewTotal.Name = "label_viewTotal";
            label_viewTotal.Size = new Size(25, 15);
            label_viewTotal.TabIndex = 2;
            label_viewTotal.Text = "100";
            // 
            // label_of
            // 
            label_of.AutoSize = true;
            label_of.Location = new Point(59, 10);
            label_of.Name = "label_of";
            label_of.Size = new Size(22, 15);
            label_of.TabIndex = 1;
            label_of.Text = "OF";
            // 
            // numericUpDown_currentPage
            // 
            numericUpDown_currentPage.AutoSize = true;
            numericUpDown_currentPage.Location = new Point(12, 5);
            numericUpDown_currentPage.Name = "numericUpDown_currentPage";
            numericUpDown_currentPage.Size = new Size(41, 23);
            numericUpDown_currentPage.TabIndex = 0;
            numericUpDown_currentPage.TextAlign = HorizontalAlignment.Center;
            numericUpDown_currentPage.ValueChanged += numericUpDown_currentPage_ValueChanged;
            // 
            // button_viewNext
            // 
            button_viewNext.Dock = DockStyle.Right;
            button_viewNext.Location = new Point(371, 0);
            button_viewNext.Name = "button_viewNext";
            button_viewNext.Size = new Size(75, 33);
            button_viewNext.TabIndex = 4;
            button_viewNext.Text = ">";
            button_viewNext.UseVisualStyleBackColor = true;
            button_viewNext.Click += button_viewNext_Click;
            // 
            // button_viewLast
            // 
            button_viewLast.Dock = DockStyle.Right;
            button_viewLast.Location = new Point(446, 0);
            button_viewLast.Name = "button_viewLast";
            button_viewLast.Size = new Size(75, 33);
            button_viewLast.TabIndex = 3;
            button_viewLast.Text = ">>|";
            button_viewLast.UseVisualStyleBackColor = true;
            button_viewLast.Click += button_viewLast_Click;
            // 
            // button_viewPrevious
            // 
            button_viewPrevious.Dock = DockStyle.Left;
            button_viewPrevious.Location = new Point(150, 0);
            button_viewPrevious.Name = "button_viewPrevious";
            button_viewPrevious.Size = new Size(75, 33);
            button_viewPrevious.TabIndex = 2;
            button_viewPrevious.Text = "<";
            button_viewPrevious.UseVisualStyleBackColor = true;
            button_viewPrevious.Click += button_viewPrevious_Click;
            // 
            // button_viewFirst
            // 
            button_viewFirst.Dock = DockStyle.Left;
            button_viewFirst.Location = new Point(75, 0);
            button_viewFirst.Name = "button_viewFirst";
            button_viewFirst.Size = new Size(75, 33);
            button_viewFirst.TabIndex = 1;
            button_viewFirst.Text = "|<<";
            button_viewFirst.UseVisualStyleBackColor = true;
            button_viewFirst.Click += button_viewFirst_Click;
            // 
            // button_viewAll
            // 
            button_viewAll.Dock = DockStyle.Left;
            button_viewAll.Location = new Point(0, 0);
            button_viewAll.Name = "button_viewAll";
            button_viewAll.Size = new Size(75, 33);
            button_viewAll.TabIndex = 0;
            button_viewAll.Text = "All";
            button_viewAll.UseVisualStyleBackColor = true;
            button_viewAll.Click += button_viewAll_Click;
            // 
            // panel_spacer
            // 
            panel_spacer.Dock = DockStyle.Right;
            panel_spacer.Location = new Point(521, 0);
            panel_spacer.Name = "panel_spacer";
            panel_spacer.Size = new Size(75, 33);
            panel_spacer.TabIndex = 6;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_view);
            Controls.Add(panel_sideBar);
            Controls.Add(menuStrip_mainMenu);
            MainMenuStrip = menuStrip_mainMenu;
            Name = "Main";
            Text = "FormView";
            menuStrip_mainMenu.ResumeLayout(false);
            menuStrip_mainMenu.PerformLayout();
            panel_sideBar.ResumeLayout(false);
            panel_sideBar.PerformLayout();
            panel_search.ResumeLayout(false);
            panel_search.PerformLayout();
            panel_view.ResumeLayout(false);
            panel_pages.ResumeLayout(false);
            panel_pages.PerformLayout();
            panel_viewSpecific.ResumeLayout(false);
            panel_viewSpecific.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_currentPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_mainMenu;
        private Label label_formNumber;
        private TextBox textBox_formNumber;
        private Panel panel_sideBar;
        private Panel panel_results;
        private Panel panel_search;
        private Panel panel_view;
        private Button button_search;
        private Panel panel_currentForm;
        private Panel panel_pages;
        private Button button_viewAll;
        private Panel panel_viewSpecific;
        private Button button_viewNext;
        private Button button_viewLast;
        private Button button_viewPrevious;
        private Button button_viewFirst;
        private Label label_viewTotal;
        private Label label_of;
        private NumericUpDown numericUpDown_currentPage;
        private Panel panel_spacer;
        private ToolStripMenuItem toolStripMenuItem_settings;
    }
}