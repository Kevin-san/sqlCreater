﻿using System;
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

        }
    }
}
