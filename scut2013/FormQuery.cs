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
    public partial class FormQuery : Form
    {
        public FormQuery()
        {
            InitializeComponent();
            string sql = "SELECT tno FROM teachers";
            DBUtil.fillComboBox(cbTno, sql);
            sql = "SELECT tname FROM teachers";
            DBUtil.fillComboBox(cbTname, sql);
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            string sql = "SELECT tno AS 教师号, tname AS 教师姓名, tsex AS 教师性别 FROM teachers";
            if (rbTno.Checked)
            {
                sql += string.Format(" WHERE tno = '{0}'", cbTno.Text);
            }
            else
            {
                sql += string.Format(" WHERE tname = '{0}'", cbTname.Text);
            }
            DBUtil.fillListView(lvShow, sql);
        }
    }
}
