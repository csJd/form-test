using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scut2013
{
    public partial class FormStat : Form
    {
        public FormStat()
        {
            InitializeComponent();
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            string sql = "SELECT tname AS 教师姓名, cname 课程名 FROM teachers t, courses c, works w" +
                         " WHERE w.tno = t.tno AND w.cno = c.cno" +
                         " AND 1 < (SELECT COUNT(*) FROM works w1 WHERE w1.tno = t.tno)";
            DBUtil.fillListView(listView1, sql);
        }
    }
}
