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
    public class StudentDAO : PersonDAO
    {
        public void AddSt(string sql, Students st)
        {
            SqlParameter[] lstParam = {
                new SqlParameter("@ht", SqlDbType.NVarChar) { Value = st.Name },
                new SqlParameter("@em", SqlDbType.VarChar) { Value = st.Email },
                new SqlParameter("@gt", SqlDbType.Bit) { Value = st.Sex },
                new SqlParameter("@dc", SqlDbType.NVarChar) { Value = st.Address },
                new SqlParameter("@sdt", SqlDbType.VarChar) { Value = st.Phone },
                new SqlParameter("@cc", SqlDbType.VarChar) { Value = st.Cccd },
                new SqlParameter("@ns", SqlDbType.Date) { Value = st.Birthday }
            };
            base.Add(sql, lstParam);
        }

        public void RemoveSt(string sql, Students st)
        {
            SqlParameter[] lstParam = {
                new SqlParameter("@id", SqlDbType.NVarChar) { Value = st.Id },
            };
            base.Remove(sql, lstParam);
        }

        public void EditSt(string sql, Students st)
        {
            SqlParameter[] lstParam = {
                new SqlParameter("@id", SqlDbType.NVarChar) { Value = st.Id },
            };
            base.Edit(sql, lstParam);
        }
    }
}
