using System;
using System.Collections;
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
    public partial class FormLog : Form
    {
        public FormLog()
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
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Program.ReadConfig();
        }
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Program.LOG_DIR + "\\log.txt")){
                ArrayList logs = ArrayList.Adapter(System.IO.File.ReadAllLines(Program.LOG_DIR + "\\log.txt").ToList());
                listViewLog.Items.Clear();
                logs.Reverse();
                foreach(string log in logs)
                {
                    if (log.Contains("correctly"))
                    {
                        ListViewItem item = new ListViewItem(log);
                        item.BackColor = Color.Green;
                        item.ForeColor = Color.White;
                        listViewLog.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(log);
                        item.BackColor = Color.Red;
                        item.ForeColor = Color.White;
                        listViewLog.Items.Add(item);
                    }
                }
            }
        }
        private void ButtonSmtpForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formSMTP.Location = this.Location;
            Program.formSMTP.Show();
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

        private void listViewLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
