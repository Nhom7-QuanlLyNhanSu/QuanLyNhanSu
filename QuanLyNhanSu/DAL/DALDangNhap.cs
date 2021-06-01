using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDangNhap
    {
        public DALDangNhap()
        { 
        }

        public int DangNhap(string manv, string makhau) // return 0: chua nhap text ; return 1: Dang nhap thanh cong; return 2: tk bi khoa; return 3: user mat khau sai
        {
            string user = manv;
            string pass = makhau;
            string TinhTrang;
            if (user.Equals("") || pass.Equals(""))
            {
                //MessageBox.Show("Vui lòng nhập Username và Password");
                return 0;
            }            
            TAIKHOAN insertDN = new TAIKHOAN { MANV = user, MAKHAU = pass };
            using (DataTaiKhoanDataContext db = new DataTaiKhoanDataContext())
            {
                TAIKHOAN checkUSER = db.TAIKHOANs.FirstOrDefault(sv => insertDN.MANV.Equals(sv.MANV));
                TAIKHOAN checkPASS = db.TAIKHOANs.FirstOrDefault(sv => insertDN.MAKHAU.Equals(sv.MAKHAU));
                if (checkUSER == null || checkPASS == null)
                {
                    //MessageBox.Show("Mật khẩu hoặc tên đăng nhập không tồn tại");
                    return 3;
                }
                else
                {
                    using (DataTaiKhoanDataContext dbm = new DataTaiKhoanDataContext())
                    {
                        TAIKHOAN layma = dbm.TAIKHOANs.FirstOrDefault(x => x.MANV == user);
                        {
                            manv = layma.MANV;
                            TinhTrang = layma.TRANGTHAI.ToString();
                        }
                    }
                    if (TinhTrang == "1")
                    {

                        //DialogResult rs = MessageBox.Show("Đăng Nhập Thành Công!!", "Hỏi đáp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //if (rs.Equals(DialogResult.Yes))
                        //{
                        //    ma = manv;
                        //}
                        return 1;
                    }
                    else
                    {
                        //DialogResult rs = MessageBox.Show("Tài khoản đã bị khóa, liên hệ phòng nhân sự để mở lại!!", "Hỏi đáp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        return 2;
                    }
                }
            }

            return 3;
        }


    }
}
