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
    public partial class AddProperty : Form
    {
        private AddContract mainForm;
        private string pkApartmen;

        public AddProperty()
        {
            InitializeComponent();
        }
        //
        public AddProperty(AddContract form, string _pkApartmen)
        {
            InitializeComponent();
            ClearForm();
            mainForm = form;
            pkApartmen = _pkApartmen;
        }
        //
        private void ClearForm()
        {
            textBoxPropertyNameInput.Text = "";
            textBoxPropertyCostInput.Text = "00000000,00";
        }
        // преобразование к строке
        private string ConvertToStringDB(string text)
        {
            return "'" + text + "'";
        }
        //
        private string ConvertFromRoubleToDoubleDB(string text)
        {
            text = text.Replace(',', '.');
            return text;
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
            var newDict = new Dictionary<string, string>();
            foreach (var key in vals.Keys)
            {
                if (key.ToLower().Contains("property_cost"))
                {
                    newDict.Add(key, ConvertFromRoubleToDoubleDB(vals[key]));
                }
                else
                {
                    newDict.Add(key, ConvertToStringDB(vals[key]));
                }  
            }
            return newDict;
        }
        //
        private void AddProperty_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                this.buttonAddProperty.Text = "Сохранить";
                textBoxPropertyNameInput.Text = Config.valueFromTableForEdit["Наименование"];
                textBoxPropertyCostInput.Text = Config.valueFromTableForEdit["Стоимость"];
            }
            else
                ClearForm();
        }
        // 
        private void ButtonAddProperty_Click(object sender, EventArgs e)
        {
            if (textBoxPropertyNameInput.Text == "" || textBoxPropertyCostInput.Text == "00000000,00")
            {
                MessageBox.Show("Не заполнено одно из обязательных полей");
            }
            else
            {
                Dictionary<string, string> vals = new Dictionary<string, string>()
                {
                    ["\"Property_Name\""] = textBoxPropertyNameInput.Text,
                    ["\"Property_Cost\""] = textBoxPropertyCostInput.Text
                };
                vals = PrepareData(vals);
                try
                {
                    if (Text == "Редактирование")
                    {
                        Authorization.DBC.Update("\"Property\"", Config.valueFromTableForEdit["ID"], vals);
                        MessageBox.Show("Запись успешно обновлена.");
                        ClearForm();
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Property\"", vals);
                        DataTable dataTable = new DataTable();
                        string where = ConvertToStringDB(textBoxPropertyNameInput.Text);
                        var adapter = Authorization.DBC.SelectPKProperty("\"Property\"", where,
                                                                new Dictionary<string, string>()
                                                                {
                                                                    ["\"PK_Property\""] = "ID"
                                                                });
                        adapter.Fill(dataTable);
                        string pkProperty;
                        DataRow row = dataTable.Rows[0];
                        pkProperty =  row["ID"].ToString();
                        Dictionary<string, string> vals1 = new Dictionary<string, string>()
                        {
                                ["\"PK_Apartment\""] = pkApartmen,
                                ["\"PK_Property\""] = pkProperty
                        };                       
                        Authorization.DBC.Insert("\"Property_List\"", vals1);
                        MessageBox.Show("Имущество добавлено.");
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
        private void ButtonCancelAddPropertyClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
