using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV2_CSharp
{
    internal class Lop
    {
        private string MaLop;
        private string TenLop;
        public Lop() { }
        public Lop(string MaLop, string TenLop)
        {
            this.MaLop = MaLop;
            this.TenLop = TenLop;
        
        }
        KetNoi ob = new KetNoi();
        public DataTable Load_Lop()
        {
            string sql = "select * from Lop";
            return ob.Load(sql);
        }
        public void Insert(Lop lop1)
        {
            string sql = "Insert into Lop values('"+lop1.MaLop+"','"+lop1.TenLop+ "')";
            ob.Execute(sql);
        }
        public void Update(Lop lop1)
        {
            string sql = "Update Lop set TenLop = '" +lop1.TenLop +"' where MaLop = '"+ lop1.MaLop+ "'";
            ob.Execute(sql);
        }
        public void Delete(string MaLop)
        {
            string sql = "Delete from Lop where MaLop = '"+MaLop+"'";
            ob.Execute(sql);
        }

    }
}
