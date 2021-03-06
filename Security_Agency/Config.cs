﻿using System;
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
            ["Работа со счетами"] = "Invoices",
            ["Сигналы тревоги"] = "Calls",
            ["Работы"] = "Work_Equipments",
            ["Должности"] = "Positions",
            ["Типы штрафов"] = "Forfeit_Types",
            ["Типы платежей"] = "Payment_Types"
            
        };

        public static Dictionary<string, string> TrueFalse = new Dictionary<string, string>()
        {
            ["True"] = "Да",
            ["False"] = "Нет"
        };

        public static Dictionary<string, string> TrueFalseWork = new Dictionary<string, string>()
        {
            ["True"] = "Выполнено",
            ["False"] = "Невыполнено"
        };

        public static Dictionary<string, string> TrueFalseInvoice = new Dictionary<string, string>()
        {
            ["True"] = "Оплачен",
            ["False"] = "Неоплачен"
        };

        public static Dictionary<string, string> valueFromTableForEdit = new Dictionary<string, string>();

        public static Dictionary<string, string> valueForEdit = new Dictionary<string, string>();

        public static int CurrentIndex;

    }
}
