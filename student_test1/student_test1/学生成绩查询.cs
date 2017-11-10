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
    public partial class 学生成绩查询 : Form
    {
        public 学生成绩查询()
        {
            InitializeComponent();
        }

        private void 学生成绩查询_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet1.cjpm”中。您可以根据需要移动或删除它。
            this.cjpmTableAdapter.Fill(this.dataSet1.cjpm);

        }

        private void chaxun_Click(object sender, EventArgs e)
        {
            string str = "dsn=jhh;uid=sa;pwd=sa";

            string sqlstr = "select cjpm.学号,cjpm.姓名,cjpm.班级,cjpm.总分,cjpm.排名 from cjpm where  cjpm.学号='" + xuehao.Text.Trim() + "'";
            OdbcConnection conn = new OdbcConnection(str);
            conn.Open();
            OdbcDataAdapter da = new OdbcDataAdapter(sqlstr, conn);
            DataSet qa = new DataSet();
            da.Fill(qa, "学生成绩表");
            DataTable dt = qa.Tables["学生成绩表"];
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
