using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DangNhapBLL
    {
        DALDangNhap DN = new DALDangNhap();

        public DangNhapBLL()
        {
            
        }

        public int DangNhap(string ma, string pass)
        {
            int kt = 3;
            kt = DN.DangNhap(ma, pass);
            if (kt == 0) // nhap không đầy đủ
            {
                return 0;
            }
            else if (kt == 1) // đăng nhập thành công
            {
                return 1;
            }
            else if (kt == 2) //tk bị khóa
            {
                return 2;
            }
            else // đăng nhập thất bại!
            {
                return 3;
            }
            return 3;
        }
    }
}
