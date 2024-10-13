using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_1
{
    internal class Sql_QLNS
    {
        public DataTable ds_qlns(string layds)
        {
            try
            {
                SqlConnection data = new SqlConnection("Data Source=DESKTOP-3J4S37H\\SQLEXPRESS;Initial Catalog=QLNS_D1;Integrated Security=True");
                data.Open();
                SqlCommand cmd = new SqlCommand(layds, data);
                SqlDataAdapter dA = new SqlDataAdapter(cmd);
                DataTable dT = new DataTable();
                dA.Fill(dT);
                return dT;
            }
            catch (Exception)
            {
                MessageBox.Show("");
                return null;
            }

        }
        public int Change(string layds)
        {
            SqlConnection data = new SqlConnection("Data Source=DESKTOP-3J4S37H\\SQLEXPRESS;Initial Catalog=QLNS_D1;Integrated Security=True");
            data.Open();
            SqlCommand cmd = new SqlCommand(layds, data);
            int row = cmd.ExecuteNonQuery();
            data.Close();
            return row;
        }

    }
}
