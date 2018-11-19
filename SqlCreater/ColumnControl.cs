using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlCreater
{
    public partial class ColumnControl : UserControl
    {
        public ColumnControl(List<string> types)
        {
            InitializeComponent();
            this.cb_columnTypes.Items.AddRange(types.ToArray());
            
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            lb_columnName.Visible = tb_name.Text.Length < 1;
        }

        private void cb_columnTypes_TextChanged(object sender, EventArgs e)
        {
            lb_columnType.Visible = cb_columnTypes.Text.Length < 1;
        }

        private void tb_columnTotalLength_TextChanged(object sender, EventArgs e)
        {
            lb_totalLength.Visible = tb_columnTotalLength.Text.Length < 1;
            if (!Validator.IsInteger(tb_columnTotalLength.Text))
            {
                MessageBox.Show("请输入有效的数字！");
                lb_totalLength.Visible = true;
                tb_columnTotalLength.Text = "";
            }
        }

        private void tb_decLength_TextChanged(object sender, EventArgs e)
        {
            lb_decimalLength.Visible = tb_decLength.Text.Length < 1;
            if (!Validator.IsInteger(tb_decLength.Text))
            {
                MessageBox.Show("请输入有效的数字！");
                lb_decimalLength.Visible = true;
                tb_decLength.Text = "";
            }
        }
    }
}
