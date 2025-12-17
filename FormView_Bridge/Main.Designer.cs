namespace FormView_Bridge
{
    partial class Main
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
            label_port = new Label();
            numericUpDown_port = new NumericUpDown();
            textBox_accessionNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_port).BeginInit();
            SuspendLayout();
            // 
            // label_port
            // 
            label_port.AutoSize = true;
            label_port.Location = new Point(12, 17);
            label_port.Name = "label_port";
            label_port.Size = new Size(32, 15);
            label_port.TabIndex = 2;
            label_port.Text = "Port:";
            // 
            // numericUpDown_port
            // 
            numericUpDown_port.Location = new Point(50, 12);
            numericUpDown_port.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown_port.Name = "numericUpDown_port";
            numericUpDown_port.Size = new Size(78, 23);
            numericUpDown_port.TabIndex = 3;
            numericUpDown_port.TextAlign = HorizontalAlignment.Right;
            numericUpDown_port.Value = new decimal(new int[] { 8080, 0, 0, 0 });
            numericUpDown_port.ValueChanged += numericUpDown_port_ValueChanged;
            // 
            // textBox_accessionNumber
            // 
            textBox_accessionNumber.Dock = DockStyle.Bottom;
            textBox_accessionNumber.Location = new Point(0, 37);
            textBox_accessionNumber.Name = "textBox_accessionNumber";
            textBox_accessionNumber.Size = new Size(282, 23);
            textBox_accessionNumber.TabIndex = 4;
            textBox_accessionNumber.TextAlign = HorizontalAlignment.Center;
            textBox_accessionNumber.TextChanged += textBox_accessionNumber_TextChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 60);
            Controls.Add(textBox_accessionNumber);
            Controls.Add(numericUpDown_port);
            Controls.Add(label_port);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Main";
            Text = "Form View Bridge";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_port).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_port;
        private NumericUpDown numericUpDown_port;
        private TextBox textBox_accessionNumber;
    }
}
