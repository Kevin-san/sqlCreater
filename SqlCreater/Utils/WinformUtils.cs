using System.Windows.Forms;

namespace SqlCreater.Utils
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
        public static void disableRadioButton(this System.Windows.Forms.GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                RadioButton radioButton = item as RadioButton;
                radioButton.Enabled = false;
            }
        }
    }
}
