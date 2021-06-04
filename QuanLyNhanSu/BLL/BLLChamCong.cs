using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLLChamCong
    {
        DALChamCong cc = new DALChamCong();

        public string manv;
        public DateTime ngaycc;
        public DateTime checkin;
        public DateTime checkout;
        public int solan;

        public BLLChamCong()
        { 
            
        }

        public int BLLCheckin(string MaNV, DateTime Ngaytao, int gio, int phut)
        {
            int i = cc.NhapCheckin(MaNV, Ngaytao, gio, phut);
            if (i == 1)
                return 1;
            return 0;

        }

        public int BLLcheckChamCong(string MaNV, DateTime Ngaytao)
        {
            int i = cc.checkChamCong(MaNV, Ngaytao);

            return i;
        }

        public int BLLCheckOut(string MaNV, DateTime Ngaytao, int gio, int phut)
        {
            int i = cc.CheckOut(MaNV, Ngaytao, gio, phut);
            if (i == 1)
                return 1;
            return 0;
        }
    }
}
