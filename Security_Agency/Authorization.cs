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
    public partial class Authorization : Form
    {
        public static DBWork DBC { private set; get; }      //
        public static string login { private set; get; }    //логин
        public static string password { private set; get; } //пароль

        public Authorization()
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
            InitializeComponent();
        }
        // Авторизоваться по нажатию кнопки
        private void authorizationButton_Click(object sender, EventArgs e)
        {
            login = loginTextBox.Text;
            password = passwordTextBox.Text;

            Hide();
            new MainForm().Show();
        }
        // Перезагрузка окна
        public void Reset()
        {
            Show();
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
