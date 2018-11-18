using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCreater
{
    class Constant
    {
        public static readonly string DDL = "ddl";
        public static readonly string DML = "dml";
        public static readonly string DCL = "dcl";
        public static readonly string DQL = "dql";

        public static List<string> mysqlColumns = new List<string>();
        public static List<string> oracleColumns = new List<string>();
        public static List<string> mssqlColumns = new List<string>();
        public static List<string> sybaseColumns = new List<string>();
        public static List<string> sqliteColumns = new List<string>();
        public static List<string> postgresqlColumns = new List<string>();
        public static Dictionary<string, List<string>> keyColumns = new Dictionary<string, List<string>>();
        static Constant()
        {
            mysqlColumns.Add("TINYINT");
            mysqlColumns.Add("SMALLINT");
            mysqlColumns.Add("MEDIUMINT");
            mysqlColumns.Add("INT");
            mysqlColumns.Add("INTEGER");
            mysqlColumns.Add("BIGINT");
            mysqlColumns.Add("FLOAT");
            mysqlColumns.Add("FLOAT");
            mysqlColumns.Add("DOUBLE");
            mysqlColumns.Add("REAL");
            mysqlColumns.Add("DECIMAL");
            mysqlColumns.Add("NUMERIC");
            mysqlColumns.Add("DATE");
            mysqlColumns.Add("DATETIME");
            mysqlColumns.Add("TIMESTAMP");
            mysqlColumns.Add("TIME");
            mysqlColumns.Add("YEAR");
            mysqlColumns.Add("CHAR");
            mysqlColumns.Add("VARCHAR");
            mysqlColumns.Add("TINYBLOB");
            mysqlColumns.Add("TINYTEXT");
            mysqlColumns.Add("BLOB");
            mysqlColumns.Add("TEXT");
            mysqlColumns.Add("MEDIUMBLOB");
            mysqlColumns.Add("MEDIUMTEXT");
            mysqlColumns.Add("LONGBLOB");
            mysqlColumns.Add("LONGTEXT");
            mysqlColumns.Add("ENUM");
            mysqlColumns.Add("SET");

            keyColumns.Add("mysql", mysqlColumns);
        }
    }
}
