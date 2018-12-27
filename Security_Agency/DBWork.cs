using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Npgsql;

namespace Security_Agency
{
    public class DBWork
    {
        private static DBWork instance = null;
        public static NpgsqlConnection _connection;

        public static DBWork CreateDBWork(string host, string port, string username,
            string password, string database, string sslMode = "Require",
            string trustServerCertificate = "true")
        {
            if (instance != null)
            {
                return instance;
            }
            string connection = String.Format("Host={0}; Port={1}; Username={2}; " +
                "Password={3}; Database={4}; SSL Mode={5}; Trust Server Certificate={6}",
                host, port, username, password, database, sslMode, trustServerCertificate);
            return new DBWork(connection);
        }

        public DBWork(string connectionString)
        {
            _connection = new NpgsqlConnection(connectionString);
            _connection.Open();
        }

        ~DBWork()
        {
            _connection.Close();
        }

        //
        public NpgsqlDataAdapter Select(string table, Dictionary<string, string> values = null,
            DataGridView tableView = null)
        {
            string selectString = "select ";
            if (values == null)
            {
                selectString += "* ";
            }
            else
            {
                foreach (KeyValuePair<string, string> pair in values)
                {
                    selectString += String.Format("{0} as {1}, ", pair.Key, pair.Value);
                }
                // убираем запятую в конце
                selectString = selectString.Substring(0, selectString.Length - 2) + " ";
            }
            selectString += String.Format(" from {0}", table);
            NpgsqlCommand command = new NpgsqlCommand(selectString, _connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            // если DataGridView не null, загрузим выборку в нее
            if (tableView != null)
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //Сделаем все клетки типа string
                DataTable dtStringed = dataTable.Clone();
                foreach (DataColumn column in dtStringed.Columns)
                {
                    column.DataType = typeof(string);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    dtStringed.ImportRow(row);
                }
                tableView.DataSource = dtStringed;
                tableView.Columns["ID"].Visible = false;
            }
            return adapter;
        }
        //
        public NpgsqlDataAdapter SelectPKProperty(string table,string where, Dictionary<string, string> values = null,
            DataGridView tableView = null)
        {
            string selectString = "select ";
            if (values == null)
            {
                selectString += "* ";
            }
            else
            {
                foreach (KeyValuePair<string, string> pair in values)
                {
                    selectString += String.Format("{0} as {1}, ", pair.Key, pair.Value);
                }
                // убираем запятую в конце
                selectString = selectString.Substring(0, selectString.Length - 2) + " ";
            }
            selectString += String.Format("from {0},", table);
            selectString = selectString.Substring(0, selectString.Length - 1) + " ";
            string nameTable1 = table.Substring(1, table.Length - 2);
            selectString += String.Format("where {0}.\"{1}_Name\"={2}", table, nameTable1, where);
            NpgsqlCommand command = new NpgsqlCommand(selectString, _connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            // если DataGridView не null, загрузим выборку в нее
            if (tableView != null)
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //Сделаем все клетки типа string
                DataTable dtStringed = dataTable.Clone();
                foreach (DataColumn column in dtStringed.Columns)
                {
                    column.DataType = typeof(string);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    dtStringed.ImportRow(row);
                }
                tableView.DataSource = dtStringed;
                tableView.Columns["ID"].Visible = false;
            }
            return adapter;
        }
        //
        public NpgsqlDataAdapter SelectPKResident(string table, string where, Dictionary<string, string> values = null,
            DataGridView tableView = null)
        {
            string selectString = "select ";
            if (values == null)
            {
                selectString += "* ";
            }
            else
            {
                foreach (KeyValuePair<string, string> pair in values)
                {
                    selectString += String.Format("{0} as {1}, ", pair.Key, pair.Value);
                }
                // убираем запятую в конце
                selectString = selectString.Substring(0, selectString.Length - 2) + " ";
            }
            selectString += String.Format("from {0},", table);
            selectString = selectString.Substring(0, selectString.Length - 1) + " ";
            string nameTable1 = table.Substring(1, table.Length - 2);
            selectString += String.Format("where {0}.\"Passport_ID\"={1}", table, where);
            NpgsqlCommand command = new NpgsqlCommand(selectString, _connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            // если DataGridView не null, загрузим выборку в нее
            if (tableView != null)
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //Сделаем все клетки типа string
                DataTable dtStringed = dataTable.Clone();
                foreach (DataColumn column in dtStringed.Columns)
                {
                    column.DataType = typeof(string);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    dtStringed.ImportRow(row);
                }
                tableView.DataSource = dtStringed;
                tableView.Columns["ID"].Visible = false;
            }
            return adapter;
        }
        //
        public NpgsqlDataAdapter Select(List<string> tables, Dictionary<string, string> values = null,
            DataGridView tableView = null)
        {
            string selectString = "select ";
            if (values == null)
            {
                selectString += "* ";
            }
            else
            {
                foreach (KeyValuePair<string, string> pair in values)
                {
                    selectString += String.Format("{0} as {1}, ", pair.Key, pair.Value);
                }
                // убираем запятую в конце
                selectString = selectString.Substring(0, selectString.Length - 2) + " ";
            }
            selectString += "from ";
            foreach (string table in tables)
            {
                selectString += String.Format("{0},", table);
            }
            selectString = selectString.Substring(0, selectString.Length - 1) + " ";
            string nameTable1 = tables[0].Substring(1, tables[0].Length - 2);
            selectString += String.Format("where {0}.\"PK_{1}\"={2}.\"PK_{1}\"", tables[0], nameTable1, tables[1]);
            NpgsqlCommand command = new NpgsqlCommand(selectString, _connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            // если DataGridView не null, загрузим выборку в нее
            if (tableView != null)
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //Сделаем все клетки типа string
                DataTable dtStringed = dataTable.Clone();
                foreach (DataColumn column in dtStringed.Columns)
                {
                    column.DataType = typeof(string);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    dtStringed.ImportRow(row);
                }
                tableView.DataSource = dtStringed;
                tableView.Columns["ID"].Visible = false;
            }
            return adapter;
        }
        //
        public NpgsqlDataAdapter Select(List<string> tables, string where, Dictionary<string, string> values = null,
            DataGridView tableView = null)
        {
            string selectString = "select ";
            if (values == null)
            {
                selectString += "* ";
            }
            else
            {
                foreach (KeyValuePair<string, string> pair in values)
                {
                    selectString += String.Format("{0} as {1}, ", pair.Key, pair.Value);
                }
                // убираем запятую в конце
                selectString = selectString.Substring(0, selectString.Length - 2) + " ";
            }
            selectString += "from ";
            foreach (string table in tables)
            {
                selectString += String.Format("{0},", table);
            }
            selectString = selectString.Substring(0, selectString.Length - 1) + " ";
            string nameTable1 = tables[0].Substring(1, tables[0].Length - 2);
            selectString += String.Format("where {0}.\"PK_{1}\"={2}.\"PK_{1}\"", tables[0], nameTable1, tables[1]);
            selectString += String.Format("and {0}.\"PK_Apartment\"={1}", tables[1], where);
            NpgsqlCommand command = new NpgsqlCommand(selectString, _connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            // если DataGridView не null, загрузим выборку в нее
            if (tableView != null)
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //Сделаем все клетки типа string
                DataTable dtStringed = dataTable.Clone();
                foreach (DataColumn column in dtStringed.Columns)
                {
                    column.DataType = typeof(string);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    dtStringed.ImportRow(row);
                }
                tableView.DataSource = dtStringed;
                tableView.Columns["ID"].Visible = false;
            }
            return adapter;
        }
        //
        public NpgsqlDataAdapter SelectDetainedPerson(List<string> tables, string pkApartmen, string pkCall, Dictionary<string, string> values = null,
            DataGridView tableView = null)
        {
            string selectString = "select ";
            if (values == null)
            {
                selectString += "* ";
            }
            else
            {
                foreach (KeyValuePair<string, string> pair in values)
                {
                    selectString += String.Format("{0} as {1}, ", pair.Key, pair.Value);
                }
                // убираем запятую в конце
                selectString = selectString.Substring(0, selectString.Length - 2) + " ";
            }
            selectString += "from ";
            foreach (string table in tables)
            {
                selectString += String.Format("{0},", table);
            }
            selectString = selectString.Substring(0, selectString.Length - 1) + " ";
            string nameTable = tables[0].Substring(1, tables[0].Length - 2);
            selectString += String.Format("where {0}.\"PK_{1}\"={2}.\"PK_{1}\"", tables[0], nameTable, tables[1]);
            selectString += String.Format("and {0}.\"PK_Apartment\"={1}", tables[1], pkApartmen);
            selectString += String.Format("and {0}.\"PK_{1}\"={2}", tables[0], nameTable, pkCall);
            NpgsqlCommand command = new NpgsqlCommand(selectString, _connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            // если DataGridView не null, загрузим выборку в нее
            if (tableView != null)
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //Сделаем все клетки типа string
                DataTable dtStringed = dataTable.Clone();
                foreach (DataColumn column in dtStringed.Columns)
                {
                    column.DataType = typeof(string);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    dtStringed.ImportRow(row);
                }
                tableView.DataSource = dtStringed;
                tableView.Columns["ID"].Visible = false;
            }
            return adapter;
        }
        /// <summary>
        /// Вставляет в таблицу table значения из словаря vals
        /// </summary>
        /// <param name="table">Таблица, куда будем вставлять.</param>
        /// <param name="vals">Ключи словаря - это столбцы, куда вставляем, а значения, что вставляем.</param>
        public void Insert(string table, Dictionary<string, string> vals)
        {
            string where = "";              // что вставляем
            string what = "";               // куда вставляем
            foreach (var pair in vals)
            {
                where += pair.Key + ", ";
                what += pair.Value + ", ";
            }
            where = where.Substring(0, where.Length - 2);
            what = what.Substring(0, what.Length - 2);
            string insertString = String.Format("insert into {0} ({1}) values ({2})", table, where, what);
            NpgsqlCommand command = new NpgsqlCommand(insertString, _connection);
            command.ExecuteNonQuery();
        }
        //
        public void Update(string table, string idEntry, Dictionary<string, string> dict)
        {
            //"Update <table> set <what>=<value>, ... where ID=<idEntry>;
            string updateString = "update " + table + " set ";
            if (dict == null)
                return;
            //На вход могут быть поданы строки с кавычками
            foreach (var k in dict.Keys)
            {
                if (k == "" || dict[k] == "ID")
                    continue;
                if (k.Split('_')[0] == "Date")
                {
                    DateTime date = DateTime.ParseExact(dict[k], "dd.MM.yyyy H:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    dict[k] = date.ToString("yyyy-MM-dd HH:mm:ss");
                }
                updateString += k + " = " + dict[k] + " ,";
            }
            updateString = updateString.Substring(0, updateString.Length - 2);
            string nameTable = table.Substring(1, table.Length - 2);
            updateString += String.Format(" where \"PK_{0}\" = {1}", nameTable, idEntry);
            NpgsqlCommand command = new NpgsqlCommand(updateString, _connection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Удаляет информацию из таблицы по заданным условиям в кортеже.
        /// </summary>
        /// <param name="table">Таблица из которой удаляем</param>
        /// <param name="condition">Для конструкции вида: where Item1=Item2</param>
        public void Delete(string table, Tuple<string, string> condition)
        {
            string deleteString = "delete from " + table + " ";
            if (condition == null)
                return;
            deleteString += String.Format("where {0}={1}", condition.Item1, condition.Item2);
            NpgsqlCommand command = new NpgsqlCommand(deleteString, _connection);
            command.ExecuteNonQuery();
        }

        // 
        public string GetNameByFK(string what, string table, string id)
        {
            string nameTable = table.Substring(1, table.Length - 2);
            string selectString = String.Format("select {0} from {1} where \"PK_{2}\" = {3}", what, table, nameTable, id);
            NpgsqlCommand command = new NpgsqlCommand(selectString, _connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            string ret = "";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ret = reader.GetString(0);
                }
            }
            reader.Close();
            return ret;
        }

        //
       /* public string GetCostByFK(string what, string table, string id)
        {
            string nameTable = table.Substring(1, table.Length - 2);
            string selectString = String.Format("select {0} from {1} where \"PK_{2}\" = {3}", what, table, nameTable, id);
            NpgsqlCommand command = new NpgsqlCommand(selectString, _connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            string ret = "";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ret = reader.GetValue(0).ToString();
                }
            }
            reader.Close();
            return ret;
        }*/
        /// <summary>
        /// Обновление записи в таблице.
        /// </summary>
        /*  public void Update(string table, string idEntry, List<string> name, List<string> value)
          {
              //"Update <table> set <what>=<value>, ... where ID=<idEntry>;
              string updateString = "update " + table + " set ";


              //На вход могут быть поданы строки с кавычками
              for (int i = 0; i < name.Count; i++)
              {
                  if (name[i][0] == '\"')
                  {
                      name[i] = name[i].Substring(1, name[i].Length - 2);
                  }
                  else
                      break;
              }

              if (value == null || name == null)
                  return;

              for (int i = 0; i < name.Count; i++)
              {
                  if (value[i] == "" || name[i] == "ID")
                      continue;
                  if (name[i].Split('_')[0] == "Date")
                  {

                      DateTime date = DateTime.ParseExact(value[i], "dd.MM.yyyy H:mm:ss",
                                         System.Globalization.CultureInfo.InvariantCulture);
                      value[i] = date.ToString("yyyy-MM-dd HH:mm:ss");

                  }
                  //Клеим паспорт
                  if (name[i] == "Passport")
                  {
                      updateString += "\"Passport_series\" = '" + value[i].Split(' ')[0] + "' ,";
                      updateString += "\"Passport_ID\" = '" + value[i].Split(' ')[1] + "' ,";
                      continue;
                  }
                  updateString += "\"" + name[i] + "\" = '" + value[i] + "' ,";
              }

              updateString = updateString.Substring(0, updateString.Length - 2);
              updateString += String.Format(" where \"ID\" = {0}", idEntry);

              NpgsqlCommand command = new NpgsqlCommand(updateString, _connection);
              command.ExecuteNonQuery();

          }*/




    }
}
