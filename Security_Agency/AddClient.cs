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
        //
        public AddClient(MainForm form)
        {
            InitializeComponent();
            ClearForm();
            mainForm = form;
        }
        //
        private void ClearForm()
        {
            textBoxSurnameInput.Text = "";
            textBoxNameInput.Text = "";
            textBoxMiddleNameInput.Text = "";
            dateTimeInputDateBirth.Text = "01.01.2000";
            textBoxInputAddress.Text = "";
            maskedtextBoxInputPassID.Text = "";
        }
        // преобразование к строке
        private string ConvertToStringDB(string text)
        {
            return "'" + text + "'";
        }
        // преобразование к дате
        private string ConvertToDateDB(string text)
        {
            return String.Format("TO_DATE('{0}','DD.MM.YYYY')", text);
        }
        // убирает все пустые значения, выполняет преобразования к строке или к дате
        private Dictionary<string, string> PrepareData(Dictionary<string, string> vals)
        {
            IList<string> keysToRemove = new List<string>();
            foreach (var pair in vals)
            {
                if (vals[pair.Key] == "")
                    keysToRemove.Add(pair.Key);
            }
            foreach (var key in keysToRemove)
            {
                vals.Remove(key);
            }
            if (vals["\"Date_Birth\""] == "  .  .")
            {
                vals.Remove("\"Date_Birth\"");
            }
            var newDict = new Dictionary<string, string>();
            foreach (var key in vals.Keys)
            {
                if (!key.ToLower().Contains("date"))
                {
                    newDict.Add(key, ConvertToStringDB(vals[key]));
                }
                else
                {
                    newDict.Add(key, ConvertToDateDB(vals[key]));
                }
            }
            return newDict;
        }
        //
        private void AddClient_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                this.buttonAddClient.Text = "Сохранить";
                textBoxSurnameInput.Text = Config.valueFromTableForEdit["Фамилия"];
                textBoxNameInput.Text = Config.valueFromTableForEdit["Имя"];
                textBoxMiddleNameInput.Text = Config.valueFromTableForEdit["Отчество"];
                dateTimeInputDateBirth.Text = Config.valueFromTableForEdit["Дата рождения"];
                textBoxInputAddress.Text = Config.valueFromTableForEdit["Адрес проживания"];
                maskedtextBoxInputPassID.Text = Config.valueFromTableForEdit["Номер паспорта"];
            }
            else
                ClearForm();
        }
        // 
        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            if (textBoxSurnameInput.Text == "" || textBoxNameInput.Text == ""
                || maskedtextBoxInputPassID.Text == "" || textBoxInputAddress.Text == "")
            {
                MessageBox.Show("Не заполнено одно из обязательных полей");
            }
            else
            {
                Dictionary<string, string> vals = new Dictionary<string, string>()
                {
                    ["\"Surname\""] = textBoxSurnameInput.Text,
                    ["\"Name\""] = textBoxNameInput.Text,
                    ["\"Middle_Name\""] = textBoxMiddleNameInput.Text,
                    ["\"Passport_ID\""] = maskedtextBoxInputPassID.Text,
                    ["\"Date_Birth\""] = dateTimeInputDateBirth.Text,
                    ["\"Resident_Address\""] = textBoxInputAddress.Text
                };
                vals = PrepareData(vals);
                try
                {
                    if (Text == "Редактирование")
                    {
                        Authorization.DBC.Update("\"Client\"", Config.valueFromTableForEdit["ID"], vals);
                        MessageBox.Show("Запись успешно обновлена.");
                        ClearForm();
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Client\"",vals);
                        MessageBox.Show("Клиент добавлен.");
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    return;
                }
                this.Close();
            }
        }
        // 
        private void ButtonCancelAddClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
