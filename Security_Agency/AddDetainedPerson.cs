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
    public partial class AddDetainedPerson : Form
    {
        private AddCall mainForm;
        public AddDetainedPerson()
        {
            InitializeComponent();
            FillForm();
        }
        // Заполнение формы при старте
        private void FillForm()
        {
            ClearForm();
        }
        //
        private void ClearForm()
        {
            textBoxSurnameInput.Text = "";
            textBoxNameInput.Text = "";
            textBoxMiddleNameInput.Text = "";
            maskedtextBoxInputPassID.Text = "";
        }
        //
        private string ConvertToStringDB(string text)
        {
            return "'" + text + "'";
        }
        // убирает все пустые значения, выполняет преобразования к строке
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
            var newDict = new Dictionary<string, string>();
            foreach (var key in vals.Keys)
                newDict.Add(key, ConvertToStringDB(vals[key]));
            return newDict;
        }
        //
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                this.buttonAddDetainedPerson.Text = "Сохранить";
                textBoxSurnameInput.Text = Config.valueFromTableForEdit["Фамилия"];
                textBoxNameInput.Text = Config.valueFromTableForEdit["Имя"];
                textBoxMiddleNameInput.Text = Config.valueFromTableForEdit["Отчество"];
                maskedtextBoxInputPassID.Text = Config.valueFromTableForEdit["Номер паспорта"];
            }
            else
            {
                ClearForm();
                FillForm();
            }
        }
        //
        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            if (textBoxSurnameInput.Text == "" || textBoxNameInput.Text == ""
               || maskedtextBoxInputPassID.Text == "")
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
                    ["\"Passport_ID\""] = maskedtextBoxInputPassID.Text
                };
                vals = PrepareData(vals);
                try
                {
                    if (Text == "Редактирование")
                    {
                        Authorization.DBC.Update("\"Detained_person\"", Config.valueFromTableForEdit["ID"], vals);
                        MessageBox.Show("Запись о задержанном лице была обновлена.");
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Detained_person\"", vals);
                        MessageBox.Show("Задержанное лицо добавлено.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
                this.Close();
            }
        }
        //
        private void ButtonCancelAddDetainedPerson_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
