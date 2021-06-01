using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNhanVien
    {
        public string DALtenNV;
        public string DALmaNV;
        public string DALchucvu;
        public DALNhanVien()
        { 
        
        }

        public void loadThongTinNV(string ma)
        {
            using (LINQquanLyNhanSuDataContext db = new LINQquanLyNhanSuDataContext())
            { 
                string machucvu;
                NHANVIEN thongtin = db.NHANVIENs.SingleOrDefault(NV => NV.MANV.Equals(ma));
                DALtenNV = thongtin.TENNV;
                DALmaNV = thongtin.MANV;
                machucvu = thongtin.MACHUCVU;

                CHUCVU ttChucVu = db.CHUCVUs.SingleOrDefault(NV => NV.MACHUCVU.Equals(machucvu));
                DALchucvu = ttChucVu.TENCHUVU;
            }
        }
        
    }
}
