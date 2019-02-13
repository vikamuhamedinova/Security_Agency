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
    public partial class AddInvoice : Form
    {
        private MainForm mainForm;
        private List<int> emplIDs = new List<int>(),
                          contrIDs = new List<int>(),
                          invIDs = new List<int>();
        private string pkInvoice;

        //
        public AddInvoice()
        {
            InitializeComponent();
            FillForm();
        }
        //
        public AddInvoice(MainForm mainForm)
        {
            InitializeComponent();
            FillForm();
            this.mainForm = mainForm;
            dataGridViewPayments.Columns.Add("ID", "ID");
            dataGridViewPayments.Columns.Add("Договор", "Договор");
            dataGridViewPayments.Columns.Add("Счет", "Счет");
            dataGridViewPayments.Columns.Add("Наименование", "Наименование");
            dataGridViewPayments.Columns.Add("Стоимость", "Стоимость");
            dataGridViewPayments.Columns.Add("Тип", "Тип");
        }
        // Заполнение формы при старте
        private void FillForm()
        {
            ClearForm();
            UpdateComboBoxies();
        }
        // Обновление комбоБоксов при страте и добавлении квартир, сотрудников, клиентов
        private void UpdateComboBoxies()
        {
            // Очищаем все комбоБоксы
            comboBoxAddContract.Items.Clear();
            comboBoxAddEmployee.Items.Clear();
            // И список ключей
            emplIDs.Clear();
            contrIDs.Clear();
            // Заполняем данными все комбоБоксы
            string currentTable;
            DataTable dataTable = new DataTable();
            // Сотрудники
            try
            {
                currentTable = "\"Employee\"";
                var adapter = Authorization.DBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"PK_Employee\""] = "ID",
                                                            ["\"Surname\""] = "Фамилия",
                                                            ["\"Name\""] = "Имя",
                                                            ["\"Middle_Name\""] = "Отчество",
                                                            ["\"PK_Position\""] = "Position_ID"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["Position_ID"].ToString() != "2") //если не сотрудник отдела по работе с клиентами
                        continue;
                    emplIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    comboBoxAddEmployee.Items.Add(
                          row["Фамилия"].ToString() + " "
                        + row["Имя"].ToString() + " "
                        + row["Отчество"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();
            // Клиенты
            try
            {
                currentTable = "\"Contract\"";
                var adapter = Authorization.DBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"PK_Contract\""] = "ID",
                                                            ["\"Contract_ID\""] = "Номер",
                                                            ["\"PK_Client\""] = "Клиент"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    contrIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    string client = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"", "\"Client\"", row["Клиент"].ToString());
                    comboBoxAddContract.Items.Add(
                        row["Номер"].ToString() + " "
                        + client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();
        }
        //
        private void ClearForm()
        {
            maskedTextBoxInvoiceIdInput.Text = "";
            dateTimeInvoiceInput.Text = "01.01.2000";
        }
        //
        private string ConvertToStringDB(string text)
        {
            return "'" + text + "'";
        }
        // преобразование к дате
        private string ConvertToDateDB(string text)
        {
            return String.Format("TO_DATE('{0}','DD.MM.YYYY')", text);
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
            if (vals["\"Date_Formation\""] == "  .  .")
            {
                vals.Remove("\"Date\"");
            }
            var newDict = new Dictionary<string, string>();
            foreach (var key in vals.Keys)
            {
                if (key.ToLower().Contains("date"))
                {
                    newDict.Add(key, ConvertToDateDB(vals[key]));
                }
                else if (key.ToLower().Contains("pk"))
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
        private Dictionary<string, string> PrepareDataPayment(Dictionary<string, string> vals)
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
                newDict.Add(key, vals[key]);
            }
            return newDict;
        }
        //
        private Dictionary<string, string> PrepareDataInvoice(Dictionary<string, string> vals)
        {
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
        private int GetSelectedRow(DataGridView dataGridView)
        {
            int index;
            try
            {
                index = dataGridView.CurrentCell.RowIndex;
            }
            catch (Exception)
            {
                index = -1;
            }
            return index;
        }
        //
        public void PaymentsList()
        {
            double sum = 0;
            dataGridViewPayments.Rows.Clear();
            try
            {
                List<string> tables = new List<string>();
                tables.Add("\"Forfeit_Type\"");
                tables.Add("\"Forfeit\"");
                string where = pkInvoice;
                var adapter = Authorization.DBC.SelectW(tables, where, "Invoice",
                values: new Dictionary<string, string>()
                {
                    ["\"Forfeit\".\"PK_Forfeit\""] = "\"ID\"",
                    ["\"Forfeit\".\"PK_Contract\""] = "\"Договор\"",
                    ["\"Forfeit\".\"PK_Invoice\""] = "\"Счет\"",
                    ["\"Forfeit\".\"PK_Forfeit_Type\""] = "\"Наименование\"",
                    ["\"Forfeit_Type\".\"Cost\""] = "\"Стоимость\""
                }
                );
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    int index = dataGridViewPayments.Rows.Add();
                    dataGridViewPayments.Rows[index].Cells["ID"].Value = row["ID"].ToString();
                    dataGridViewPayments.Rows[index].Cells["Договор"].Value = row["Договор"].ToString();
                    dataGridViewPayments.Rows[index].Cells["Счет"].Value = row["Счет"].ToString();
                    dataGridViewPayments.Rows[index].Cells["Наименование"].Value = Authorization.DBC.GetNameByFK("\"Forfeit_name\"",
                                                                                                                 "\"Forfeit_Type\"",
                                                                                                                 row["Наименование"].ToString());
                    dataGridViewPayments.Rows[index].Cells["Стоимость"].Value = row["Стоимость"].ToString();
                    dataGridViewPayments.Rows[index].Cells["Тип"].Value = "Штраф";
                    sum += Convert.ToDouble(row["Стоимость"].ToString());
                }
                tables.Clear();
                tables.Add("\"Payment_Type\"");
                tables.Add("\"Invoice_String\"");
                adapter = Authorization.DBC.SelectW(tables, where, "Invoice",
                values: new Dictionary<string, string>()
                {
                    ["\"Invoice_String\".\"PK_Invoice_String\""] = "\"ID\"",
                    ["\"Invoice_String\".\"PK_Contract\""] = "\"Договор\"",
                    ["\"Invoice_String\".\"PK_Invoice\""] = "\"Счет\"",
                    ["\"Invoice_String\".\"PK_Payment_Type\""] = "\"Наименование\"",
                    ["\"Payment_Type\".\"Cost\""] = "\"Стоимость\""
                }
                );
                dataTable.Clear();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    int index = dataGridViewPayments.Rows.Add();
                    dataGridViewPayments.Rows[index].Cells["ID"].Value = row["ID"].ToString();
                    dataGridViewPayments.Rows[index].Cells["Договор"].Value = row["Договор"].ToString();
                    dataGridViewPayments.Rows[index].Cells["Счет"].Value = row["Счет"].ToString();
                    dataGridViewPayments.Rows[index].Cells["Наименование"].Value = Authorization.DBC.GetNameByFK("\"Name_Type\"",
                                                                                                                 "\"Payment_Type\"",
                                                                                                                 row["Наименование"].ToString());
                    dataGridViewPayments.Rows[index].Cells["Стоимость"].Value = row["Стоимость"].ToString();
                    dataGridViewPayments.Rows[index].Cells["Тип"].Value = "Платеж";
                    sum += Convert.ToDouble(row["Стоимость"].ToString());
                }
                dataGridViewPayments.Columns["ID"].Visible = false;
                dataGridViewPayments.Columns["Договор"].Visible = false;
                dataGridViewPayments.Columns["Счет"].Visible = false;
                dataGridViewPayments.Columns["Тип"].Visible = false;
                if(sum != 0)
                {
                    labelSum.Text = Convert.ToString(sum);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //
        private void AddInvoice_Load(object sender, EventArgs e)
        {
            
            if (Text == "Редактирование")
            {
                UpdateComboBoxies();
                this.buttonAddInvoice.Text = "Сохранить";
                maskedTextBoxInvoiceIdInput.Text = Config.valueFromTableForEdit["Номер счета"];
                dateTimeInvoiceInput.Text = Config.valueFromTableForEdit["Дата формирования"];
                comboBoxAddContract.SelectedIndex = comboBoxAddContract.FindStringExact(Config.valueFromTableForEdit["Договор"]);
                comboBoxAddEmployee.SelectedIndex = comboBoxAddEmployee.FindStringExact(Config.valueFromTableForEdit["Сотрудник"]);
                pkInvoice = Config.valueFromTableForEdit["ID"];
                labelStatus.Text = Config.valueFromTableForEdit["Статус"];
                if(labelStatus.Text == "Неоплачен")
                {
                    labelDate.Text = "";
                    labelDefrayalSum.Text = "";
                    buttonAddDefrayal.Enabled = true;
                    buttonEditDefrayal.Enabled = false;
                    buttonDeleteDefrayal.Enabled = false;
                }
                else
                {
                    labelDate.Text = Authorization.DBC.GetPKByFK("\"Date_Defrayal\"", "\"Defrayal\"", Config.valueFromTableForEdit["Оплата"]);
                    labelDefrayalSum.Text = Authorization.DBC.GetPKByFK("\"Contr_Amount\"", "\"Defrayal\"", Config.valueFromTableForEdit["Оплата"]);
                    buttonAddDefrayal.Enabled = false;
                    buttonEditDefrayal.Enabled = true;
                    buttonDeleteDefrayal.Enabled = true;
                }
                PaymentsList();
            }
            else
            {
                FillForm();
                dataGridViewPayments.Columns["ID"].Visible = false;
                dataGridViewPayments.Columns["Договор"].Visible = false;
                dataGridViewPayments.Columns["Счет"].Visible = false;
                dataGridViewPayments.Columns["Тип"].Visible = false;
                groupBoxDefrayal.Enabled = false;
                groupBoxPayments.Enabled = false;
                labelStatus.Text = "Неоплачен";
                labelDate.Text = "";
                labelDefrayalSum.Text = "";
            }
        }
        //
        private void ButtonAddInvoice_Click(object sender, EventArgs e)
        {
            if ((comboBoxAddContract.SelectedIndex == -1) ||
                (comboBoxAddEmployee.SelectedIndex == -1) ||
                (maskedTextBoxInvoiceIdInput.Text == "") ||
                (dateTimeInvoiceInput.Text == "01.01.2000"))
            {
                MessageBox.Show("Не заполнено одно из обязательных полей");
            }
            else
            {
                Dictionary<string, string> vals = new Dictionary<string, string>()
                {
                    ["\"Invoice_ID\""] = maskedTextBoxInvoiceIdInput.Text,
                    ["\"Date_Formation\""] = dateTimeInvoiceInput.Text,
                    ["\"Payment_State\""] = "false",
                    ["\"PK_Contract\""] = Convert.ToString(contrIDs[comboBoxAddContract.SelectedIndex]),
                    ["\"PK_Employee\""] = Convert.ToString(emplIDs[comboBoxAddEmployee.SelectedIndex])
                };
                vals = PrepareData(vals);
                try
                {
                    if (Text == "Редактирование")
                    {
                        Authorization.DBC.Update("\"Invoice\"", Config.valueFromTableForEdit["ID"], vals);
                        MessageBox.Show("Счет был обновлен.");
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Invoice\"", vals);
                        DataTable dataTable = new DataTable();
                        string where = ConvertToStringDB(maskedTextBoxInvoiceIdInput.Text);
                        ///
                        var adapter = Authorization.DBC.SelectPK("\"Invoice\"", where,
                                                                new Dictionary<string, string>()
                                                                {
                                                                    ["\"PK_Invoice\""] = "ID"
                                                                });
                        ///
                        adapter.Fill(dataTable);
                        DataRow row = dataTable.Rows[0];
                        pkInvoice = row["ID"].ToString();
                        MessageBox.Show("Счет добавлен.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
                groupBoxPayments.Enabled = true;
                groupBoxDefrayal.Enabled = true;
                PaymentsList();
            }
        }
        //
        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void ButtonCancelAddInvoice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        //
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = (string) comboBoxType.SelectedItem;
            // Очищаем комбоБокс
            comboBoxAddPayment.Items.Clear();
            // И список ключей
            invIDs.Clear();
            // Заполняем данными комбоБокс
            DataTable dataTable = new DataTable();
            string currentTableInvoice;
            // Сотрудники
            try
            {
                if(type == "Штраф")
                {
                    currentTableInvoice = "\"Forfeit_Type\"";
                    var adapter = Authorization.DBC.Select(currentTableInvoice,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"PK_Forfeit_Type\""] = "ID",
                                                            ["\"Forfeit_name\""] = "Наименование",
                                                            ["\"Cost\""] = "Стоимость"
                                                        });
                    adapter.Fill(dataTable);
                }
                else
                {
                    currentTableInvoice = "\"Payment_Type\"";
                    var adapter = Authorization.DBC.Select(currentTableInvoice,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"PK_Payment_Type\""] = "ID",
                                                            ["\"Name_Type\""] = "Наименование",
                                                            ["\"Cost\""] = "Стоимость"
                                                        });
                    adapter.Fill(dataTable);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    invIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    comboBoxAddPayment.Items.Add(
                        row["Наименование"].ToString() + " "
                        + row["Стоимость"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();
        }
        //
        private void buttonAddPayment_Click(object sender, EventArgs e)
        {
            if ((comboBoxAddPayment.SelectedIndex == -1))
            {
                MessageBox.Show("Не заполнено одно из обязательных полей");
            }
            else
            {
                string type = (string)comboBoxType.SelectedItem;
                if(type == "Штраф")
                {
                    Dictionary<string, string> vals = new Dictionary<string, string>()
                    {
                        ["\"PK_Contract\""] = Convert.ToString(contrIDs[comboBoxAddContract.SelectedIndex]),
                        ["\"PK_Invoice\""] = pkInvoice,
                        ["\"PK_Forfeit_Type\""] = Convert.ToString(invIDs[comboBoxAddPayment.SelectedIndex])
                    };
                    vals = PrepareDataPayment(vals);
                    try
                    {
                        Authorization.DBC.Insert("\"Forfeit\"", vals);
                        MessageBox.Show("Штраф добавлен.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return;
                    }
                }
                else
                {
                    Dictionary<string, string> vals = new Dictionary<string, string>()
                    {
                        ["\"PK_Contract\""] = Convert.ToString(contrIDs[comboBoxAddContract.SelectedIndex]),
                        ["\"PK_Invoice\""] = pkInvoice,
                        ["\"PK_Payment_Type\""] = Convert.ToString(invIDs[comboBoxAddPayment.SelectedIndex])
                    };
                    vals = PrepareDataPayment(vals);
                    try
                    {
                        Authorization.DBC.Insert("\"Invoice_String\"", vals);
                        MessageBox.Show("Платеж добавлен.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return;
                    }
                }
                
                PaymentsList();
            }
        }
        //
        private void buttonDeletePayment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int index = GetSelectedRow(dataGridViewPayments);
            if (index == -1)
            {
                MessageBox.Show("Необходимо выбрать строку.");
                return;
            }
            try
            {
                string id = dataGridViewPayments["ID", index].Value.ToString();
                string type = dataGridViewPayments["Тип", index].Value.ToString();
                if(type == "Штраф")
                {
                    Authorization.DBC.Delete("\"Forfeit\"", new Tuple<string, string>("\"PK_Forfeit\"", id));
                }
                else
                {
                    Authorization.DBC.Delete("\"Invoice_String\"", new Tuple<string, string>("\"PK_Invoice_String\"", id));
                }
                PaymentsList();
                MessageBox.Show("Запись успешно удалена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
        }
        //
        private void buttonAddDefrayal_Click(object sender, EventArgs e)
        {
            new AddDefrayal(this, pkInvoice, maskedTextBoxInvoiceIdInput.Text).ShowDialog();
            string state = Authorization.DBC.GetPKByFK("\"Payment_State\"", "\"Invoice\"", pkInvoice);
            labelStatus.Text = Config.TrueFalseInvoice[state];
            Config.valueFromTableForEdit["Статус"] = labelStatus.Text;
            Config.valueFromTableForEdit["Оплата"] = Authorization.DBC.GetPKByFK("\"PK_Defrayal\"", "\"Invoice\"", pkInvoice);
            labelDate.Text = Authorization.DBC.GetPKByFK("\"Date_Defrayal\"", "\"Defrayal\"", Config.valueFromTableForEdit["Оплата"]);
            labelDefrayalSum.Text = Authorization.DBC.GetPKByFK("\"Contr_Amount\"", "\"Defrayal\"", Config.valueFromTableForEdit["Оплата"]);
            buttonAddDefrayal.Enabled = false;
            buttonEditDefrayal.Enabled = true;
            buttonDeleteDefrayal.Enabled = true;
        }
        //
        private void buttonEditDefrayal_Click(object sender, EventArgs e)
        {
            try
            {
                string invoiceID = maskedTextBoxInvoiceIdInput.Text;
                string pkDefrayal = Config.valueFromTableForEdit["Оплата"];
                Config.valueForEdit.Clear();
                Config.valueForEdit.Add("Дата оплаты", labelDate.Text);
                Config.valueForEdit.Add("Внесенная сумма", labelDefrayalSum.Text);
                var form = Activator.CreateInstance(Type.GetType("Security_Agency.AddDefrayal"), this, pkInvoice, pkDefrayal, invoiceID) as Form;
                form.Text = "Редактирование";
                form.ShowDialog();
                Config.valueFromTableForEdit["Оплата"] = Authorization.DBC.GetPKByFK("\"PK_Defrayal\"", "\"Invoice\"", pkInvoice);
                labelDate.Text = Authorization.DBC.GetPKByFK("\"Date_Defrayal\"", "\"Defrayal\"", Config.valueFromTableForEdit["Оплата"]);
                labelDefrayalSum.Text = Authorization.DBC.GetPKByFK("\"Contr_Amount\"", "\"Defrayal\"", Config.valueFromTableForEdit["Оплата"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
        }
        //
        private void buttonDeleteDefrayal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            try
            {
                string id = Config.valueFromTableForEdit["Оплата"];
                Dictionary<string, string> vals = new Dictionary<string, string>()
                {
                    ["\"Payment_State\""] = "false",
                    ["\"PK_Defrayal\""] = "null"
                };
                vals = PrepareDataInvoice(vals);
                Authorization.DBC.Update("\"Invoice\"", pkInvoice, vals);
                Authorization.DBC.Delete("\"Defrayal\"", new Tuple<string, string>("\"PK_Defrayal\"", id));
                
                string state = Authorization.DBC.GetPKByFK("\"Payment_State\"", "\"Invoice\"", pkInvoice);
                labelStatus.Text = Config.TrueFalseInvoice[state];
                Config.valueFromTableForEdit["Статус"] = labelStatus.Text;
                labelDate.Text = "";
                labelDefrayalSum.Text = "";
                buttonAddDefrayal.Enabled = true;
                buttonEditDefrayal.Enabled = false;
                buttonDeleteDefrayal.Enabled = false;
                MessageBox.Show("Запись успешно удалена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
        }
    }
}
