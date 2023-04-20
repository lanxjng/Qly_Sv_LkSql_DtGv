using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV2_CSharp
{
    class SinhVien
    {
        private string MaSv;
        private string HoTen;
        private DateTime NgaySinh;
        private string MaLop;

        public SinhVien() { }
        public SinhVien(string MaSv, string HoTen, DateTime NgaySinh, string MaLop)
        {
            this.MaLop = MaLop;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.MaLop = MaLop;
        }
        KetNoi ob = new KetNoi();
        public DataTable Load_SV()
        {
            string sql = "select * from SinhVien";
            return ob.Load(sql);
        }
        public DataTable Load_Lop()
        {
            string sql = "select * from Lop";
            return ob.Load(sql);
        }
        public void Insert(SinhVien sv1)
        {
            string sql = "Insert into SinhVien values('" + sv1.MaSv + "','" + sv1.HoTen + "','" + sv1.NgaySinh + "','" + sv1.MaLop + "')";
            ob.Execute(sql);
        }
        public void Update(SinhVien sv1)
        {
            string sql = "Update SinhVien set HoTen = '" + sv1.HoTen + "' where MaSv = '" + sv1.MaSv + "'";
            ob.Execute(sql);
        }
        public void Delete(string MaSv)
        {
            string sql = "Delete from Lop where MaSv = '" + MaSv + "'";
            ob.Execute(sql);
        }
    }
}
