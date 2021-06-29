using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoComposingMailer
{
    public partial class FormSMTP : Form
    {
        public FormSMTP()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSMTP_OnFormClosed);
        }
        private void FormSMTP_OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ButtonFoldersForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formFolders.Location = this.Location;
            Program.formFolders.Show();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Program.MAIL_SERVER = textBoxMailServer.Text;
            Program.SERVER_PORT = textBoxPort.Text;
            Program.SSL = checkBoxSSL.Checked;
            Program.USER = textBoxUser.Text;
            Program.PASSWORD = textBoxPassword.Text;
            Program.NAME = textBoxNameSign.Text;
            Program.DEPARTMENT = textBoxDepartment.Text;
            Program.UpdateConfig();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Program.ReadConfig();
        }
        private void ButtonLogsForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formLog.Location = this.Location;
            Program.formLog.Show();
        }
        private void ButtonFormImages_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formImages.Location = this.Location;
            Program.formImages.Show();
        }
        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formStart.Show();
        }
    }
}
