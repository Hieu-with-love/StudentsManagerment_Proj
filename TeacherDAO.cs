using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentsManagerment_Proj
{
    public class TeacherDAO : PersonDAO
    {
        public void AddTc(string sql, Students st)
        {

            SqlParameter[] lstParam = {
                new SqlParameter("@ht", SqlDbType.NVarChar) { Value = st.Name },
                new SqlParameter("@em", SqlDbType.NVarChar) { Value = st.Email },
                new SqlParameter("@gt", SqlDbType.Bit) { Value = st.Sex },
                new SqlParameter("@dc", SqlDbType.VarChar) { Value = st.Address },
                new SqlParameter("@sdt", SqlDbType.VarChar) { Value = st.Phone },
                new SqlParameter("@cc", SqlDbType.VarChar) { Value = st.Cccd },
                new SqlParameter("@ns", SqlDbType.Date) { Value = st.Birthday }
            };
            base.Add(sql, lstParam);
        }

        public void RemoveTc(string sql, Students st)
        {
            SqlParameter[] lstParam = {
                new SqlParameter("@id", SqlDbType.Int) { Value = st.Id },
            };
            base.Remove(sql, lstParam);
        }

        public void EditTc(string sql, Students st)
        {
            SqlParameter[] lstParam = {
                new SqlParameter("@id", SqlDbType.Int) { Value = st.Id },
                new SqlParameter("@ht", SqlDbType.NVarChar) { Value = st.Name },
                new SqlParameter("@em", SqlDbType.VarChar) { Value = st.Email },
                new SqlParameter("@gt", SqlDbType.Bit) { Value = st.Sex },
                new SqlParameter("@dc", SqlDbType.NVarChar) { Value = st.Address },
                new SqlParameter("@sdt", SqlDbType.VarChar) { Value = st.Phone },
                new SqlParameter("@cc", SqlDbType.VarChar) { Value = st.Cccd },
                new SqlParameter("@ns", SqlDbType.Date) { Value = st.Birthday }
            };
            base.Edit(sql, lstParam);
        }
    }
}
