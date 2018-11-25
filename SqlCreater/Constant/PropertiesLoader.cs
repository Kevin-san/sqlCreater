using SqlCreater.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCreater.Constant
{
    public static class PropertiesLoader
    {
        public static string directory = System.AppDomain.CurrentDomain.BaseDirectory;
        /// <summary>
        /// use '=' as seperator to spilt to string[2].
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Dictionary<string,List<string>> loadProperties(this string fileName)
        {
            Dictionary<string, List<string>> propertiesItems = new Dictionary<string, List<string>>();
            string realName = directory + fileName;
            char[] seperator = new char[1] { '=' };
            StreamReader reader = realName.streamReader();
            List<string> allLines = reader.getAllLines();
            for (int i = 0; i < allLines.Count; i++)
            {
                string item = allLines[i];
                string[] items = item.Split(seperator,2);
                string key = items[0];
                string value = items[1];
                if (propertiesItems.ContainsKey(key))
                {
                    propertiesItems[key].Add(value);
                }
                else
                {
                    List<string> values = new List<string>();
                    values.Add(value);
                    propertiesItems.Add(key, values);
                }
            }
            return propertiesItems;
        }
        /// <summary>
        /// read all lines to list 
        /// </summary>
        /// <param name="streamReader"></param>
        /// <returns></returns>
        public static List<string> getAllLines(this StreamReader streamReader)
        {
            List<string> lines = new List<string>();
            
            while (streamReader.Peek() >= 0)
            {
                string line = streamReader.ReadLine();
                if (!"".Equals(line))
                {
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}
