namespace student_test1
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.开课情况查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学习成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加成绩记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改成绩记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 498);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(807, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 20);
            this.toolStripStatusLabel.Text = "状态";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开课情况查询ToolStripMenuItem,
            this.学习成绩查询ToolStripMenuItem,
            this.学生信息维护ToolStripMenuItem,
            this.学生成绩维护ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(807, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // 开课情况查询ToolStripMenuItem
            // 
            this.开课情况查询ToolStripMenuItem.Name = "开课情况查询ToolStripMenuItem";
            this.开课情况查询ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.开课情况查询ToolStripMenuItem.Text = "开课情况查询";
            this.开课情况查询ToolStripMenuItem.Click += new System.EventHandler(this.开课情况查询ToolStripMenuItem_Click);
            // 
            // 学习成绩查询ToolStripMenuItem
            // 
            this.学习成绩查询ToolStripMenuItem.Name = "学习成绩查询ToolStripMenuItem";
            this.学习成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.学习成绩查询ToolStripMenuItem.Text = "学生成绩查询";
            this.学习成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.学习成绩查询ToolStripMenuItem_Click);
            // 
            // 学生信息维护ToolStripMenuItem
            // 
            this.学生信息维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学生信息ToolStripMenuItem,
            this.修改学生信息ToolStripMenuItem,
            this.删除学生信息ToolStripMenuItem});
            this.学生信息维护ToolStripMenuItem.Name = "学生信息维护ToolStripMenuItem";
            this.学生信息维护ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.学生信息维护ToolStripMenuItem.Text = "学生信息维护";
            this.学生信息维护ToolStripMenuItem.Click += new System.EventHandler(this.学生信息维护ToolStripMenuItem_Click);
            // 
            // 添加学生信息ToolStripMenuItem
            // 
            this.添加学生信息ToolStripMenuItem.Name = "添加学生信息ToolStripMenuItem";
            this.添加学生信息ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.添加学生信息ToolStripMenuItem.Text = "添加学生信息";
            // 
            // 修改学生信息ToolStripMenuItem
            // 
            this.修改学生信息ToolStripMenuItem.Name = "修改学生信息ToolStripMenuItem";
            this.修改学生信息ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.修改学生信息ToolStripMenuItem.Text = "修改学生信息";
            // 
            // 删除学生信息ToolStripMenuItem
            // 
            this.删除学生信息ToolStripMenuItem.Name = "删除学生信息ToolStripMenuItem";
            this.删除学生信息ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.删除学生信息ToolStripMenuItem.Text = "删除学生信息";
            // 
            // 学生成绩维护ToolStripMenuItem
            // 
            this.学生成绩维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加成绩记录ToolStripMenuItem,
            this.修改成绩记录ToolStripMenuItem,
            this.删除学生记录ToolStripMenuItem});
            this.学生成绩维护ToolStripMenuItem.Name = "学生成绩维护ToolStripMenuItem";
            this.学生成绩维护ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.学生成绩维护ToolStripMenuItem.Text = "学生成绩维护";
            this.学生成绩维护ToolStripMenuItem.Click += new System.EventHandler(this.学生成绩维护ToolStripMenuItem_Click);
            // 
            // 添加成绩记录ToolStripMenuItem
            // 
            this.添加成绩记录ToolStripMenuItem.Name = "添加成绩记录ToolStripMenuItem";
            this.添加成绩记录ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.添加成绩记录ToolStripMenuItem.Text = "添加成绩记录";
            // 
            // 修改成绩记录ToolStripMenuItem
            // 
            this.修改成绩记录ToolStripMenuItem.Name = "修改成绩记录ToolStripMenuItem";
            this.修改成绩记录ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.修改成绩记录ToolStripMenuItem.Text = "修改成绩记录";
            // 
            // 删除学生记录ToolStripMenuItem
            // 
            this.删除学生记录ToolStripMenuItem.Name = "删除学生记录ToolStripMenuItem";
            this.删除学生记录ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.删除学生记录ToolStripMenuItem.Text = "删除学生记录";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 464);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 开课情况查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学习成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生成绩维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加成绩记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改成绩记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}



