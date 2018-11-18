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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(24, 9);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(114, 25);
            this.tb_name.TabIndex = 0;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // cb_columnTypes
            // 
            this.cb_columnTypes.FormattingEnabled = true;
            this.cb_columnTypes.Location = new System.Drawing.Point(167, 8);
            this.cb_columnTypes.Name = "cb_columnTypes";
            this.cb_columnTypes.Size = new System.Drawing.Size(154, 26);
            this.cb_columnTypes.TabIndex = 1;
            // 
            // lb_columnName
            // 
            this.lb_columnName.AutoSize = true;
            this.lb_columnName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_columnName.Location = new System.Drawing.Point(20, 10);
            this.lb_columnName.Name = "lb_columnName";
            this.lb_columnName.Size = new System.Drawing.Size(106, 24);
            this.lb_columnName.TabIndex = 2;
            this.lb_columnName.Text = "输入列名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(163, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择列类型";
            // 
            // ColumnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_columnName);
            this.Controls.Add(this.cb_columnTypes);
            this.Controls.Add(this.tb_name);
            this.Name = "ColumnControl";
            this.Size = new System.Drawing.Size(630, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox cb_columnTypes;
        private System.Windows.Forms.Label lb_columnName;
        private System.Windows.Forms.Label label1;
    }
}
