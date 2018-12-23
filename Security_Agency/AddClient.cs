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
        public AddClient()
        {
            InitializeComponent();
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCancelAddClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Отмена добавления", "Вы уверены, что хотите отменить добавление?",
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
