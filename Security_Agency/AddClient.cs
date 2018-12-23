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
            textBoxNameInput.Text = "";
            textBoxMiddleNameInput.Text = "";
            dateTimeInputDateBirth.Text = "01.01.2000";
            textBoxInputAddress.Text = "";
            textBoxInputPassID.Text = "0000000000";
        }



        private void ButtonAddClient_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCancelAddClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
            
        }



        private void TextBoxInputPassID_KeyDown(object sender, KeyEventArgs e)
        {
            int number = e.KeyValue;
            if (e.KeyValue <= 47 || e.KeyValue >= 58)
            {
                e.Handled = true;
            }
        }
    }
}
