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
    public partial class AddResident : Form
    {
        private AddContract mainForm;
        private string pkApartmen;

        public AddResident()
        {
            InitializeComponent();
        }
        //
        public AddResident(AddContract form, string _pkApartmen)
        {
            InitializeComponent();
            ClearForm();
            mainForm = form;
            pkApartmen = _pkApartmen;
        }
        //
        private void ClearForm()
        {
            textBoxSurnameInput.Text = "";
            textBoxNameInput.Text = "";
            textBoxMiddleNameInput.Text = "";
            dateTimeInputDateBirth.Text = "01.01.2000";
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
        private void AddResident_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                this.buttonAddResident.Text = "Сохранить";
                textBoxSurnameInput.Text = Config.valueFromTableForEdit["Фамилия"];
                textBoxNameInput.Text = Config.valueFromTableForEdit["Имя"];
                textBoxMiddleNameInput.Text = Config.valueFromTableForEdit["Отчество"];
                dateTimeInputDateBirth.Text = Config.valueFromTableForEdit["Дата рождения"];
                maskedtextBoxInputPassID.Text = Config.valueFromTableForEdit["Номер паспорта"];
            }
            else
                ClearForm();
        }
        // 
        private void ButtonAddResident_Click(object sender, EventArgs e)
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
                    ["\"Passport_ID\""] = maskedtextBoxInputPassID.Text,
                    ["\"Date_Birth\""] = dateTimeInputDateBirth.Text,
                };
                vals = PrepareData(vals);
                try
                {
                    if (Text == "Редактирование")
                    {
                        Authorization.DBC.Update("\"Resident\"", Config.valueFromTableForEdit["ID"], vals);
                        MessageBox.Show("Запись успешно обновлена.");
                        ClearForm();
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Resident\"", vals);
                        DataTable dataTable = new DataTable();
                        string where = ConvertToStringDB(maskedtextBoxInputPassID.Text);
                        var adapter = Authorization.DBC.SelectPKResident("\"Resident\"", where,
                                                                new Dictionary<string, string>()
                                                                {
                                                                    ["\"PK_Resident\""] = "ID"
                                                                });
                        adapter.Fill(dataTable);
                        string pkProperty;
                        DataRow row = dataTable.Rows[0];
                        pkProperty = row["ID"].ToString();
                        Dictionary<string, string> vals1 = new Dictionary<string, string>()
                        {
                            ["\"PK_Apartment\""] = pkApartmen,
                            ["\"PK_Resident\""] = pkProperty
                        };
                        Authorization.DBC.Insert("\"List_Resident\"", vals1);
                        MessageBox.Show("Проживающий добавлен.");
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
        private void ButtonCancelAddResident_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }             
    }
}
