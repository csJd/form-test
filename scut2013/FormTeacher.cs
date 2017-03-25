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
    public partial class FormTeacher : Form
    {
        private string preTno;

        public FormTeacher()
        {
            InitializeComponent();
            reload();
        }

        public void reload()
        {
            string sql = "SELECT tno AS 教师号, tname AS 教师姓名, tsex AS 教师性别 FROM teachers";
            DBUtil.fillListView(lvShow, sql);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string tno = tbTno.Text.Trim();
            string tname = tbTname.Text.Trim();
            string tsex = radioButton1.Checked ? "男" : "女";

            if (tno.Equals(""))
            {
                MessageBox.Show("教师号不能为空!");
                return;
            }

            string sql = string.Format("INSERT INTO teachers VALUES ('{0}', '{1}', '{2}')", tno, tname, tsex);
            if (DBUtil.update(sql))
            {
                MessageBox.Show("添加成功");
                reload();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void btUpt_Click(object sender, EventArgs e)
        {
            string tno = tbTno.Text.Trim();
            string tname = tbTname.Text.Trim();
            string tsex = radioButton1.Checked ? "男" : "女";

            string sql = string.Format("UPDATE teachers SET tno = '{0}', tname = '{1}', tsex = '{2}'" +
                " WHERE tno = '{3}' ", tno, tname, tsex, preTno);
            if (DBUtil.update(sql))
            {
                MessageBox.Show("更新成功");
                reload();
            }
            else
            {
                MessageBox.Show("更新失败，请检查数据是否有误！");
            }
        }

        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvShow.SelectedItems.Count > 0)
            {
                var r = lvShow.SelectedItems[0].SubItems;
                tbTno.Text = preTno = r[0].Text;
                tbTname.Text = r[1].Text;
                if (r[2].Text.Equals("男"))
                {
                    radioButton1.Checked = true;
                }
                else radioButton2.Checked = true;
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM teachers WHERE tno = '" + preTno + "'";
            if (DBUtil.update(sql))
            {
                MessageBox.Show("删除成功");
                reload();
            }
        }
    }
}
