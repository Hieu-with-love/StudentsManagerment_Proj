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
    public class PersonDAO
    {
        DBConnection dbcn = new DBConnection();
        public DataTable LoadDataForDGV(string sql)
        {
            return dbcn.LoadData(sql);
        }

        public void Add(string sql, SqlParameter[] lstParam)
        {
            if (dbcn.ExcuteQuery(sql, lstParam) > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
        }

        public void Remove(string sql, SqlParameter[] lstParam)
        {
            if (dbcn.ExcuteQuery(sql, lstParam) > 0)
            {
                MessageBox.Show("Xóa thành công");
            }
        }

        public void Edit(string sql, SqlParameter[] lstParam)
        {
            if (dbcn.ExcuteQuery(sql, lstParam) > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
        }
    }
}
