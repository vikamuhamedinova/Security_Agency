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
    public partial class AddApartment : Form
    {
        private MainForm mainForm;

        public AddApartment()
        {
            InitializeComponent();
        }
        //
        public AddApartment(MainForm form)
        {
            InitializeComponent();
            ClearForm();
            mainForm = form;
        }
        //
        private void ClearForm()
        {
            textBoxApartmentAdressInput.Text = "";
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
                newDict.Add(key, ConvertToStringDB(vals[key]));
            }
            return newDict;
        }
        //
        private void AddApartment_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                this.buttonAddApartment.Text = "Сохранить";
                textBoxApartmentAdressInput.Text = Config.valueFromTableForEdit["Адрес"];
            }
            else
                ClearForm();
        }
        // 
        private void ButtonAddApartment_Click(object sender, EventArgs e)
        {
            if (textBoxApartmentAdressInput.Text == "")
            {
                MessageBox.Show("Не заполнено одно из обязательных полей");
            }
            else
            {
                Dictionary<string, string> vals = new Dictionary<string, string>()
                {
                    ["\"Address\""] = textBoxApartmentAdressInput.Text
                };
                vals = PrepareData(vals);
                try
                {
                    if (Text == "Редактирование")
                    {
                        Authorization.DBC.Update("\"Apartment\"", Config.valueFromTableForEdit["ID"], vals);
                        MessageBox.Show("Запись успешно обновлена.");
                        ClearForm();
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Apartment\"", vals);
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
        private void ButtonCancelAddApartmentClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
