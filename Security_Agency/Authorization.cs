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
                    host: Config.host,
                    port: Config.port,
                    username: Config.username,
                    password: Config.password,
                    database: Config.database
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
            AccessRoles role;

            // начальник отдела вневедомственной охраны
            if (login == "director" && password == "12345")
            {
                role = AccessRoles.Director;
            }
            // сотрудник отдела по работе с клиентами
            else if (login == "manager" && password == "12345")
            {
                role = AccessRoles.Manager;
            }
            // бухгалтер
            else if (login == "accountant" && password == "12345")
            {
                role = AccessRoles.Accountant;
            }
            // руководитель выездной бригады
            else if (login == "inspector" && password == "12345")
            {
                role = AccessRoles.Inspector;
            }
            // сотрудник отдела кадров
            else if (login == "hrmanager" && password == "12345")
            {
                role = AccessRoles.HRManager;
            }
            // специалист по монтажу оборудования
            else if (login == "adjuster" && password == "12345")
            {
                role = AccessRoles.Adjuster;
            }
            // дежурный
            else if (login == "dispatcher" && password == "12345")
            {
                role = AccessRoles.Dispatcher;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            // вывести на экран форму и передать ей роль управления
            // в соответствии с введенным логином и паролем
            Hide();
            new MainForm(role, this).Show();
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
