using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Agency
{
    public partial class AddClient : Form
    {
        private MainForm mainForm;
        public AddClient()
        {
            InitializeComponent();
        }

        public AddClient(MainForm form)
        {
            InitializeComponent();
            ClearForm();
            mainForm = form;
        }

        private void ClearForm()
        {
            textBoxSurnameInput.Text = "";
            nameTextBox.Text = "";
            otchTextBox.Text = "";
            INNMTextBox.Text = "000000000000";
            birthTextBox.Text = "01.01.2000";
            addressTextBox.Text = "";
            IDMTextBox.Text = "000000";
            SMTextBox.Text = "0000";
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCancelAddClient_Click(object sender, EventArgs e)
        {

        }
    }
}
