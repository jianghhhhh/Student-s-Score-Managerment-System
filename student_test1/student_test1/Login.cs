using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace student_test1
{
    public partial class login : Form
    {
        static public string sn, sub;
        public login()
        {
            InitializeComponent();
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void ensure_Click(object sender, EventArgs e)
        {
            string userName = txtname.Text;
            string password = txtpassword.Text;
            string s = identity.Text;

            if (s == "管理员" && userName == "jhh" && password == "123" )
            {
                MessageBox.Show("欢迎进入系统！", "登陆成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MDIParent1 jhh = new MDIParent1();
                jhh.Show();
            }

            else
            {
                if ( s == "普通用户" && userName == "hhj" && password == "456")
                {
                    MessageBox.Show("欢迎进入系统！", "登陆成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MDIParent2 hhj = new MDIParent2();
                    hhj.Show();
                }
                else
                {
                    MessageBox.Show("您输入的用户名或密码错误！", "登录失败！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
