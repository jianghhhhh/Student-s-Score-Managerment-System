namespace student_test1
{
    partial class 学生成绩维护
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xuehao = new System.Windows.Forms.TextBox();
            this.kechenghao = new System.Windows.Forms.TextBox();
            this.chengji = new System.Windows.Forms.TextBox();
            this.cjwhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.学生成绩管理DataSet2 = new student_test1.学生成绩管理DataSet2();
            this.xscjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.学生成绩管理DataSet = new student_test1.学生成绩管理DataSet();
            this.xxxxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new student_test1.DataSet1();
            this.xxxxTableAdapter = new student_test1.DataSet1TableAdapters.xxxxTableAdapter();
            this.tianjia = new System.Windows.Forms.Button();
            this.xiugai = new System.Windows.Forms.Button();
            this.shanchu = new System.Windows.Forms.Button();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xscjTableAdapter = new student_test1.学生成绩管理DataSetTableAdapters.xscjTableAdapter();
            this.xscjBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.xscjBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cjpmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cjpmTableAdapter = new student_test1.学生成绩管理DataSet2TableAdapters.cjpmTableAdapter();
            this.cjwhTableAdapter = new student_test1.学生成绩管理DataSet2TableAdapters.cjwhTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成绩DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cjwhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生成绩管理DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xscjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生成绩管理DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xxxxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xscjBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xscjBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjpmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "课程号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "成绩：";
            // 
            // xuehao
            // 
            this.xuehao.Location = new System.Drawing.Point(194, 91);
            this.xuehao.Name = "xuehao";
            this.xuehao.Size = new System.Drawing.Size(100, 25);
            this.xuehao.TabIndex = 3;
            // 
            // kechenghao
            // 
            this.kechenghao.Location = new System.Drawing.Point(194, 141);
            this.kechenghao.Name = "kechenghao";
            this.kechenghao.Size = new System.Drawing.Size(100, 25);
            this.kechenghao.TabIndex = 4;
            // 
            // chengji
            // 
            this.chengji.Location = new System.Drawing.Point(194, 195);
            this.chengji.Name = "chengji";
            this.chengji.Size = new System.Drawing.Size(100, 25);
            this.chengji.TabIndex = 5;
            // 
            // cjwhBindingSource
            // 
            this.cjwhBindingSource.DataMember = "cjwh";
            this.cjwhBindingSource.DataSource = this.学生成绩管理DataSet2;
            // 
            // 学生成绩管理DataSet2
            // 
            this.学生成绩管理DataSet2.DataSetName = "学生成绩管理DataSet2";
            this.学生成绩管理DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xscjBindingSource
            // 
            this.xscjBindingSource.DataMember = "xscj";
            this.xscjBindingSource.DataSource = this.学生成绩管理DataSet;
            // 
            // 学生成绩管理DataSet
            // 
            this.学生成绩管理DataSet.DataSetName = "学生成绩管理DataSet";
            this.学生成绩管理DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xxxxBindingSource
            // 
            this.xxxxBindingSource.DataMember = "xxxx";
            this.xxxxBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xxxxTableAdapter
            // 
            this.xxxxTableAdapter.ClearBeforeFill = true;
            // 
            // tianjia
            // 
            this.tianjia.Location = new System.Drawing.Point(87, 297);
            this.tianjia.Name = "tianjia";
            this.tianjia.Size = new System.Drawing.Size(75, 23);
            this.tianjia.TabIndex = 7;
            this.tianjia.Text = "添加";
            this.tianjia.UseVisualStyleBackColor = true;
            this.tianjia.Click += new System.EventHandler(this.tianjia_Click);
            // 
            // xiugai
            // 
            this.xiugai.Location = new System.Drawing.Point(219, 297);
            this.xiugai.Name = "xiugai";
            this.xiugai.Size = new System.Drawing.Size(75, 23);
            this.xiugai.TabIndex = 8;
            this.xiugai.Text = "修改";
            this.xiugai.UseVisualStyleBackColor = true;
            this.xiugai.Click += new System.EventHandler(this.xiugai_Click);
            // 
            // shanchu
            // 
            this.shanchu.Location = new System.Drawing.Point(352, 297);
            this.shanchu.Name = "shanchu";
            this.shanchu.Size = new System.Drawing.Size(75, 23);
            this.shanchu.TabIndex = 9;
            this.shanchu.Text = "删除";
            this.shanchu.UseVisualStyleBackColor = true;
            this.shanchu.Click += new System.EventHandler(this.shanchu_Click);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // xscjTableAdapter
            // 
            this.xscjTableAdapter.ClearBeforeFill = true;
            // 
            // xscjBindingSource1
            // 
            this.xscjBindingSource1.DataMember = "xscj";
            this.xscjBindingSource1.DataSource = this.学生成绩管理DataSet;
            // 
            // xscjBindingSource2
            // 
            this.xscjBindingSource2.DataMember = "xscj";
            this.xscjBindingSource2.DataSource = this.学生成绩管理DataSet;
            // 
            // cjpmBindingSource
            // 
            this.cjpmBindingSource.DataMember = "cjpm";
            this.cjpmBindingSource.DataSource = this.学生成绩管理DataSet2;
            // 
            // cjpmTableAdapter
            // 
            this.cjpmTableAdapter.ClearBeforeFill = true;
            // 
            // cjwhTableAdapter
            // 
            this.cjwhTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号DataGridViewTextBoxColumn,
            this.课程号DataGridViewTextBoxColumn,
            this.成绩DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cjwhBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(507, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(344, 354);
            this.dataGridView1.TabIndex = 10;
            // 
            // 学号DataGridViewTextBoxColumn
            // 
            this.学号DataGridViewTextBoxColumn.DataPropertyName = "学号";
            this.学号DataGridViewTextBoxColumn.HeaderText = "学号";
            this.学号DataGridViewTextBoxColumn.Name = "学号DataGridViewTextBoxColumn";
            // 
            // 课程号DataGridViewTextBoxColumn
            // 
            this.课程号DataGridViewTextBoxColumn.DataPropertyName = "课程号";
            this.课程号DataGridViewTextBoxColumn.HeaderText = "课程号";
            this.课程号DataGridViewTextBoxColumn.Name = "课程号DataGridViewTextBoxColumn";
            // 
            // 成绩DataGridViewTextBoxColumn
            // 
            this.成绩DataGridViewTextBoxColumn.DataPropertyName = "成绩";
            this.成绩DataGridViewTextBoxColumn.HeaderText = "成绩";
            this.成绩DataGridViewTextBoxColumn.Name = "成绩DataGridViewTextBoxColumn";
            // 
            // 学生成绩维护
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shanchu);
            this.Controls.Add(this.xiugai);
            this.Controls.Add(this.tianjia);
            this.Controls.Add(this.chengji);
            this.Controls.Add(this.kechenghao);
            this.Controls.Add(this.xuehao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "学生成绩维护";
            this.Text = "学生成绩维护";
            this.Load += new System.EventHandler(this.学生成绩维护_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cjwhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生成绩管理DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xscjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生成绩管理DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xxxxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xscjBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xscjBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjpmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xuehao;
        private System.Windows.Forms.TextBox kechenghao;
        private System.Windows.Forms.TextBox chengji;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource xxxxBindingSource;
        private DataSet1TableAdapters.xxxxTableAdapter xxxxTableAdapter;
        private System.Windows.Forms.Button tianjia;
        private System.Windows.Forms.Button xiugai;
        private System.Windows.Forms.Button shanchu;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private 学生成绩管理DataSet 学生成绩管理DataSet;
        private System.Windows.Forms.BindingSource xscjBindingSource;
        private 学生成绩管理DataSetTableAdapters.xscjTableAdapter xscjTableAdapter;
        private System.Windows.Forms.BindingSource xscjBindingSource1;
        private System.Windows.Forms.BindingSource xscjBindingSource2;
        private 学生成绩管理DataSet2 学生成绩管理DataSet2;
        private System.Windows.Forms.BindingSource cjpmBindingSource;
        private 学生成绩管理DataSet2TableAdapters.cjpmTableAdapter cjpmTableAdapter;
        private System.Windows.Forms.BindingSource cjwhBindingSource;
        private 学生成绩管理DataSet2TableAdapters.cjwhTableAdapter cjwhTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成绩DataGridViewTextBoxColumn;
    }
}