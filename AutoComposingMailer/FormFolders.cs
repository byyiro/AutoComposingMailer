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
    public partial class FormFolders : Form
    {
        public FormFolders()
        {   
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFolders_OnFormClosed);
        }
        private void ButtonExamineDir_Click(object sender, EventArgs e)
        {
            folderBrowserRepo.ShowDialog();
            textBoxRepo.Text = folderBrowserRepo.SelectedPath;
        }
        private void ButtonSmtpForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formSMTP.Location = this.Location;
            Program.formSMTP.Show();
        }
        private void FormFolders_OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Program.REPO_DIR = textBoxRepo.Text;
            Program.SENT_DIR = textBoxSent.Text;
            Program.LOG_DIR = textBoxLog.Text;
            Program.UpdateConfig();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Program.ReadConfig();
        }
        private void ButtonExamineEnviados_Click(object sender, EventArgs e)
        {
            folderBrowserSent.ShowDialog();
            textBoxSent.Text = folderBrowserSent.SelectedPath;
        }
        private void ButtonExamineLog_Click(object sender, EventArgs e)
        {
            folderBrowserLog.ShowDialog();
            textBoxLog.Text = folderBrowserLog.SelectedPath;
        }
        private void ButtonLogsForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formLog.Location = this.Location;
            Program.formLog.Show();
        }
        private void ButtonFormImagenes_Click(object sender, EventArgs e)
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

        private void ButtonExamineMassiveClients_Click(object sender, EventArgs e)
        {
            openFileDialogMassiveClients.ShowDialog();
            textBoxMassiveClients.Text = openFileDialogMassiveClients.FileName;
        }

        private void ButtonImportMassiveClients_Click(object sender, EventArgs e)
        {
            Program.CreateMassiveClients(textBoxMassiveClients.Text);
        }
    }
}
