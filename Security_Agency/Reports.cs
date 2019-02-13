using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.IO;

namespace Security_Agency
{
    public partial class Reports : Form
    {
        private List<int> contractIDs;
        private string nameReport;
        private bool isCall;

        public Reports()
        {
            InitializeComponent();
            nameReport = "";
            Init();
        }
        //
        public void Init()
        {
            contractIDs = new List<int>();
            string currentTable;
            DataTable dataTable = new DataTable();
            // контракт
            try
            {
                currentTable = "\"Contract\"";
                var adapter = Authorization.DBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"PK_Contract\""] = "ID",
                                                            ["\"Contract_ID\""] = "Договор",
                                                            ["\"PK_Client\""] = "Клиент"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    contractIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    string client = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"",
                                                                  "\"Client\"",
                                                                  row["Клиент"].ToString());
                    string text = row["Договор"].ToString() + " " + client;
                    contractComboBox.Items.Add(text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            dataTable.Clear();
        }
        //
        public bool CheckGrid(DataGridView dataGridView)
        {
            return dataGridView.Columns.Count >= 1;
        }
        //
        private string ConvertToDateDB(string text)
        {
            return String.Format("TO_DATE('{0}','DD.MM.YYYY')", text);
        }
        // получить денежную информацию
        private void CommonInfoButton_Click(object sender, EventArgs e)
        {

            if (contractComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Необходимо выбрать контракт");
                return;
            }
            isCall = false;
            nameReport = "Общая денежная информация по договору";
            int index = contractComboBox.SelectedIndex;
            string text = contractComboBox.Items[index].ToString();
            string[] words = text.Split(new char[] { ' ' });
            string contractID = "'" + words[0] + "'";
            labelContract.Text = "Номер договора:" + " " + words[0];
            labelClient.Text = "Клиент:";
            for (int i = 1; i < 4; i++)
            {
                labelClient.Text = labelClient.Text + " " + words[i];
            }
            string selectString = String.Format(@"select distinct ""table"".""id_inv"" as ""Номер счета"",
                                                ""table"".""date_form"" as ""Дата выставления счета"",
                                                ""table"".""sum_payments"" as ""Сумма вех счетов"",
                                                ""table"".""sum_fines"" as ""Сумма всех штрафов""
                                                from get_all_invoice({0}) ""table""", contractID);
            NpgsqlCommand command = new NpgsqlCommand(selectString, Authorization.DBC._connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewInvoices.DataSource = dataTable;
        }
        // неоплаченные счета
        private void UnpaidInvoicesButton_Click(object sender, EventArgs e)
        {
            if (contractComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Необходимо выбрать договор");
                return;
            }
            isCall = false;
            nameReport = "Список неоплаченных счетов по договору";
            int index = contractComboBox.SelectedIndex;
            string text = contractComboBox.Items[index].ToString();
            string[] words = text.Split(new char[] { ' ' });
            string contractID = "'" + words[0] + "'";
            labelContract.Text = "Номер договора:" + " " + words[0];
            labelClient.Text = "Клиент:";
            for (int i = 1; i < 4; i++)
            {
                labelClient.Text = labelClient.Text + " " + words[i];
            }
            string selectString = String.Format(@"select distinct ""table"".""id_inv"" as ""Номер счета"",
                                                ""table"".""date_form"" as ""Дата выставления счета"",
                                                ""table"".""sum_payments"" as ""Сумма вех счетов"",
                                                ""table"".""sum_fines"" as ""Сумма всех штрафов""
                                                from get_unpaid_invoice({0}) ""table""", contractID);
            NpgsqlCommand command = new NpgsqlCommand(selectString, Authorization.DBC._connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewInvoices.DataSource = dataTable;
        }
        // 
        private void CallsButton_Click(object sender, EventArgs e)
        {
            isCall = true;
            nameReport = "Список клиентов на квартиру которых были вызваны наряды";
            string minDate = ConvertToDateDB(dateTimeStart.Text);
            string maxDate = ConvertToDateDB(dateTimEnd.Text);
            string selectString = String.Format(@"select distinct ""c"".""Surname"" || ' ' || ""c"".""Name"" || ' ' || ""c"".""Middle_Name"" as ""ФИО клиента"",
                                                                  ""table"".""contract_id"" as ""Номер договора"",
                                                                  ""table"".""address"" as ""Адрес"",
                                                                  ""table"".""n_calls"" as ""Количество вызовов""
                                                  from get_total_number_of_calls({0},{1},1) ""table"",
                                                       ""Client"" ""c"",
                                                       ""Contract"" ""con""
                                                  where ""table"".""contract_id"" = ""con"".""Contract_ID"" 
                                                        and ""con"".""PK_Client"" = ""c"".""PK_Client""",
                                                  minDate, maxDate);
            NpgsqlCommand command = new NpgsqlCommand(selectString, Authorization.DBC._connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewCalls.DataSource = dataTable;
        }
        // экспорт в html
        private void ButtonExportHTML_Click(object sender, EventArgs e)
        {
            string table = "",
                   clientOrDateStart = "", contractOrDateEnd = "";
            if (isCall)
            {
                if (!CheckGrid(dataGridViewCalls))
                {
                    MessageBox.Show("Сначала нужно выполнить запрос");
                    return;
                }
                clientOrDateStart = String.Format("<h4><p>Период с {0}</p></h4>", dateTimeStart.Text);
                contractOrDateEnd = String.Format("<h4><p>по {0}</p></h4>", dateTimEnd.Text);
                for (int i = 0; i < dataGridViewCalls.Columns.Count; i++)
                {
                    table += String.Format("<th>{0}</th>", dataGridViewCalls.Columns[i].Name);
                }
                table = String.Format("<tr>{0}</tr>", table);
                for (int i = 0; i < dataGridViewCalls.Rows.Count - 1; i++)
                {
                    table += "<tr>";
                    for (int j = 0; j < dataGridViewCalls.Columns.Count; j++)
                    {
                        table += String.Format("<td>{0}</td>", dataGridViewCalls[j, i].Value.ToString());
                    }
                    table += "</tr>";
                }
            }
            else
            {
                if (!CheckGrid(dataGridViewInvoices))
                {
                    MessageBox.Show("Сначала нужно выполнить запрос");
                    return;
                }
                clientOrDateStart = String.Format("<h4><p>{0}</p></h4>", labelClient.Text);
                contractOrDateEnd = String.Format("<h4><p>{0}</p></h4>", labelContract.Text);
                for (int i = 0; i < dataGridViewInvoices.Columns.Count; i++)
                {
                    table += String.Format("<th>{0}</th>", dataGridViewInvoices.Columns[i].Name);
                }
                table = String.Format("<tr>{0}</tr>", table);
                for (int i = 0; i < dataGridViewInvoices.Rows.Count - 1; i++)
                {
                    table += "<tr>";
                    for (int j = 0; j < dataGridViewInvoices.Columns.Count; j++)
                    {
                        table += String.Format("<td>{0}</td>", dataGridViewInvoices[j, i].Value.ToString());
                    }
                    table += "</tr>";
                }
            }
            string head = String.Format("<h1>{0}</h>",nameReport);
            table = String.Format("<table style=\"border-style: solid\">{0}</table>", table);
            string html = "<html>" +
                "<head>" +
                "<meta charset=\"UTF-8\">" +
                "<style>" +
                "table {" +
                "    border-style: solid;" +
                "    border-collapse: collapse;" +
                "}" +
                "th {" +
                "   padding: 15px;" +
                "   border-style: solid;" +
                "}" +
                "tr {" +
                "    border-style: solid;" +
                "}" +
                "td {" +
                "    border-style: solid;" +
                "    padding: 15px;" +
                "    text-align: center;" +
                "}" +
                "</style>" +
                "</head>" +
                "" +
                "<body>" +
                "^" +
                "</body>" +
                "" +
                "</html>";
            html = html.Split('^')[0] + head + clientOrDateStart + contractOrDateEnd + table + html.Split('^')[1];
            saveFileDialog1.Filter = "Html страницы|*.html";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.Write(html);
                writer.Close();
                MessageBox.Show("Отчет успешно сохранен");
                System.Diagnostics.Process.Start(saveFileDialog1.FileName);
            }
        }
        //
        private void ButtonExportExcel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // Выделяем диапазон ячеек от A1 до D1         
            Microsoft.Office.Interop.Excel.Range _excelCells1 = (Microsoft.Office.Interop.Excel.Range)worksheet.get_Range("A1", "D1").Cells;
            // Производим объединение
            _excelCells1.Merge(Type.Missing);
            worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 2]].Merge();
            worksheet.Range[worksheet.Cells[2, 3], worksheet.Cells[2, 4]].Merge();
            worksheet.Cells[1, 1] = nameReport;
            if (isCall)
            {
                if (!CheckGrid(dataGridViewCalls))
                {
                    MessageBox.Show("Сначала нужно выполнить запрос");
                    return;
                }
                worksheet.Cells[2, 1] = "Период с " + dateTimeStart.Text;
                worksheet.Cells[2, 3] = "по" + dateTimEnd.Text;
                // storing header part in Excel  
                for (int i = 1; i < dataGridViewCalls.Columns.Count + 1; i++)
                {
                    worksheet.Cells[3, i] = dataGridViewCalls.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridViewCalls.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridViewCalls.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 4, j + 1] = dataGridViewCalls.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            else
            {
                if (!CheckGrid(dataGridViewInvoices))
                {
                    MessageBox.Show("Сначала нужно выполнить запрос");
                    return;
                }
                worksheet.Cells[2, 1] = labelClient.Text;
                worksheet.Cells[2, 3] = labelContract.Text;
                // storing header part in Excel  
                for (int i = 1; i < dataGridViewInvoices.Columns.Count + 1; i++)
                {
                    worksheet.Cells[3, i] = dataGridViewInvoices.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridViewInvoices.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridViewInvoices.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 4, j + 1] = dataGridViewInvoices.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            saveFileDialog1.Filter = "Excel таблиы|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show("Отчет успешно сохранен");
            }
            app.Quit();
            System.Diagnostics.Process.Start(saveFileDialog1.FileName);
        }
    }
}

