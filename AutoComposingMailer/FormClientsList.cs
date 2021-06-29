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
    public partial class FormClientsList : Form
    {
        public FormClientsList()
        {
            InitializeComponent();
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
