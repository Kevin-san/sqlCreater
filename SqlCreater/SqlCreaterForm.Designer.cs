namespace SqlCreater
{
    partial class SqlCreaterForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_dbType = new System.Windows.Forms.Label();
            this.lb_languageType = new System.Windows.Forms.Label();
            this.gb_dbTypes = new System.Windows.Forms.GroupBox();
            this.rb_mysql = new System.Windows.Forms.RadioButton();
            this.rb_oracle = new System.Windows.Forms.RadioButton();
            this.rb_mssql = new System.Windows.Forms.RadioButton();
            this.rb_sybase = new System.Windows.Forms.RadioButton();
            this.rb_sqlite = new System.Windows.Forms.RadioButton();
            this.rb_postgresql = new System.Windows.Forms.RadioButton();
            this.gb_lgTypes = new System.Windows.Forms.GroupBox();
            this.rb_ddl = new System.Windows.Forms.RadioButton();
            this.rb_dml = new System.Windows.Forms.RadioButton();
            this.rb_dcl = new System.Windows.Forms.RadioButton();
            this.rb_dql = new System.Windows.Forms.RadioButton();
            this.lb_database = new System.Windows.Forms.Label();
            this.tb_database = new System.Windows.Forms.TextBox();
            this.bt_init = new System.Windows.Forms.Button();
            this.lb_table = new System.Windows.Forms.Label();
            this.tb_table = new System.Windows.Forms.TextBox();
            this.btn_addColumn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delColumn = new System.Windows.Forms.Button();
            this.gb_dbTypes.SuspendLayout();
            this.gb_lgTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_dbType
            // 
            this.lb_dbType.AutoSize = true;
            this.lb_dbType.Location = new System.Drawing.Point(12, 23);
            this.lb_dbType.Name = "lb_dbType";
            this.lb_dbType.Size = new System.Drawing.Size(116, 18);
            this.lb_dbType.TabIndex = 0;
            this.lb_dbType.Text = "数据库类型：";
            // 
            // lb_languageType
            // 
            this.lb_languageType.AutoSize = true;
            this.lb_languageType.Location = new System.Drawing.Point(12, 72);
            this.lb_languageType.Name = "lb_languageType";
            this.lb_languageType.Size = new System.Drawing.Size(98, 18);
            this.lb_languageType.TabIndex = 1;
            this.lb_languageType.Text = "语言类型：";
            // 
            // gb_dbTypes
            // 
            this.gb_dbTypes.Controls.Add(this.rb_postgresql);
            this.gb_dbTypes.Controls.Add(this.rb_sqlite);
            this.gb_dbTypes.Controls.Add(this.rb_sybase);
            this.gb_dbTypes.Controls.Add(this.rb_mssql);
            this.gb_dbTypes.Controls.Add(this.rb_oracle);
            this.gb_dbTypes.Controls.Add(this.rb_mysql);
            this.gb_dbTypes.Location = new System.Drawing.Point(134, 12);
            this.gb_dbTypes.Name = "gb_dbTypes";
            this.gb_dbTypes.Size = new System.Drawing.Size(881, 43);
            this.gb_dbTypes.TabIndex = 2;
            this.gb_dbTypes.TabStop = false;
            // 
            // rb_mysql
            // 
            this.rb_mysql.AutoSize = true;
            this.rb_mysql.Checked = true;
            this.rb_mysql.Location = new System.Drawing.Point(6, 13);
            this.rb_mysql.Name = "rb_mysql";
            this.rb_mysql.Size = new System.Drawing.Size(78, 22);
            this.rb_mysql.TabIndex = 0;
            this.rb_mysql.TabStop = true;
            this.rb_mysql.Text = "mysql";
            this.rb_mysql.UseVisualStyleBackColor = true;
            this.rb_mysql.CheckedChanged += new System.EventHandler(this.rb_dbType_CheckedChanged);
            // 
            // rb_oracle
            // 
            this.rb_oracle.AutoSize = true;
            this.rb_oracle.Location = new System.Drawing.Point(153, 13);
            this.rb_oracle.Name = "rb_oracle";
            this.rb_oracle.Size = new System.Drawing.Size(87, 22);
            this.rb_oracle.TabIndex = 1;
            this.rb_oracle.Text = "oracle";
            this.rb_oracle.UseVisualStyleBackColor = true;
            this.rb_oracle.CheckedChanged += new System.EventHandler(this.rb_dbType_CheckedChanged);
            // 
            // rb_mssql
            // 
            this.rb_mssql.AutoSize = true;
            this.rb_mssql.Location = new System.Drawing.Point(300, 13);
            this.rb_mssql.Name = "rb_mssql";
            this.rb_mssql.Size = new System.Drawing.Size(78, 22);
            this.rb_mssql.TabIndex = 2;
            this.rb_mssql.Text = "mssql";
            this.rb_mssql.UseVisualStyleBackColor = true;
            this.rb_mssql.CheckedChanged += new System.EventHandler(this.rb_dbType_CheckedChanged);
            // 
            // rb_sybase
            // 
            this.rb_sybase.AutoSize = true;
            this.rb_sybase.Location = new System.Drawing.Point(447, 13);
            this.rb_sybase.Name = "rb_sybase";
            this.rb_sybase.Size = new System.Drawing.Size(87, 22);
            this.rb_sybase.TabIndex = 3;
            this.rb_sybase.Text = "sybase";
            this.rb_sybase.UseVisualStyleBackColor = true;
            this.rb_sybase.CheckedChanged += new System.EventHandler(this.rb_dbType_CheckedChanged);
            // 
            // rb_sqlite
            // 
            this.rb_sqlite.AutoSize = true;
            this.rb_sqlite.Location = new System.Drawing.Point(594, 13);
            this.rb_sqlite.Name = "rb_sqlite";
            this.rb_sqlite.Size = new System.Drawing.Size(87, 22);
            this.rb_sqlite.TabIndex = 4;
            this.rb_sqlite.Text = "sqlite";
            this.rb_sqlite.UseVisualStyleBackColor = true;
            this.rb_sqlite.CheckedChanged += new System.EventHandler(this.rb_dbType_CheckedChanged);
            // 
            // rb_postgresql
            // 
            this.rb_postgresql.AutoSize = true;
            this.rb_postgresql.Location = new System.Drawing.Point(736, 13);
            this.rb_postgresql.Name = "rb_postgresql";
            this.rb_postgresql.Size = new System.Drawing.Size(123, 22);
            this.rb_postgresql.TabIndex = 5;
            this.rb_postgresql.Text = "postgresql";
            this.rb_postgresql.UseVisualStyleBackColor = true;
            this.rb_postgresql.CheckedChanged += new System.EventHandler(this.rb_dbType_CheckedChanged);
            // 
            // gb_lgTypes
            // 
            this.gb_lgTypes.Controls.Add(this.rb_dql);
            this.gb_lgTypes.Controls.Add(this.rb_dcl);
            this.gb_lgTypes.Controls.Add(this.rb_dml);
            this.gb_lgTypes.Controls.Add(this.rb_ddl);
            this.gb_lgTypes.Location = new System.Drawing.Point(134, 61);
            this.gb_lgTypes.Name = "gb_lgTypes";
            this.gb_lgTypes.Size = new System.Drawing.Size(576, 40);
            this.gb_lgTypes.TabIndex = 3;
            this.gb_lgTypes.TabStop = false;
            // 
            // rb_ddl
            // 
            this.rb_ddl.AutoSize = true;
            this.rb_ddl.Checked = true;
            this.rb_ddl.Location = new System.Drawing.Point(7, 11);
            this.rb_ddl.Name = "rb_ddl";
            this.rb_ddl.Size = new System.Drawing.Size(60, 22);
            this.rb_ddl.TabIndex = 0;
            this.rb_ddl.TabStop = true;
            this.rb_ddl.Text = "DDL";
            this.rb_ddl.UseVisualStyleBackColor = true;
            this.rb_ddl.CheckedChanged += new System.EventHandler(this.rb_lngType_CheckedChanged);
            // 
            // rb_dml
            // 
            this.rb_dml.AutoSize = true;
            this.rb_dml.Location = new System.Drawing.Point(153, 11);
            this.rb_dml.Name = "rb_dml";
            this.rb_dml.Size = new System.Drawing.Size(60, 22);
            this.rb_dml.TabIndex = 1;
            this.rb_dml.Text = "DML";
            this.rb_dml.UseVisualStyleBackColor = true;
            this.rb_dml.CheckedChanged += new System.EventHandler(this.rb_lngType_CheckedChanged);
            // 
            // rb_dcl
            // 
            this.rb_dcl.AutoSize = true;
            this.rb_dcl.Location = new System.Drawing.Point(300, 11);
            this.rb_dcl.Name = "rb_dcl";
            this.rb_dcl.Size = new System.Drawing.Size(60, 22);
            this.rb_dcl.TabIndex = 2;
            this.rb_dcl.Text = "DCL";
            this.rb_dcl.UseVisualStyleBackColor = true;
            this.rb_dcl.CheckedChanged += new System.EventHandler(this.rb_lngType_CheckedChanged);
            // 
            // rb_dql
            // 
            this.rb_dql.AutoSize = true;
            this.rb_dql.Location = new System.Drawing.Point(447, 11);
            this.rb_dql.Name = "rb_dql";
            this.rb_dql.Size = new System.Drawing.Size(60, 22);
            this.rb_dql.TabIndex = 3;
            this.rb_dql.Text = "DQL";
            this.rb_dql.UseVisualStyleBackColor = true;
            this.rb_dql.CheckedChanged += new System.EventHandler(this.rb_lngType_CheckedChanged);
            // 
            // lb_database
            // 
            this.lb_database.AutoSize = true;
            this.lb_database.Location = new System.Drawing.Point(15, 125);
            this.lb_database.Name = "lb_database";
            this.lb_database.Size = new System.Drawing.Size(89, 18);
            this.lb_database.TabIndex = 4;
            this.lb_database.Text = "database:";
            // 
            // tb_database
            // 
            this.tb_database.Location = new System.Drawing.Point(134, 125);
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(576, 28);
            this.tb_database.TabIndex = 5;
            // 
            // bt_init
            // 
            this.bt_init.Location = new System.Drawing.Point(434, 541);
            this.bt_init.Name = "bt_init";
            this.bt_init.Size = new System.Drawing.Size(117, 28);
            this.bt_init.TabIndex = 6;
            this.bt_init.Text = "初始化";
            this.bt_init.UseVisualStyleBackColor = true;
            this.bt_init.Click += new System.EventHandler(this.bt_init_Click);
            // 
            // lb_table
            // 
            this.lb_table.AutoSize = true;
            this.lb_table.Location = new System.Drawing.Point(15, 176);
            this.lb_table.Name = "lb_table";
            this.lb_table.Size = new System.Drawing.Size(62, 18);
            this.lb_table.TabIndex = 7;
            this.lb_table.Text = "table:";
            // 
            // tb_table
            // 
            this.tb_table.Location = new System.Drawing.Point(134, 173);
            this.tb_table.Name = "tb_table";
            this.tb_table.Size = new System.Drawing.Size(576, 28);
            this.tb_table.TabIndex = 8;
            // 
            // btn_addColumn
            // 
            this.btn_addColumn.Location = new System.Drawing.Point(728, 171);
            this.btn_addColumn.Name = "btn_addColumn";
            this.btn_addColumn.Size = new System.Drawing.Size(88, 28);
            this.btn_addColumn.TabIndex = 12;
            this.btn_addColumn.Text = "添加列";
            this.btn_addColumn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(18, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 282);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_delColumn
            // 
            this.btn_delColumn.Location = new System.Drawing.Point(870, 173);
            this.btn_delColumn.Name = "btn_delColumn";
            this.btn_delColumn.Size = new System.Drawing.Size(88, 28);
            this.btn_delColumn.TabIndex = 14;
            this.btn_delColumn.Text = "删除列";
            this.btn_delColumn.UseVisualStyleBackColor = true;
            // 
            // SqlCreaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 611);
            this.Controls.Add(this.btn_delColumn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_addColumn);
            this.Controls.Add(this.tb_table);
            this.Controls.Add(this.lb_table);
            this.Controls.Add(this.bt_init);
            this.Controls.Add(this.tb_database);
            this.Controls.Add(this.lb_database);
            this.Controls.Add(this.gb_lgTypes);
            this.Controls.Add(this.gb_dbTypes);
            this.Controls.Add(this.lb_languageType);
            this.Controls.Add(this.lb_dbType);
            this.Name = "SqlCreaterForm";
            this.Text = "Sql生成器";
            this.gb_dbTypes.ResumeLayout(false);
            this.gb_dbTypes.PerformLayout();
            this.gb_lgTypes.ResumeLayout(false);
            this.gb_lgTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_dbType;
        private System.Windows.Forms.Label lb_languageType;
        private System.Windows.Forms.GroupBox gb_dbTypes;
        private System.Windows.Forms.RadioButton rb_sqlite;
        private System.Windows.Forms.RadioButton rb_sybase;
        private System.Windows.Forms.RadioButton rb_mssql;
        private System.Windows.Forms.RadioButton rb_oracle;
        private System.Windows.Forms.RadioButton rb_mysql;
        private System.Windows.Forms.RadioButton rb_postgresql;
        private System.Windows.Forms.GroupBox gb_lgTypes;
        private System.Windows.Forms.RadioButton rb_dql;
        private System.Windows.Forms.RadioButton rb_dcl;
        private System.Windows.Forms.RadioButton rb_dml;
        private System.Windows.Forms.RadioButton rb_ddl;
        private System.Windows.Forms.Label lb_database;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.Button bt_init;
        private System.Windows.Forms.Label lb_table;
        private System.Windows.Forms.TextBox tb_table;
        private System.Windows.Forms.Button btn_addColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delColumn;
    }
}

