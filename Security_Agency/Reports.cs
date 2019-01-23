using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Security_Agency
{
    public partial class Reports : Form
    {
        private List<int> contractIDs;

        public Reports()
        {
            InitializeComponent();
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
        /*public bool CheckGrid()
        {
            return dataGridViewInvoices.Columns.Count >= 1;
        }
        */
        // неоплаченные платежи
        private void unpaidInvoicesButton_Click(object sender, EventArgs e)
        {
        /*private void unpaidInvoicesButton_Click(object sender, EventArgs e)
        {
            if (contractComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Необходимо выбрать контракт");
                return;
            }

            string selectString = String.Format(@"select distinct ""inv_type"".""Name"" as ""Тип платежа"", 
                 ""c"".""Surname"" || ' ' || ""c"".""Name"" || ' ' || ""c"".""Otch"" as ""ФИО клиента"",
                ""table"".""Invoice_sdate"" as ""Дата выставления счета"",
                ""con"".""Subscription_fee"" as ""Сумма к оплате""
                from unpaid_invoices({0}) ""table"", ""InvoiceType"" ""inv_type"", ""Client"" ""c"", 
                ""Employee"" ""e"", ""Contract"" ""con""
                where ""table"".""ID_invoice_type"" = ""inv_type"".""ID"" and 
                ""table"".""Contract_ID"" = ""con"".""ID"" and ""con"".""ID_client"" = ""c"".""ID""", contractIDs[contractComboBox.SelectedIndex]);

            NpgsqlCommand command = new NpgsqlCommand(selectString, Authorization.DBC._connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewInvoices.DataSource = dataTable;
        }*/
        }
        // неоплаченные штрафы
        private void unpaidFinesButton_Click(object sender, EventArgs e)
        {
        /* private void unpaidFinesButton_Click(object sender, EventArgs e)
         {
             if (contractComboBox.SelectedIndex == -1)
             {
                 MessageBox.Show("Необходимо выбрать контракт");
                 return;
             }

             string selectString = String.Format(@"select distinct ""f_type"".""Name"" as ""Тип штрафа"", 
                  ""c"".""Surname"" || ' ' || ""c"".""Name"" || ' ' || ""c"".""Otch"" as ""ФИО клиента"",
                 ""table"".""Date"" as ""Дата выставления счета"",
                 ""table"".""Sum"" as ""Сумма к оплате""
                 from unpaid_fines(30) ""table"", ""FineType"" ""f_type"", ""Client"" ""c"",
                 ""Contract"" ""con""
                 where ""table"".""ID_type_fine"" = ""f_type"".""ID"" and
                 ""table"".""Contract_ID"" = ""con"".""ID"" and ""con"".""ID_client"" = ""c"".""ID""", contractIDs[contractComboBox.SelectedIndex]);
             NpgsqlCommand command = new NpgsqlCommand(selectString, Authorization.DBC._connection);
             NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
             adapter.SelectCommand = command;

             DataTable dataTable = new DataTable();
             adapter.Fill(dataTable);
             dataGridViewInvoices.DataSource = dataTable;
         }*/
        }
        // получить денежную информацию
        private void commonInfoButton_Click(object sender, EventArgs e)
        {
        /* private void commonInfoButton_Click(object sender, EventArgs e)
         {
             if (contractComboBox.SelectedIndex == -1)
             {
                 MessageBox.Show("Необходимо выбрать контракт");
                 return;
             }

             string selectString = String.Format(@"select ""cl"".""Surname"" || ' ' || ""cl"".""Name"" || ' ' || ""cl"".""Otch"" as ""ФИО клиента"",
                     ""table"".""sum_payments"" as ""Сумма  всех платежей"",
                     ""table"".""sum_unpaid_invoices"" as ""Сумма неоплаченных счетов"",
                     ""table"".""sum_fines"" as ""Сумма неоплаченных штрафов""
                     from getitemsbytypeforcontract({0}) ""table"", ""Contract"" ""c"", ""Client"" ""cl""
                     where ""c"".""ID"" = {0} and ""c"".""ID_client"" = ""cl"".""ID""", contractIDs[contractComboBox.SelectedIndex]);
             NpgsqlCommand command = new NpgsqlCommand(selectString, Authorization.DBC._connection);
             NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
             adapter.SelectCommand = command;

             DataTable dataTable = new DataTable();
             adapter.Fill(dataTable);
             dataGridViewInvoices.DataSource = dataTable;
         }*/
        }
        // экспорт в html
        private void buttonExportHTML_Click(object sender, EventArgs e)
        {
        /* private void button2_Click(object sender, EventArgs e)
         {
             if (!CheckGrid())
             {
                 MessageBox.Show("Сначала нужно выполнить запрос");
                 return;
             }

             string table = "";
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

             html = html.Split('^')[0] + table + html.Split('^')[1];

             saveFileDialog1.Filter = "Html страницы|*.html";
             if (saveFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                 writer.Write(html);
                 writer.Close();
                 MessageBox.Show("Отчет успешно сохранен");
                 System.Diagnostics.Process.Start(saveFileDialog1.FileName);
             }
         }*/
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
        /* private void button3_Click(object sender, EventArgs e)
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
             // storing header part in Excel  
             for (int i = 1; i < dataGridViewInvoices.Columns.Count + 1; i++)
             {
                 worksheet.Cells[1, i] = dataGridViewInvoices.Columns[i - 1].HeaderText;
             }
             // storing Each row and column value to excel sheet  
             for (int i = 0; i < dataGridViewInvoices.Rows.Count - 1; i++)
             {
                 for (int j = 0; j < dataGridViewInvoices.Columns.Count; j++)
                 {
                     worksheet.Cells[i + 2, j + 1] = dataGridViewInvoices.Rows[i].Cells[j].Value.ToString();
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
         */
        }




        




        



    }
}

