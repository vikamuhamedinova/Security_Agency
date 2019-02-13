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
    public partial class AddWork_Equipment : Form
    {
        private MainForm mainForm;
        private AddContract addContract;
        private string pkContract;
        private bool isAddContract;
        private List<int> emplIDs = new List<int>();

        //
        public AddWork_Equipment()
        {
            InitializeComponent();
        }
        //
        public AddWork_Equipment(MainForm form)
        {
            InitializeComponent();
            ClearForm();
            UpdateComboBoxies();
            mainForm = form;
            isAddContract = false;
        }
        //
        public AddWork_Equipment(AddContract form, string pkContract)
        {
            InitializeComponent();
            ClearForm();
            UpdateComboBoxies();
            addContract = form;
            this.pkContract = pkContract;
            isAddContract = true;
        }
        //
        private void ClearForm()
        {
            textBoxInputNameWork.Text = "";
            dateTimeInputPlanWork.Text = "01.01.2017";
            dateTimeInputWork.Text = "01.01.2017";
            checkBoxWorkDone.Checked = false;
        }
        // Обновление комбоБоксов при страте и добавлении квартир, сотрудников, клиентов
        private void UpdateComboBoxies()
        {
            // Очищаем все комбоБоксы
            comboBoxMaster.Items.Clear();
            // И список ключей
            emplIDs.Clear();
            // Заполняем данными все комбоБоксы
            // Сотрудники
            string currentTable;
            DataTable dataTable = new DataTable();
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
                    string positionTitle = Authorization.DBC.GetNameByFK("\"Position_Title\"", "\"Position\"", row["Position_ID"].ToString());
                    if (positionTitle != "Специалист по монтажу оборудования") //если не сотрудник отдела по работе с клиентами
                        continue;
                    emplIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    comboBoxMaster.Items.Add(
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
            if(!isAddContract)
            {
                if (vals["\"Work_Date\""] == "  .  .")
                {
                    vals.Remove("\"Work_Date\"");
                }
            }
            if (vals["\"Approximate_Date\""] == "  .  .")
            {
                vals.Remove("\"Approximate_Date\"");
            }
            var newDict = new Dictionary<string, string>();
            foreach (var key in vals.Keys)
            {
                if (key.ToLower().Contains("date"))
                {
                    newDict.Add(key, ConvertToDateDB(vals[key]));
                }
                else
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
            }
            return newDict;
        }
        //
        private void AddWorkEquip_Load(object sender, EventArgs e)
        {
            if (isAddContract)
            {
                dateTimeInputWork.Enabled = false;
                checkBoxWorkDone.Enabled = false;
                comboBoxMaster.Enabled = false;
            }
            if (Text == "Редактирование")
            {
                this.buttonAddWork.Text = "Сохранить";
                textBoxInputNameWork.Text = Config.valueFromTableForEdit["Наименование работы"];
                dateTimeInputPlanWork.Text = Config.valueFromTableForEdit["Планируемая дата проведения работ"];
                dateTimeInputWork.Text = Config.valueFromTableForEdit["Дата выполнения"];
                comboBoxMaster.SelectedIndex = comboBoxMaster.FindStringExact(Config.valueFromTableForEdit["Сотрудник"]);
                checkBoxWorkDone.Checked = Config.valueFromTableForEdit["Статус"] == "Выполнено" ? true : false;
            }
            else
            {
                
                ClearForm();
            }   
        }
        // 
        private void ButtonAddWorkEquip_Click(object sender, EventArgs e)
        {
            if (textBoxInputNameWork.Text == "" || dateTimeInputPlanWork.Text == "01.01.2000")
            {
                MessageBox.Show("Не заполнено одно из обязательных полей");
            }
            else
            {
                if(isAddContract)
                {
                    Dictionary<string, string> vals = new Dictionary<string, string>()
                    {
                        ["\"Name_Work\""] = textBoxInputNameWork.Text,
                        ["\"Approximate_Date\""] = dateTimeInputPlanWork.Text,
                        ["\"Execution_Fact\""] = Convert.ToString(checkBoxWorkDone.Checked),
                        ["\"PK_Contract\""] = pkContract
                    };
                    vals = PrepareData(vals);
                    try
                    {
                        if (Text == "Редактирование")
                        {
                            Authorization.DBC.Update("\"Work_Equipment\"", Config.valueFromTableForEdit["ID"], vals);
                            MessageBox.Show("Запись успешно обновлена.");
                            ClearForm();
                        }
                        else
                        {
                            Authorization.DBC.Insert("\"Work_Equipment\"", vals);
                            MessageBox.Show("Работа добавлена.");
                            ClearForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }
                else
                {
                    {
                        pkContract = Authorization.DBC.GetPKByFK("\"PK_Contract\"", "\"Work_Equipment\"", Config.valueFromTableForEdit["ID"]);
                        Dictionary<string, string> vals = new Dictionary<string, string>()
                        {
                            ["\"Name_Work\""] = textBoxInputNameWork.Text,
                            ["\"Approximate_Date\""] = dateTimeInputPlanWork.Text,
                            ["\"Work_Date\""] = dateTimeInputWork.Text,
                            ["\"Execution_Fact\""] = Convert.ToString(checkBoxWorkDone.Checked),
                            ["\"PK_Employee\""] = Convert.ToString(emplIDs[comboBoxMaster.SelectedIndex]),
                            ["\"PK_Contract\""] = pkContract 
                        };
                        vals = PrepareData(vals);
                        try
                        {
                            if (Text == "Редактирование")
                            {
                                Authorization.DBC.Update("\"Work_Equipment\"", Config.valueFromTableForEdit["ID"], vals);
                                MessageBox.Show("Запись успешно обновлена.");
                                ClearForm();
                            }
                            else
                            {
                                Authorization.DBC.Insert("\"Work_Equipment\"", vals);
                                MessageBox.Show("Работа добавлена.");
                                ClearForm();
                            }
                        }
                        catch (Exception ex)
                        {
                            return;
                        }
                    }
                }
                
                this.Close();
            }
        }
        // 
        private void ButtonCancelAddWorkEquip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
