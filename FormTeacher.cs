using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagerment_Proj
{
    public partial class frmTeacher : Form
    {
        TeacherDAO tcDAO = new TeacherDAO();
        string sqlConn = "SELECT * FROM GiaoVien";
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            dgvTeacher.DataSource = tcDAO.LoadDataForDGV(sqlConn);
            dgvTeacher.Columns["id"].HeaderText = "ID";
            dgvTeacher.Columns["hoten"].HeaderText = "Họ tên";
            dgvTeacher.Columns["email"].HeaderText = "Email";
            dgvTeacher.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvTeacher.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvTeacher.Columns["sdt"].HeaderText = "Số điện thoại";
            dgvTeacher.Columns["cccd"].HeaderText = "CCCD";
            dgvTeacher.Columns["ngaysinh"].HeaderText = "Ngày sinh";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool gt = rdbWoman.Checked ? true : false;
            Students st = new Students(txtId.Text, txtName.Text, txtEmail.Text, gt, txtAddress.Text, txtPhone.Text, txtCCCD.Text, dtpBirthday.Value);
            string sql = "INSERT INTO GiaoVien(hoten,email,gioitinh,diachi,sdt,cccd,ngaysinh) VALUES(@ht,@em,@gt,@dc,@sdt,@cc,@ns)";
            tcDAO.AddTc(sql, st);
            dgvTeacher.DataSource = tcDAO.LoadDataForDGV(sqlConn);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool gt = rdbWoman.Checked ? true : false;
            Students st = new Students(txtId.Text, txtName.Text, txtEmail.Text, gt, txtAddress.Text, txtPhone.Text, txtCCCD.Text, dtpBirthday.Value);
            string sql = "DELETE GiaoVien WHERE id = @id";
            tcDAO.RemoveTc(sql, st);
            dgvTeacher.DataSource = tcDAO.LoadDataForDGV(sqlConn);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool gt = rdbWoman.Checked ? true : false;
            Students st = new Students(txtId.Text, txtName.Text, txtEmail.Text, gt, txtAddress.Text, txtPhone.Text, txtCCCD.Text, dtpBirthday.Value);
            string sql = "UPDATE GiaoVien SET id=@id,hoten=@ht,email=@em,gioitinh=@gt,diachi=@dc,sdt=@sdt,cccd=@cc,ngaysinh=@ns WHERE id = @id";
            tcDAO.EditTc(sql, st);
            dgvTeacher.DataSource = tcDAO.LoadDataForDGV(sqlConn);
        }
    }
}
