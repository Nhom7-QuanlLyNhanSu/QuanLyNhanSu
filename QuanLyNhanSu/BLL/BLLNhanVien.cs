using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLNhanVien
    {
        DALNhanVien NV = new DALNhanVien();
        public string BLLtenNV;
        public string BLLmaNV;
        public string BLLchucvu;
        public string BLLgioitinh;
        public string BLLngaysinh;
        public string BLLsdt;
        public string BLLphongban;
        public string BLLmaluong;
        public string BLLngayvaolam;
        public string BLLtinhtrang;
        public string BLLchedolamviec;
        public string BLLmahd;
        public string BLLhinh;
        public string machuvu;

        public BLLNhanVien()
        { 

        }

        public void LoadThongTinNhanVien(string ma)
        {
            NV.loadThongTinNV(ma);
            BLLtenNV = NV.DALtenNV;
            BLLmaNV = NV.DALmaNV;
            BLLchucvu = NV.DALchucvu;
            BLLgioitinh = NV.DALgioitinh;
            BLLngaysinh = NV.DALngaysinh;
            BLLsdt = NV.DALsdt;
            BLLphongban = NV.DALphongban;
            //BLLmaluong =  NV.;
            BLLngayvaolam = NV.DALngayvaolam;
            BLLtinhtrang = NV.DALtinhtrang;
            BLLchedolamviec = NV.DALtinhtrang;
            BLLmahd = NV.DALmahd;
            BLLhinh = NV.DALhinh;
            machuvu = NV.machucvu;
        }
    }
}
