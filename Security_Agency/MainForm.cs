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
    public partial class MainForm : Form
    {
        
        public MainForm()
        { 
            InitializeComponent();
        }
        public static DBWork DBC { private set; get; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBC = DBWork.CreateDBWork(
                    "192.168.186.161",
                    "5432",
                    "bd_admin",
                    "Qwerty12345",
                    "testdb"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                Environment.Exit(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DBWork.SelectFam();
        }
    }
}
