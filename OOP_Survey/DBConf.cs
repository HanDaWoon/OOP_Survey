using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace OOP_Survey
{
    enum eTName : int { _user }
    internal class DBConf
    {
        public static string Database = "oop_survey";
        public static string Server = "13.209.213.208";
        public static string Port = "53367";
        public static string UserID = "oop";
        public static string UserPassword = "oop";
        public static string ConnectionAddr = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};charset=utf8", Server, Port, Database, UserID, UserPassword);
        public static string[] Tables = { "user", "question" };

        public static DataSet user_ds = null;
        public static DataSet survey_ds = null;
    }
}
