using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlCreater
{
    public partial class SqlCreaterForm : Form
    {
        private string dbType = "mysql";
        private string lngType = "ddl";
        private string database="";
        private string table = "";
        private int idIndex = 0;
        private System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[0-9a-zA-Z_]+$");
        public SqlCreaterForm()
        {
            InitializeComponent();
        }

        private void bt_init_Click(object sender, EventArgs e)
        {
            database = tb_database.Text;

            if ("".Equals(database) || regex.IsMatch(database))
            {
                MessageBox.Show("请输入有效的数据库名！");
            }
            else
            {
                if (lngType.Equals(Constant.DDL))
                {

                }
            }
        }

        private void rb_dbType_CheckedChanged(object sender, EventArgs e)
        {
            dbType = gb_dbTypes.getRadioButtonValues(dbType);
        }

        private void rb_lngType_CheckedChanged(object sender, EventArgs e)
        {
            lngType = gb_lgTypes.getRadioButtonValues(lngType);
        }

        private void btn_addColumn_Click(object sender, EventArgs e)
        {
            database = tb_database.Text;
            table = tb_table.Text;
            if ("".Equals(database) || regex.IsMatch(database))
            {
                MessageBox.Show("请输入有效的数据库名！");
                return;
            }
            this.gb_dbTypes.disableRadioButton();
            this.gb_lgTypes.disableRadioButton();
            this.tb_database.Enabled = false;
            this.tb_table.Enabled = false;
            ColumnControl columnControl = new ColumnControl(Constant.keyColumns[dbType]);
            columnControl.TabIndex = idIndex;
            idIndex++;
            gb_columns.Controls.Add(columnControl);
        }
    }
}
