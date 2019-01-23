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
    public partial class AddDefrayal : Form
    {
        private AddInvoice mainForm;
        string pkInvoice;
        string invoiceID;
        string pkDefrayal;

        //
        public AddDefrayal()
        {
            InitializeComponent();
        }
        //
        public AddDefrayal(AddInvoice form, string pkInvoice, string invoiceID)
        {
            InitializeComponent();
            ClearForm();
            this.mainForm = form;
            this.pkInvoice = pkInvoice;
            this.invoiceID = invoiceID;
        }
        //
        public AddDefrayal(AddInvoice form, string pkInvoice, string pkDefrayal,string invoiceID)
        {
            InitializeComponent();
            ClearForm();
            this.mainForm = form;
            this.pkInvoice = pkInvoice;
            this.invoiceID = invoiceID;
            this.pkDefrayal = pkDefrayal;
        }
        //
        private void ClearForm()
        {
            dateTimeInputDefrayal.Text = "01.01.2000";
            textBoxDefrayalCountInput.Text = "00000000,00";
        }
        // преобразование к строке
        private string ConvertFromRoubleToDoubleDB(string text)
        {
            text = text.Replace(',', '.');
            return text;
        }
        // преобразование к дате
        private string ConvertToDateDB(string text)
        {
            return String.Format("TO_DATE('{0}','DD.MM.YYYY')", text);
        }
        //
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
            if (vals["\"Date_Defrayal\""] == "  .  .")
            {
                vals.Remove("\"Date_Defrayal\"");
            }
            var newDict = new Dictionary<string, string>();
            foreach (var key in vals.Keys)
            {
                if (key.ToLower().Contains("date"))
                {
                    newDict.Add(key, ConvertToDateDB(vals[key]));
                }
                else if(key.ToLower().Contains("id"))
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
        private Dictionary<string, string> PrepareDataInvoice(Dictionary<string, string> vals)
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
                if (key.ToLower().Contains("pk"))
                {
                    newDict.Add(key, vals[key]);
                }
                else
                {
                    newDict.Add(key, ConvertToStringDB(vals[key]));
                }
            }
            return newDict;
        }
        //
        private void AddDefrayal_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                this.buttonAddDefrayel.Text = "Сохранить";
                textBoxDefrayalCountInput.Text = Config.valueForEdit["Внесенная сумма"];
                dateTimeInputDefrayal.Text = Config.valueForEdit["Дата оплаты"];
            }
            else
                ClearForm();
        }
        // 
        private void ButtonAddDefrayal_Click(object sender, EventArgs e)
        {
            if (textBoxDefrayalCountInput.Text == "00000000,00" || dateTimeInputDefrayal.Text == "01.01.2000")
            {
                MessageBox.Show("Не заполнено одно из обязательных полей");
            }
            else
            {
                Dictionary<string, string> vals = new Dictionary<string, string>()
                {
                    ["\"Contr_Amount\""] = textBoxDefrayalCountInput.Text,
                    ["\"Date_Defrayal\""] = dateTimeInputDefrayal.Text,
                    ["\"Defrayal_ID\""] = invoiceID
                };
                vals = PrepareData(vals);
                try
                {
                    if (Text == "Редактирование")
                    {
                        Authorization.DBC.Update("\"Defrayal\"", pkDefrayal, vals);
                        MessageBox.Show("Запись успешно обновлена.");
                        ClearForm();
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Defrayal\"", vals);
                        DataTable dataTable = new DataTable();
                        string where = ConvertToStringDB(invoiceID);
                        var adapter = Authorization.DBC.SelectPK("\"Defrayal\"", where,
                                                                new Dictionary<string, string>()
                                                                {
                                                                    ["\"PK_Defrayal\""] = "ID"
                                                                });
                        adapter.Fill(dataTable);
                        DataRow row = dataTable.Rows[0];
                        pkDefrayal = row["ID"].ToString();
                        Dictionary<string, string> valsInvoice = new Dictionary<string, string>()
                        {
                            ["\"Payment_State\""] = "true",
                            ["\"PK_Defrayal\""] = pkDefrayal
                        };
                        valsInvoice = PrepareDataInvoice(valsInvoice);
                        Authorization.DBC.Update("\"Invoice\"", pkInvoice, valsInvoice);
                        MessageBox.Show("Клиент добавлен.");
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
        private void ButtonCancelAddDefrayal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
