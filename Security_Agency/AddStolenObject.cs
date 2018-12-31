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
    public partial class AddStolenObject : Form
    {
        private AddCall mainForm;
        private string pkCall,
                       pkApartment,
                       pkStolenObject;

        public AddStolenObject()
        {
            InitializeComponent();
        }
        //
        public AddStolenObject(AddCall mainForm, string pkCall, string pkApartment)
        {
            InitializeComponent();
            ClearForm();
            mainForm = mainForm;
            this.mainForm = mainForm;
            this.pkApartment = pkApartment;
            this.pkCall = pkCall;
        }
        //
        private void ClearForm()
        {
            textBoxPropertyNameInput.Text = "";
            textBoxPropertyAmmountInput.Text = "";
        }
        // преобразование к строке
        private string ConvertToStringDB(string text)
        {
            return "'" + text + "'";
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
                if(key.ToLower().Contains("name"))
                {
                    newDict.Add(key, ConvertToStringDB(vals[key]));
                }
                else
                {
                    newDict.Add(key, vals[key]);
                }
                
            }
            return newDict;
        }
        //
        private void AddStolenObject_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                this.buttonAddStolenProperty.Text = "Сохранить";
                pkStolenObject = Config.valueFromTableForEdit["ID"];
                textBoxPropertyNameInput.Text = Config.valueFromTableForEdit["Наименование имущества"];
                textBoxPropertyNameInput.Text = Config.valueFromTableForEdit["Количество"];
            }
            else
                ClearForm();
        }
        // 
        private void ButtonAddStolenObject_Click(object sender, EventArgs e)
        {
            if (textBoxPropertyNameInput.Text == "" || textBoxPropertyAmmountInput.Text == "")
            {
                MessageBox.Show("Не заполнено одно из обязательных полей");
            }
            else
            {
                Dictionary<string, string> vals = new Dictionary<string, string>()
                {
                    ["\"Name\""] = textBoxPropertyNameInput.Text,
                    ["\"Amount\""] = textBoxPropertyAmmountInput.Text,
                    ["\"PK_Apartment\""] = pkApartment,
                    ["\"PK_Call\""] = pkCall
                };
                vals = PrepareData(vals);
                try
                {
                    if (Text == "Редактирование")
                    {
                        Authorization.DBC.Update("\"Stolen_Object\"", Config.valueFromTableForEdit["ID"], vals);
                        MessageBox.Show("Запись успешно обновлена.");
                        ClearForm();
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Stolen_Object\"", vals);
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
        private void ButtonCancelAddStolenObject_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
