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
    public partial class AddForfeit_Type : Form
    {
        private MainForm mainForm;

        public AddForfeit_Type()
        {
            InitializeComponent();
        }
        //
        public AddForfeit_Type(MainForm form)
        {
            InitializeComponent();
            ClearForm();
            mainForm = form;
        }
        //
        private void ClearForm()
        {
            textBoxForfeitNameInput.Text = "";
            textBoxForfeitCostInput.Text = "00000000,00";
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
                if (!key.ToLower().Contains("cost"))
                {
                    newDict.Add(key, ConvertToStringDB(vals[key]));
                }
                else
                {
                    newDict.Add(key, ConvertFromRoubleToDoubleDB(vals[key]));
                }
            }
            return newDict;
        }
        //
        private void AddForfeitType_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                this.buttonAddForfeitType.Text = "Сохранить";
                textBoxForfeitNameInput.Text = Config.valueFromTableForEdit["Наименование штрафа"];
                textBoxForfeitCostInput.Text = Config.valueFromTableForEdit["Денежный размер"];
            }
            else
                ClearForm();
        }
        // 
        private void ButtonAddForfeitType_Click(object sender, EventArgs e)
        {
            if (textBoxForfeitNameInput.Text == "" || textBoxForfeitCostInput.Text == "00000000,00")
            {
                MessageBox.Show("Не заполнено одно из обязательных полей");
            }
            else
            {
                Dictionary<string, string> vals = new Dictionary<string, string>()
                {
                    ["\"Forfeit_name\""] = textBoxForfeitNameInput.Text,
                    ["\"Cost\""] = textBoxForfeitCostInput.Text
                };
                vals = PrepareData(vals);
                try
                {
                    if (Text == "Редактирование")
                    {
                        Authorization.DBC.Update("\"Forfeit_Type\"", Config.valueFromTableForEdit["ID"], vals);
                        MessageBox.Show("Запись успешно обновлена.");
                        ClearForm();
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Forfeit_Type\"", vals);
                        MessageBox.Show("Штраф добавлен.");
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
        private void ButtonCancelAddForfeitType_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
