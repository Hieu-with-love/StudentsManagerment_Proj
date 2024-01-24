using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace StudentsManagerment_Proj
{
    public class DBConnection
    {
        readonly SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=StudentsManagerment;Integrated Security=True");
        string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=StudentsManagerment;Integrated Security=True";
        SqlCommand cmd;
        DataTable dt;

        public DataTable LoadData(string sqlQuery)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmd = new SqlCommand(sqlQuery, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tải dữ liệu thất bại.\n"+ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public int ExcuteQuery(string sql, SqlParameter[] lstParam)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(lstParam);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi thất bại.\n"+ex.Message);
                return 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        /*public int ExecuteQuery(string sql, SqlParameter[] lstParam)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddRange(lstParam);
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi thất bại.\n" + ex.Message);
                return 0;
            }
        }*/
    }
}
