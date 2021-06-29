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
    public partial class FormImages : Form
    {
        public FormImages()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFirmas_OnFormClosed);
        }
        private void FormImages_Load(object sender, EventArgs e)
        {
            labelCompany0.Text = Enum.GetName(typeof(Company), 0);
            labelCompany1.Text = Enum.GetName(typeof(Company), 1);
        }
        private void FormFirmas_OnFormClosed(object sender, EventArgs e)
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
            Program.COMPANY0_LOGO = textBoxImgCompany0.Text;
            Program.COMPANY1_LOGO = textBoxImgCompany1.Text;
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
        private void ButtonSmtpForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formSMTP.Location = this.Location;
            Program.formSMTP.Show();
        }
        private void ButtonSearchImgCompany0_Click(object sender, EventArgs e)
        {
            openFileDialogImgCompany0.ShowDialog();
            textBoxImgCompany0.Text = openFileDialogImgCompany0.FileName;
        }
        private void ButtonSearchImgCompany1_Click(object sender, EventArgs e)
        {
            openFileDialogImgCompany1.ShowDialog();
            textBoxImgCompany1.Text = openFileDialogImgCompany1.FileName;
        }
        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formStart.Show();
        }
    }
}
