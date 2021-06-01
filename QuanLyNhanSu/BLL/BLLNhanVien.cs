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

        public BLLNhanVien()
        { 

        }

        public void LoadThongTinNhanVien(string ma)
        {
            NV.loadThongTinNV(ma);
            BLLtenNV = NV.DALtenNV;
            BLLmaNV = NV.DALmaNV;
            BLLchucvu = NV.DALchucvu;
        
        }
    }
}
