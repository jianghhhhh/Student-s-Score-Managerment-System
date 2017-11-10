using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_test1
{
    public partial class 开课情况查询 : Form
    {
        public 开课情况查询()
        {
            InitializeComponent();
        }

        private void 开课情况查询_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet1.kc”中。您可以根据需要移动或删除它。
            this.kcTableAdapter.Fill(this.dataSet1.kc);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
