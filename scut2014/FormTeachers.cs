using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scut2014
{
    public partial class FormTeachers : Form
    {
        private string preTno;
        public FormTeachers()
        {
            InitializeComponent();
            string sql = "SELECT DISTINCT tdept FROM teachers";
            DBUtil.fillCombobox(cbTdept, sql);
            sql = "SELECT DISTINCT rno FROM remunerations";
            DBUtil.fillCombobox(cbRno, sql);
            reload();
        }

        public void reload()
        {
            string sql = "SELECT tno 教师号, tname 教师姓名, tdept 系别, rno 职称号 FROM teachers";
            DBUtil.fillListView(lvShow, sql);
        }

        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvShow.SelectedItems.Count == 0) return;
            var row = lvShow.SelectedItems[0].SubItems;
            preTno = tbTno.Text = row[0].Text;
            tbTname.Text = row[1].Text;
            cbTdept.Text = row[2].Text;
            cbRno.Text = row[3].Text;
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            string sql = "SELECT tno 教师号, tname 教师姓名, tdept 系别, rno 职称号 FROM teachers " +
                string.Format("WHERE tdept = '{0}' AND tname LIKE '%{1}%'", cbTdept.Text, tbTname.Text.Trim());
            DBUtil.fillListView(lvShow, sql);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string tno = tbTno.Text;
            string sql = "SELECT tno FROM teachers WHERE tno = '" + tno + "'";
            if (DBUtil.exists(sql))
            {
                MessageBox.Show("用户名已经存在!");
                return;
            }

            string tname = tbTname.Text;
            string tdept = cbTdept.Text;
            string rno = cbRno.Text;
            sql = string.Format("INSERT INTO teachers VALUES ('{0}', '{1}', '{2}', '{3}')",
                tno, tname, tdept, rno);

            if (DBUtil.update(sql))
            {
                MessageBox.Show("添加成功！");
                reload();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void btUpt_Click(object sender, EventArgs e)
        {
            string tno = tbTno.Text;
            string tname = tbTname.Text;
            string tdept = cbTdept.Text;
            string rno = cbRno.Text;

            string sql = string.Format("UPDATE teachers SET tno = '{0}', tname = '{1}', tdept = '{2}', rno = '{3}' WHERE tno = '{4}'",
                tno, tname, tdept, rno, preTno);

            if (DBUtil.update(sql))
            {
                MessageBox.Show("更新成功！");
                reload();
            }
            else
            {
                MessageBox.Show("更新失败！");
            }

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.YesNo);
            if(r == DialogResult.No)
            {
                return;
            }
            string sql = "DELETE FROM teachers WHERE tno = '" + preTno + "'";
            if (DBUtil.update(sql))
            {
                MessageBox.Show("删除成功！");
                reload();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }
    }
}
