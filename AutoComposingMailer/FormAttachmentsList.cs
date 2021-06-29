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
    public partial class FormAttachmentsList : Form
    {
        public FormAttachmentsList()
        {
            InitializeComponent();
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            this.buttonSend.Enabled = false;
            Program.SendFiles();
            Program.formStart.progressBarScan.Value = 100;
            MessageBox.Show("Finished.", "Scanning done");
            Program.formStart.progressBarScan.Value = 0;
            this.buttonSend.Enabled = true;
            this.Hide();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
