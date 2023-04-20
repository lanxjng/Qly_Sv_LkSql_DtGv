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
    public partial class Form_Lop : Form
    {
        public Form_Lop()
        {
            InitializeComponent();
        }

        private void Form_Lop_Load(object sender, EventArgs e)
        {
            Lop ob = new Lop();
            dataGridView1.DataSource = ob.Load_Lop();
            txtMaLop.Clear();
            txtTenLop.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Lop lop1 = new Lop(txtMaLop.Text, txtTenLop.Text);
            lop1.Insert(lop1);
            Form_Lop_Load(sender, e);
            txtMaLop.Enabled = false;
;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Lop lop1 = new Lop(txtMaLop.Text, txtTenLop.Text);
            lop1.Update(lop1);
            Form_Lop_Load(sender, e);
            txtMaLop.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Lop lop1 = new Lop(txtMaLop.Text, txtTenLop.Text);
            lop1.Delete(txtMaLop.Text);
            Form_Lop_Load(sender, e);
            txtMaLop.Enabled = true;
        }

        private void Chon_Lop(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaLop.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtTenLop.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtMaLop.Enabled = false;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STT(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }



    }
}
