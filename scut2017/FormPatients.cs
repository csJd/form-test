using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scut2017
{
    public partial class FormPatients : Form
    {
        public FormPatients()
        {
            InitializeComponent();
        }

        private void reload()
        {
            string sql = "SELECT pid 身份证号, pname 姓名, pdate 日期, gno 小科室编号 FROM patients";
            DBUtil.fillListView(lvShow, sql);
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            string sql = "SELECT dname 大科室, gname 小科室, pname 姓名" +
                " FROM patients p, departments d, groups g" +
                " WHERE p.gno = g.gno AND d.dno = g.dno";
            if (checkBox1.Checked)
            {
                sql += " AND d.dname = '" + cbDname.Text + "'";
            }

            if (checkBox2.Checked)
            {
                sql += " AND g.gname = '" + cbGname.Text + "'";
            }

            sql += string.Format(" AND p.pname LIKE '%{0}%' ORDER BY dname DESC, gname, pname", tbPname.Text.Trim());

            DBUtil.fillListView(lvShow, sql);
        }
    }
}
