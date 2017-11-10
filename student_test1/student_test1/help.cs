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
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet1.cjpm”中。您可以根据需要移动或删除它。
            this.cjpmTableAdapter.Fill(this.dataSet1.cjpm);

        }
    }
}
