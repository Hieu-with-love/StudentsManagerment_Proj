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
        PersonDAO stDAO = new StudentDAO();
        string sql;
        public frmStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM SinhVien";
            dgvStudent.DataSource = stDAO.LoadDataForDGV(sql);
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
            Students st = new Students()
            stDAO.Add()
        }
    }
}
