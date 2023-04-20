using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSV2_CSharp
{
    public partial class Form_SinhVien : Form
    {
        public Form_SinhVien()
        {
            InitializeComponent();
        }

        private void Form_SinhVien_Load(object sender, EventArgs e)
        {
            SinhVien ob = new SinhVien();
            dataGridView1.DataSource = ob.Load_SV();
            cbbMaLop.DataSource = ob.Load_Lop();
            cbbMaLop.ValueMember = "MaLop";
            cbbMaLop.DisplayMember = "TenLop";
            txtMaSv.Clear();
            txtHoTen.Clear();
            cbbMaLop.Text = "";

        }

        private void Chon_STT(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;

        }

        private void Chon_Sv(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaSv.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            NgaySinh.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            cbbMaLop.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtMaSv.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SinhVien ob = new SinhVien(txtMaSv.Text, txtHoTen.Text,NgaySinh.Value,cbbMaLop.Text);
            ob.Insert(ob);
            Form_SinhVien_Load(sender, e);
            txtMaSv.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SinhVien ob = new SinhVien(txtMaSv.Text, txtHoTen.Text, NgaySinh.Value, cbbMaLop.Text);
            ob.Update(ob);
            Form_SinhVien_Load(sender, e);
            txtMaSv.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SinhVien ob = new SinhVien(txtMaSv.Text, txtHoTen.Text, NgaySinh.Value, cbbMaLop.Text);
            ob.Delete(txtMaSv.Text);
            Form_SinhVien_Load(sender, e);
            txtMaSv.Enabled = true;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSv.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
