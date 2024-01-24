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
        public void AddSt(Students st)
        {
            int gt = st.Sex ? 1 : 0;
            SqlParameter[] lstParam = {
                new SqlParameter("@ht", SqlDbType.NVarChar) { Value = st.Name },
                new SqlParameter("@em", SqlDbType.NVarChar) { Value = st.Email },
                new SqlParameter("@gt", SqlDbType.Int) { Value = gt },
                new SqlParameter("@dc", SqlDbType.NVarChar) { Value = st.Address },
                new SqlParameter("@sdt", SqlDbType.VarChar) { Value = st.Phone },
                new SqlParameter("@cc", SqlDbType.VarChar) { Value = st.Cccd },
                new SqlParameter("@ns", SqlDbType.Date) { Value = st.Birthday }
            };
            string sql = "INSERT INTO SinhVien(hoten,email,gioitinh,diachi,sdt,cccd,ngaysinh) VALUES(@ht,@em,@gt,@dc,@sdt,@cc,@ns)";
            base.Add(sql, lstParam);
        }

        public void RemoveSt(Students st)
        {
            SqlParameter[] lstParam = {
                new SqlParameter("@id", SqlDbType.Int) { Value = st.Id },
            };
            string sql = "DELETE SinhVien WHERE id = @id";
            base.Remove(sql, lstParam);
        }

        public void EditSt(Students st)
        {
            int gt = st.Sex ? 1 : 0;
            SqlParameter[] lstParam = {
                new SqlParameter("@id", SqlDbType.Int) { Value = st.Id },
                new SqlParameter("@ht", SqlDbType.NVarChar) { Value = st.Name },
                new SqlParameter("@em", SqlDbType.VarChar) { Value = st.Email },
                new SqlParameter("@gt", SqlDbType.Int) { Value = gt },
                new SqlParameter("@dc", SqlDbType.NVarChar) { Value = st.Address },
                new SqlParameter("@sdt", SqlDbType.VarChar) { Value = st.Phone },
                new SqlParameter("@cc", SqlDbType.VarChar) { Value = st.Cccd },
                new SqlParameter("@ns", SqlDbType.Date) { Value = st.Birthday }
            };
            string sql = "UPDATE SinhVien SET id=@id,hoten=@ht,email=@em,gioitinh=@gt,diachi=@dc,sdt=@sdt,cccd=@cc,ngaysinh=@ns WHERE id = @id";
            base.Edit(sql, lstParam);
        }
    }
}
