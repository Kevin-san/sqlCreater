using System.Collections.Generic;

namespace SqlCreater.Constant
{
    public class Constant
    {
        public static readonly string DDL = "ddl";
        public static readonly string DML = "dml";
        public static readonly string DCL = "dcl";
        public static readonly string DQL = "dql";

        public static readonly string ALL_TYPES = "all_types.properties";

        public static readonly string MYSQL = "MYSQL";
        public static readonly string MSSQL = "MSSQL";
        public static readonly string ORACLE = "ORACLE";
        public static readonly string SYBASE = "SYBASE";
        public static readonly string SQLITE = "SQLITE";
        public static readonly string POSTGRESQL = "POSTGRESQL";

        public static readonly string CONFIG_ALL_TYPES = "Config/all_types.properties";
        public static Dictionary<string, List<string>> KEY_COLUMNS = CONFIG_ALL_TYPES.loadProperties();

    }
}
