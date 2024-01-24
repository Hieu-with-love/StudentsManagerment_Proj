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
    public partial class frmStudent : Form
    {
        StudentDAO stDAO = new StudentDAO();
        string sqlConn = "SELECT * FROM SinhVien";
        public frmStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvStudent.DataSource = stDAO.LoadDataForDGV(sqlConn);
            dgvStudent.Columns["id"].HeaderText = "ID";
            dgvStudent.Columns["hoten"].HeaderText = "Họ tên";
            dgvStudent.Columns["email"].HeaderText = "Email";
            dgvStudent.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvStudent.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvStudent.Columns["sdt"].HeaderText = "Số điện thoại";
            dgvStudent.Columns["cccd"].HeaderText = "CCCD";
            dgvStudent.Columns["ngaysinh"].HeaderText = "Ngày sinh";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool gt = rdbWoman.Checked ? true : false;
            Students st = new Students(txtId.Text, txtName.Text, txtEmail.Text, gt, txtAddress.Text, txtPhone.Text, txtCCCD.Text, dtpBirthday.Value);
            
            stDAO.AddSt(st);
            dgvStudent.DataSource = stDAO.LoadDataForDGV(sqlConn);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool gt = rdbWoman.Checked ? true : false;
            Students st = new Students(txtId.Text, txtName.Text, txtEmail.Text, gt, txtAddress.Text, txtPhone.Text, txtCCCD.Text, dtpBirthday.Value);
            stDAO.RemoveSt(st);
            dgvStudent.DataSource = stDAO.LoadDataForDGV(sqlConn);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool gt = rdbWoman.Checked ? true : false;
            Students st = new Students(txtId.Text, txtName.Text, txtEmail.Text, gt, txtAddress.Text, txtPhone.Text, txtCCCD.Text, dtpBirthday.Value);
            stDAO.EditSt(st);
            dgvStudent.DataSource = stDAO.LoadDataForDGV(sqlConn);
        }
    }
}
