using SqlCreater.Validator;
using System;
using System.Collections.Generic;
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
            string columnType = cb_columnTypes.Text;
            if (columnType.containsSizeLength())
            {
                this.tb_columnTotalLength.Enabled = true;
                this.tb_decLength.Enabled = false;
            }
            else if (columnType.containsSizeAndDecimalLength())
            {
                this.tb_columnTotalLength.Enabled = true;
                this.tb_decLength.Enabled = true;
            }
            else
            {
                this.tb_columnTotalLength.Enabled = false;
                this.tb_decLength.Enabled = false;
            }
        }

        private void tb_columnTotalLength_TextChanged(object sender, EventArgs e)
        {
            lb_totalLength.Visible = tb_columnTotalLength.Text.Length < 1;
            if (!SqlCreater.Validator.Validator.IsInteger(tb_columnTotalLength.Text))
            {
                MessageBox.Show("请输入有效的数字！");
                lb_totalLength.Visible = true;
                tb_columnTotalLength.Text = "";
            }
        }

        private void tb_decLength_TextChanged(object sender, EventArgs e)
        {
            lb_decimalLength.Visible = tb_decLength.Text.Length < 1;
            if (!tb_decLength.Text.IsInteger())
            {
                MessageBox.Show("请输入有效的数字！");
                lb_decimalLength.Visible = true;
                tb_decLength.Text = "";
            }
        }
    }
}
