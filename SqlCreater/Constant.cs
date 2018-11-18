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

        public static List<string> columnTypes = new List<string>();
    }
}
