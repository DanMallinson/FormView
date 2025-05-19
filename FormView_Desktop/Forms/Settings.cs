using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormView_Desktop.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void checkBox_defaultCredentials_CheckedChanged(object sender, EventArgs e)
        {
            label_password.Enabled = !checkBox_defaultCredentials.Checked;
            textBox_password.Enabled = !checkBox_defaultCredentials.Checked;
            label_username.Enabled = !checkBox_defaultCredentials.Checked;
            textBox_username.Enabled = !checkBox_defaultCredentials.Checked;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            FormView_Desktop.Settings.Default.Server = textBox_server.Text;
            FormView_Desktop.Settings.Default.Database = textBox_database.Text;
            FormView_Desktop.Settings.Default.FileServer = textBox_fileServer.Text;
            FormView_Desktop.Settings.Default.Password = textBox_password.Text;
            FormView_Desktop.Settings.Default.UseDefaultCredentials = checkBox_defaultCredentials.Checked;
            FormView_Desktop.Settings.Default.Username = textBox_username.Text;

            FormView_Desktop.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox_server.Text = FormView_Desktop.Settings.Default.Server;
            textBox_database.Text = FormView_Desktop.Settings.Default.Database;
            textBox_fileServer.Text = FormView_Desktop.Settings.Default.FileServer;
            textBox_password.Text = FormView_Desktop.Settings.Default.Password;
            checkBox_defaultCredentials.Checked = FormView_Desktop.Settings.Default.UseDefaultCredentials;
            textBox_username.Text = FormView_Desktop.Settings.Default.Username;
        }
    }
}
