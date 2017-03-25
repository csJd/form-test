using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace scut2016
{
    class DBUtil
    {
        private static readonly string connString = "Server=.\\sqlexpress; Database=r2016; Uid=sa; Pwd=9508";
        private static SqlConnection conn;

        public static void openConn()
        {
           conn = new SqlConnection(connString);
           conn.Open();
        }

        public static void closeConn()
        {
            if(conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public static DataTable selectToDt(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(dt);
            return dt;
        }

        public static bool update(string sql)
        {
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            return sqlcmd.ExecuteNonQuery() > 0;
        }

        public static bool exists(string sql)
        {
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            return sqlcmd.ExecuteScalar() != null;
        }

        /// <summary>
        /// 用查询结果填充ListView
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="sql"></param>
        public static void fillListView(ListView lv, string sql)
        {
            DataTable dt = selectToDt(sql);
            lv.View = View.Details;
            lv.GridLines = true;  //显示表格线
            lv.FullRowSelect = true; //允许整行选择

            lv.Clear();
            lv.BeginUpdate();
            int columnCnt = dt.Columns.Count;
            int columnWidth = lv.Width / columnCnt - 2;
            foreach (DataColumn dc in dt.Columns)
            {
                lv.Columns.Add(dc.Caption, columnWidth);
            }

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr[0].ToString();
                for (int i = 1; i < dt.Columns.Count; ++i)
                {
                    //if (dr[i].GetType() == typeof(DateTime))
                    if(dr[i] is DateTime)
                    {
                        lvi.SubItems.Add(((DateTime)dr[i]).ToString("yyyy-MM-dd"));
                    }
                    else
                    {
                        lvi.SubItems.Add(dr[i].ToString());
                    }
                }
                lv.Items.Add(lvi);
            }
            lv.EndUpdate();
        }

        /// <summary>
        /// 用查询结果填充combobox
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="sql"></param>
        public static void fillComboBox(ComboBox cb, string sql)
        {
            DataTable dt = selectToDt(sql);
            foreach (DataRow dr in dt.Rows)
            {
                cb.Items.Add(dr[0].ToString());
            }
            cb.SelectedIndex = 0;
        }
    }
}
