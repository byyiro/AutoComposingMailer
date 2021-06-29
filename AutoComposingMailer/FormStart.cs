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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }
        private void ButtonConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formSMTP.Show();
        }
        private void ButtonScan_Click(object sender, EventArgs e)
        {
            Program.ScanFiles();
            Program.formAttachmentsList.Show();
        }
        private void ButtonCreateClient_Click(object sender, EventArgs e)
        {
            Program.CreateClientFolder(this.textBoxClientName.Text, this.textBoxClientMail.Text);
        }
        private void ButtonShowClients_Click(object sender, EventArgs e)
        {
            try
            {
                Program.ReadClients();
                Program.formClientsList.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("The repo was unreadable.", "Error");
            }
        }
    }
}
