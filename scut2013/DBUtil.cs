using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace scut2013
{
    class DBUtil
    {
        private static readonly string connString = "Server = .\\sqlexpress; Database = scut2013; Uid = sa; Pwd = 9508";
        private static SqlConnection conn;

        public static void openConn()
        {
            conn = new SqlConnection(connString);
            conn.Open();
        }

        public static void closeConn()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public static DataTable selectToDt (string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public static void fillListView(ListView lv, string sql)
        {
            lv.Clear();
            lv.View = View.Details;
            lv.GridLines = true;
            lv.FullRowSelect = true;

            lv.BeginUpdate();
            DataTable dt = selectToDt(sql);
            foreach (DataColumn dc in dt.Columns)
            {
                lv.Columns.Add(dc.Caption, lv.Width / dt.Columns.Count - 2);
            }

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr[0].ToString();
                for(int i = 1; i < dt.Columns.Count; ++i)
                {
                    lvi.SubItems.Add(dr[i].ToString());
                }
                lv.Items.Add(lvi);
            }
            lv.EndUpdate();
        }

        public static void fillComboBox(ComboBox cb, string sql)
        {
            DataTable dt = selectToDt(sql);
            cb.Items.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                cb.Items.Add(dr[0].ToString());
            }
            cb.SelectedIndex = 0;
        }

        public static bool update(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteNonQuery() > 0;
        }
        
        public static bool exists(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteScalar() != null;
        }

    }
}
