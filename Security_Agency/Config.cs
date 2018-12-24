using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_Agency
{
    public static class Config
    {
        public const string host = "192.168.186.161";
        public const string port = "5432";
        public const string username = "bd_admin";
        public const string password = "Qwerty12345";
        public const string database = "testdb";

        public static Dictionary<string, string> methodTranslate = new Dictionary<string, string>()
        {
            ["Работа с клиентами"] = "Clients",
            ["Работа с договорами"] = "Contracts",
            ["Работа с сотрудниками"] = "Employees",
            ["Платежи"] = "Payments",
            ["Штрафы"] = "Fines",
            ["Сигналы тревоги"] = "Calls",
            ["Украденные вещи"] = "Stolen_stuffss"
        };

        public static Dictionary<string, string> valueFromTableForEdit = new Dictionary<string, string>();

        public static int CurrentIndex;

    }
}
