namespace student_test1
{
    partial class 学生信息维护
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年龄DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xsxxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new student_test1.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xuehao = new System.Windows.Forms.TextBox();
            this.xingming = new System.Windows.Forms.TextBox();
            this.xingbie = new System.Windows.Forms.TextBox();
            this.banji = new System.Windows.Forms.TextBox();
            this.nianling = new System.Windows.Forms.TextBox();
            this.tianjia = new System.Windows.Forms.Button();
            this.xiugai = new System.Windows.Forms.Button();
            this.shanchu = new System.Windows.Forms.Button();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xsxxTableAdapter = new student_test1.DataSet1TableAdapters.XsxxTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xsxxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.班级DataGridViewTextBoxColumn,
            this.年龄DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.xsxxBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(569, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 学号DataGridViewTextBoxColumn
            // 
            this.学号DataGridViewTextBoxColumn.DataPropertyName = "学号";
            this.学号DataGridViewTextBoxColumn.HeaderText = "学号";
            this.学号DataGridViewTextBoxColumn.Name = "学号DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            // 
            // 班级DataGridViewTextBoxColumn
            // 
            this.班级DataGridViewTextBoxColumn.DataPropertyName = "班级";
            this.班级DataGridViewTextBoxColumn.HeaderText = "班级";
            this.班级DataGridViewTextBoxColumn.Name = "班级DataGridViewTextBoxColumn";
            // 
            // 年龄DataGridViewTextBoxColumn
            // 
            this.年龄DataGridViewTextBoxColumn.DataPropertyName = "年龄";
            this.年龄DataGridViewTextBoxColumn.HeaderText = "年龄";
            this.年龄DataGridViewTextBoxColumn.Name = "年龄DataGridViewTextBoxColumn";
            // 
            // xsxxBindingSource
            // 
            this.xsxxBindingSource.DataMember = "Xsxx";
            this.xsxxBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "班级：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "年龄：";
            // 
            // xuehao
            // 
            this.xuehao.Location = new System.Drawing.Point(206, 48);
            this.xuehao.Name = "xuehao";
            this.xuehao.Size = new System.Drawing.Size(100, 25);
            this.xuehao.TabIndex = 6;
            this.xuehao.TextChanged += new System.EventHandler(this.xuehao_TextChanged);
            // 
            // xingming
            // 
            this.xingming.Location = new System.Drawing.Point(206, 85);
            this.xingming.Name = "xingming";
            this.xingming.Size = new System.Drawing.Size(100, 25);
            this.xingming.TabIndex = 7;
            // 
            // xingbie
            // 
            this.xingbie.Location = new System.Drawing.Point(206, 124);
            this.xingbie.Name = "xingbie";
            this.xingbie.Size = new System.Drawing.Size(100, 25);
            this.xingbie.TabIndex = 8;
            // 
            // banji
            // 
            this.banji.Location = new System.Drawing.Point(477, 51);
            this.banji.Name = "banji";
            this.banji.Size = new System.Drawing.Size(100, 25);
            this.banji.TabIndex = 9;
            // 
            // nianling
            // 
            this.nianling.Location = new System.Drawing.Point(477, 85);
            this.nianling.Name = "nianling";
            this.nianling.Size = new System.Drawing.Size(100, 25);
            this.nianling.TabIndex = 10;
            // 
            // tianjia
            // 
            this.tianjia.Location = new System.Drawing.Point(653, 53);
            this.tianjia.Name = "tianjia";
            this.tianjia.Size = new System.Drawing.Size(75, 23);
            this.tianjia.TabIndex = 11;
            this.tianjia.Text = "添加";
            this.tianjia.UseVisualStyleBackColor = true;
            this.tianjia.Click += new System.EventHandler(this.tianjia_Click);
            // 
            // xiugai
            // 
            this.xiugai.Location = new System.Drawing.Point(653, 105);
            this.xiugai.Name = "xiugai";
            this.xiugai.Size = new System.Drawing.Size(75, 23);
            this.xiugai.TabIndex = 12;
            this.xiugai.Text = "修改";
            this.xiugai.UseVisualStyleBackColor = true;
            this.xiugai.Click += new System.EventHandler(this.xiugai_Click);
            // 
            // shanchu
            // 
            this.shanchu.Location = new System.Drawing.Point(653, 157);
            this.shanchu.Name = "shanchu";
            this.shanchu.Size = new System.Drawing.Size(75, 23);
            this.shanchu.TabIndex = 13;
            this.shanchu.Text = "删除";
            this.shanchu.UseVisualStyleBackColor = true;
            this.shanchu.Click += new System.EventHandler(this.shanchu_Click);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // xsxxTableAdapter
            // 
            this.xsxxTableAdapter.ClearBeforeFill = true;
            // 
            // 学生信息维护
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 435);
            this.Controls.Add(this.shanchu);
            this.Controls.Add(this.xiugai);
            this.Controls.Add(this.tianjia);
            this.Controls.Add(this.nianling);
            this.Controls.Add(this.banji);
            this.Controls.Add(this.xingbie);
            this.Controls.Add(this.xingming);
            this.Controls.Add(this.xuehao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "学生信息维护";
            this.Text = "学生信息维护";
            this.Load += new System.EventHandler(this.学生信息维护_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xsxxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xuehao;
        private System.Windows.Forms.TextBox xingming;
        private System.Windows.Forms.TextBox xingbie;
        private System.Windows.Forms.TextBox banji;
        private System.Windows.Forms.TextBox nianling;
        private System.Windows.Forms.Button tianjia;
        private System.Windows.Forms.Button xiugai;
        private System.Windows.Forms.Button shanchu;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource xsxxBindingSource;
        private DataSet1TableAdapters.XsxxTableAdapter xsxxTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年龄DataGridViewTextBoxColumn;
    }
}