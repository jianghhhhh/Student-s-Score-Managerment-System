namespace student_test1
{
    partial class login
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.identity = new System.Windows.Forms.ComboBox();
            this.label_key = new System.Windows.Forms.Label();
            this.ensure = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户身份：";
            // 
            // identity
            // 
            this.identity.FormattingEnabled = true;
            this.identity.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.identity.Location = new System.Drawing.Point(346, 91);
            this.identity.Name = "identity";
            this.identity.Size = new System.Drawing.Size(248, 23);
            this.identity.TabIndex = 1;
            this.identity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Location = new System.Drawing.Point(160, 269);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(52, 15);
            this.label_key.TabIndex = 2;
            this.label_key.Text = "密码：";
            // 
            // ensure
            // 
            this.ensure.Location = new System.Drawing.Point(138, 333);
            this.ensure.Name = "ensure";
            this.ensure.Size = new System.Drawing.Size(114, 33);
            this.ensure.TabIndex = 4;
            this.ensure.Text = "确定";
            this.ensure.UseVisualStyleBackColor = true;
            this.ensure.Click += new System.EventHandler(this.ensure_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(434, 333);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(114, 35);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "用户名:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(346, 180);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(248, 25);
            this.txtname.TabIndex = 7;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(346, 269);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(248, 25);
            this.txtpassword.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.label_key);
            this.groupBox1.Controls.Add(this.ensure);
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.identity);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 506);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 501);
            this.Controls.Add(this.groupBox1);
            this.Name = "login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Button ensure;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpassword;
        public System.Windows.Forms.ComboBox identity;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

