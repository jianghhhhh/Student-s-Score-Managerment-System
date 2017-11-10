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
using System.Data.Odbc;

namespace student_test1
{
    public partial class 学生信息维护 : Form
    {
        public 学生信息维护()
        {
            InitializeComponent();
        }

        private void 学生信息维护_Load(object sender, EventArgs e)
        {
// TODO: 这行代码将数据加载到表“dataSet1.Xsxx”中。您可以根据需要移动或删除它。
this.xsxxTableAdapter.Fill(this.dataSet1.Xsxx);

        }

        private void tianjia_Click(object sender, EventArgs e)
        {
            //定义一个初始值n=0, 用于判断后期是否成功插入数据
            int n = 0;
            int m = 0;
            string sqlsno = "select 学号 from Xsxx where (学号 like '" + xuehao.Text.Trim() + "')";
            string sql = "insert into Xsxx (学号,姓名,性别,班级,年龄) values ('" + xuehao.Text + "','" + xingming.Text + "','" + xingbie.Text + "','" + banji.Text + "','" + Convert.ToString(nianling.Text) + "')";
            //判断插入的数据是否为空,如果为空,则提示重新插入!
            if (xuehao.Text.Trim() == "" || xingming.Text.Trim() == "" || xingbie.Text.Trim() == "" || banji.Text.Trim() == "" || nianling.Text.Trim() == "")
            {
                MessageBox.Show("插入数据不能为空,请按要求插入数据!");
                return;
            }
            else if (int.TryParse(xuehao.Text, out m) == false || int.TryParse(banji.Text, out m) == false || int.TryParse(nianling.Text, out m) == false)
            {
                MessageBox.Show("请输入数字", "提示");
                return;
            }
            else if (Convert.ToInt32(this.nianling.Text.Trim()) < 0)
            {
                MessageBox.Show("年龄输入有错，请重新输入");
                return;
            }
            //向数据库插入参数
            /*OdbcParameter[] param ={
                                      new OdbcParameter("@学号",xuehao.Text),
                                      new OdbcParameter("@姓名",xingming.Text),
                                      new OdbcParameter("@性别",xingbie.Text),
                                      new OdbcParameter("@年龄",Convert.ToString(nianling.Text)),
                                      new OdbcParameter("@班级",banji.Text)

                                  };*/
            string str = Properties.Settings.Default.ConnectionString;
            OdbcConnection conn = new OdbcConnection(str);
            conn.Open();
            OdbcCommand cmdsno = new OdbcCommand(sqlsno, conn);
            OdbcDataReader sdr = cmdsno.ExecuteReader();
           /* if (sdr.Read())
            {
                MessageBox.Show("该学号已存在，请重新输入！");
                return;
            }
            else
            {*/
                
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                
                //cmd.Parameters.AddRange(param);
 
                 n = cmd.ExecuteNonQuery();
                if (n == 0)
                {
                    MessageBox.Show("添加失败!");
                    return;
                }
                else if (n > 0)
                {
                    MessageBox.Show("添加成功!");
                }
                conn.Close();
                //调用refresh方法,在添加完成数据后 自动刷新 显示新数据
                Refresh();
                this.xsxxTableAdapter.Fill(this.dataSet1.Xsxx);
        //   }
           conn.Close();
      }

        private void shanchu_Click(object sender, EventArgs e)
        {
        if (MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                //使用sql删除语句
                string sqlxsxx = "delete from Xsxx where 1=1";
                string sqlxscj = "delete from xscj where 1=1";
                string sqlcjpm = "delete from cjpm where 1=1";
                sqlxscj = sqlxscj + "and 学号=" + xuehao.Text;
                sqlxsxx = sqlxsxx + "and 学号=" + xuehao.Text;
                sqlcjpm = sqlcjpm + "and 学号=" + xuehao.Text;
                //}
                int n = 0;
             string str = Properties.Settings.Default.ConnectionString;
             OdbcConnection Conn = new OdbcConnection(str);
            Conn.Open();

            OdbcCommand cmdxsxx = new OdbcCommand(sqlxsxx, Conn);
                n = cmdxsxx.ExecuteNonQuery();
                OdbcCommand cmdxxxx = new OdbcCommand(sqlxscj, Conn);
                cmdxxxx.ExecuteNonQuery();
                OdbcCommand cmdcjpm = new OdbcCommand(sqlcjpm, Conn);
                cmdcjpm.ExecuteNonQuery();
                if (n == 0)
                {
                    MessageBox.Show("不存在学号!");
                    return;

                }
                else if (n > 0)
                {
                    MessageBox.Show("删除成功!");
                }
                Conn.Close();
                //删除完后 刷新一下当前数据
                Refresh();
                this.xsxxTableAdapter.Fill(this.dataSet1.Xsxx);
            }
        }

        private void xiugai_Click(object sender, EventArgs e)
        {
            int m = 0;
            //在对数据进行修改之前 对文本框的内容做一下检查, 如果为空 则提示重新输入
            if (xuehao.Text.Trim() == "" || nianling.Text.Trim() == "" || xingbie.Text.Trim() == "" || xingming.Text.Trim() == "" || banji.Text.Trim() == "")
            {
                MessageBox.Show("文本框的输入不能为空!");
                return;
            }
            else if (int.TryParse(xuehao.Text, out m) == false || int.TryParse(nianling.Text, out m) == false || int.TryParse(banji.Text, out m) == false)
            {
                MessageBox.Show("请输入数字", "提示");
                return;
            }
            else if (Convert.ToInt32(this.nianling.Text.Trim()) < 0)
            {
                MessageBox.Show("年龄输入有错，请重新输入");
                return;
            }
            //使用SQL update 更新语句
            //获取文本框中输入的内容, 通过SNO进行更新(SNO为当前鼠标点击行的Id)
            string sqlUpdate = "update Xsxx set 学号 ='" + xuehao.Text + "',年龄 ='"
             + nianling.Text + "',性别='" + xingbie.Text + "',姓名='" + xingming.Text + "',班级='" + banji.Text + "'where 学号='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
             string str = Properties.Settings.Default.ConnectionString;
             OdbcConnection Conn = new OdbcConnection(str);
            Conn.Open();
            OdbcCommand cmdUpdate = new OdbcCommand(sqlUpdate, Conn);
            int n = 0;
            try
            {
                n = cmdUpdate.ExecuteNonQuery();
            }
            catch
            {
                
                    //提示更新失败
                    MessageBox.Show("更新失败!");
                    return;// 并且返回
            }
            if (n > 0)
                {
                    //否则更新成功
                    MessageBox.Show("修改成功!");
                }
            //执行完数据更新操作后 需要关闭数据库 节省资源
            Conn.Close();
            //更新完以后  调用刷新方法,将更新后的数据 显示在datagridview上面

            Refresh();
            this.xsxxTableAdapter.Fill(this.dataSet1.Xsxx);
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         if (this.dataGridView1.SelectedRows.Count < 1)
            {
                return;
            }
            this.xuehao.Text = this.dataGridView1.CurrentRow.Cells["学号"].Value.ToString();
            this.xingming.Text = this.dataGridView1.CurrentRow.Cells["姓名"].Value.ToString();
            this.xingbie.Text = this.dataGridView1.CurrentRow.Cells["性别"].Value.ToString();
            this.nianling.Text = this.dataGridView1.CurrentRow.Cells["年龄"].Value.ToString();
            this.banji.Text = this.dataGridView1.CurrentRow.Cells["班级"].Value.ToString();
        }

        private void xuehao_TextChanged(object sender, EventArgs e)
        {

        }
        

        }
    }

