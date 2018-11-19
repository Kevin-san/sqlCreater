namespace SqlCreater
{
    partial class ColumnControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_columnTypes = new System.Windows.Forms.ComboBox();
            this.lb_columnName = new System.Windows.Forms.Label();
            this.lb_columnType = new System.Windows.Forms.Label();
            this.tb_columnTotalLength = new System.Windows.Forms.TextBox();
            this.lb_totalLength = new System.Windows.Forms.Label();
            this.tb_decLength = new System.Windows.Forms.TextBox();
            this.lb_decimalLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(24, 9);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(137, 35);
            this.tb_name.TabIndex = 0;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // cb_columnTypes
            // 
            this.cb_columnTypes.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_columnTypes.FormattingEnabled = true;
            this.cb_columnTypes.Location = new System.Drawing.Point(167, 9);
            this.cb_columnTypes.Name = "cb_columnTypes";
            this.cb_columnTypes.Size = new System.Drawing.Size(172, 34);
            this.cb_columnTypes.TabIndex = 1;
            this.cb_columnTypes.TextChanged += new System.EventHandler(this.cb_columnTypes_TextChanged);
            // 
            // lb_columnName
            // 
            this.lb_columnName.AutoSize = true;
            this.lb_columnName.BackColor = System.Drawing.SystemColors.Window;
            this.lb_columnName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.lb_columnName.Location = new System.Drawing.Point(29, 13);
            this.lb_columnName.Name = "lb_columnName";
            this.lb_columnName.Size = new System.Drawing.Size(130, 24);
            this.lb_columnName.TabIndex = 2;
            this.lb_columnName.Text = "输入字段名";
            // 
            // lb_columnType
            // 
            this.lb_columnType.AutoSize = true;
            this.lb_columnType.BackColor = System.Drawing.SystemColors.Window;
            this.lb_columnType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_columnType.Location = new System.Drawing.Point(176, 13);
            this.lb_columnType.Name = "lb_columnType";
            this.lb_columnType.Size = new System.Drawing.Size(154, 24);
            this.lb_columnType.TabIndex = 3;
            this.lb_columnType.Text = "选择字段类型";
            // 
            // tb_columnTotalLength
            // 
            this.tb_columnTotalLength.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_columnTotalLength.Location = new System.Drawing.Point(358, 8);
            this.tb_columnTotalLength.Name = "tb_columnTotalLength";
            this.tb_columnTotalLength.Size = new System.Drawing.Size(147, 35);
            this.tb_columnTotalLength.TabIndex = 4;
            this.tb_columnTotalLength.TextChanged += new System.EventHandler(this.tb_columnTotalLength_TextChanged);
            // 
            // lb_totalLength
            // 
            this.lb_totalLength.AutoSize = true;
            this.lb_totalLength.BackColor = System.Drawing.SystemColors.Window;
            this.lb_totalLength.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.lb_totalLength.Location = new System.Drawing.Point(363, 13);
            this.lb_totalLength.Name = "lb_totalLength";
            this.lb_totalLength.Size = new System.Drawing.Size(130, 24);
            this.lb_totalLength.TabIndex = 5;
            this.lb_totalLength.Text = "输入总长度";
            // 
            // tb_decLength
            // 
            this.tb_decLength.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_decLength.Location = new System.Drawing.Point(530, 8);
            this.tb_decLength.Name = "tb_decLength";
            this.tb_decLength.Size = new System.Drawing.Size(164, 35);
            this.tb_decLength.TabIndex = 6;
            this.tb_decLength.TextChanged += new System.EventHandler(this.tb_decLength_TextChanged);
            // 
            // lb_decimalLength
            // 
            this.lb_decimalLength.AutoSize = true;
            this.lb_decimalLength.BackColor = System.Drawing.SystemColors.Window;
            this.lb_decimalLength.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.lb_decimalLength.Location = new System.Drawing.Point(535, 13);
            this.lb_decimalLength.Name = "lb_decimalLength";
            this.lb_decimalLength.Size = new System.Drawing.Size(154, 24);
            this.lb_decimalLength.TabIndex = 7;
            this.lb_decimalLength.Text = "输入小数长度";
            // 
            // ColumnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_decimalLength);
            this.Controls.Add(this.tb_decLength);
            this.Controls.Add(this.lb_totalLength);
            this.Controls.Add(this.tb_columnTotalLength);
            this.Controls.Add(this.lb_columnType);
            this.Controls.Add(this.lb_columnName);
            this.Controls.Add(this.cb_columnTypes);
            this.Controls.Add(this.tb_name);
            this.Name = "ColumnControl";
            this.Size = new System.Drawing.Size(714, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox cb_columnTypes;
        private System.Windows.Forms.Label lb_columnName;
        private System.Windows.Forms.Label lb_columnType;
        private System.Windows.Forms.TextBox tb_columnTotalLength;
        private System.Windows.Forms.Label lb_totalLength;
        private System.Windows.Forms.TextBox tb_decLength;
        private System.Windows.Forms.Label lb_decimalLength;
    }
}
