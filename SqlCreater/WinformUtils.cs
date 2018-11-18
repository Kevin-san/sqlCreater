using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlCreater
{
    public static class WinformUtils
    {
        public static string getRadioButtonValues(this System.Windows.Forms.GroupBox groupBox,string defaultValue)
        {
            string value=null;
            foreach (Control item in groupBox.Controls)
            {
                RadioButton radioButton = item as RadioButton;
                if (radioButton != null && radioButton.Checked)
                {
                    value = radioButton.Text;
                }
            }
            return value==null?defaultValue:value;
        }
    }
}
