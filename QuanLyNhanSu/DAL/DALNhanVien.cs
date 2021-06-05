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
        public string DALgioitinh;
        public string DALngaysinh;
        public string DALsdt;
        public string DALphongban;
        public string DALmaluong;
        public string DALngayvaolam;
        public string DALtinhtrang;
        public string DALchedolamviec;
        public string DALmahd;
        public string DALhinh;
        public string machucvu;
        public DALNhanVien()
        { 
        
        }

        public void loadThongTinNV(string ma)
        {
            using (LINQquanLyNhanSuDataContext db = new LINQquanLyNhanSuDataContext())
            { 
                
                NHANVIEN thongtin = db.NHANVIENs.SingleOrDefault(NV => NV.MANV.Equals(ma));
                DALtenNV = thongtin.TENNV;
                DALmaNV = thongtin.MANV;
                machucvu = thongtin.MACHUCVU;
                DALgioitinh =thongtin.GIOITINH;
                DALngaysinh = thongtin.NGAYSINH.ToString();
                DALsdt = thongtin.SDT;
                //DALphongban = thongtin;
                string mapb = thongtin.MAPH;
                //DALmaluong;
                string maluong = thongtin.MALUONG;
                DALngayvaolam = thongtin.NGAYVAOLAN.ToString();
                DALtinhtrang = thongtin.TINHTRANG;
                DALchedolamviec = thongtin.CHEDOLV;
                DALmahd = thongtin.MAHD;
                DALhinh = thongtin.HINHANH;

                CHUCVU ttChucVu = db.CHUCVUs.SingleOrDefault(NV => NV.MACHUCVU.Equals(machucvu));
                DALchucvu = ttChucVu.TENCHUVU;

                PHONGBAN ttPHONGBAN = db.PHONGBANs.SingleOrDefault(NV => NV.MAPH.Equals(mapb));
                DALphongban = ttPHONGBAN.TENPH;


                //var bangluong = db.QUATRINHLUONGs.OrderByDescending(m => m.MANV.Equals(DALmaNV)).First();

                //string luong = bangluong.LUONGCB.ToString();
                                
                                
                                
            }
        }
        
    }
}
