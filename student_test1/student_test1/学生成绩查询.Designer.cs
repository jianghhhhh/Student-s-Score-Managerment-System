namespace student_test1
{
    partial class 学生成绩查询
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
            this.xuehao = new System.Windows.Forms.TextBox();
            this.学号 = new System.Windows.Forms.Label();
            this.chaxun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new student_test1.DataSet1();
            this.cjpmTableAdapter = new student_test1.DataSet1TableAdapters.cjpmTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cjpmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjpmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xuehao
            // 
            this.xuehao.Location = new System.Drawing.Point(190, 66);
            this.xuehao.Name = "xuehao";
            this.xuehao.Size = new System.Drawing.Size(158, 25);
            this.xuehao.TabIndex = 0;
            // 
            // 学号
            // 
            this.学号.AutoSize = true;
            this.学号.Location = new System.Drawing.Point(132, 72);
            this.学号.Name = "学号";
            this.学号.Size = new System.Drawing.Size(52, 15);
            this.学号.TabIndex = 1;
            this.学号.Text = "学号：";
            // 
            // chaxun
            // 
            this.chaxun.Location = new System.Drawing.Point(480, 68);
            this.chaxun.Name = "chaxun";
            this.chaxun.Size = new System.Drawing.Size(75, 23);
            this.chaxun.TabIndex = 2;
            this.chaxun.Text = "查询";
            this.chaxun.UseVisualStyleBackColor = true;
            this.chaxun.Click += new System.EventHandler(this.chaxun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(545, 79);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cjpmTableAdapter
            // 
            this.cjpmTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cjpmBindingSource
            // 
            this.cjpmBindingSource.DataMember = "cjpm";
            this.cjpmBindingSource.DataSource = this.dataSet1;
            // 
            // 学生成绩查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 334);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chaxun);
            this.Controls.Add(this.学号);
            this.Controls.Add(this.xuehao);
            this.Name = "学生成绩查询";
            this.Text = "学生成绩查询";
            this.Load += new System.EventHandler(this.学生成绩查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjpmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xuehao;
        private System.Windows.Forms.Label 学号;
        private System.Windows.Forms.Button chaxun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cjpmBindingSource;
        private DataSet1TableAdapters.cjpmTableAdapter cjpmTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}