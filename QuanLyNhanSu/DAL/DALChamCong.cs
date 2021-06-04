using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DALChamCong
    {

        public string manv;
        public DateTime ngaycc;
        public DateTime checkin;
        public DateTime checkout;
        public int solan;

        public DALChamCong()
        { 
        
        }

        public int NhapCheckin(string MaNV, DateTime Ngaytao, int gio, int phut)
        {
            DateTime date = new DateTime(2000,1,1,gio,phut,0);
            int solan = 1;

         using (LINQquanLyNhanSuDataContext db = new LINQquanLyNhanSuDataContext())
            {
                CHAMCONG CHEKCIN = new CHAMCONG();
                {
                    CHEKCIN.MANV = MaNV;
                    CHEKCIN.NGAYCC = Ngaytao;
                    CHEKCIN.CHECKIN = date;
                    //CHEKCIN.CHECKOUT = null;
                    CHEKCIN.SOLAN = solan;
                   
                }
                try
                {                   
                    db.CHAMCONGs.InsertOnSubmit(CHEKCIN);
                    db.SubmitChanges();

                }
                catch
                {
                    return 0;
                }
            }
         return 1;
        }


        public int checkChamCong(string MaNV, DateTime Ngaytao) //return 0/ chua check in / return 1 đã checkin / return 2 đã checkout
        { 
             using (LINQquanLyNhanSuDataContext db = new LINQquanLyNhanSuDataContext())
            {
               // int kt = isEqualDate((DateTime)r.NGAYCC, Ngaytao);
                CHAMCONG CC = db.CHAMCONGs.FirstOrDefault(r => r.MANV == MaNV && (r.NGAYCC.Day == Ngaytao.Day && r.NGAYCC.Month == Ngaytao.Month));


                if (CC == null)
                {
                    return 0;
                }
                else if (CC.SOLAN == 1)
                    return 1;
             }
             return 2;
        }

        public int CheckOut(string MaNV, DateTime Ngaytao, int gio, int phut)
        {
            DateTime date = new DateTime(2000, 1, 1, gio, phut, 0);
            int solan = 2;
            using (LINQquanLyNhanSuDataContext db = new LINQquanLyNhanSuDataContext())
            {
                CHAMCONG cc = (from r in db.CHAMCONGs
                               where r.MANV == MaNV && (r.NGAYCC.Day == Ngaytao.Day && r.NGAYCC.Month == Ngaytao.Month)
                                      select r).FirstOrDefault();
                if (cc == null)
                {
                    return 0;
                }


                cc.CHECKOUT = date;
                cc.SOLAN = solan;
                //db.DANGNHAPs.InsertOnSubmit(dn);
                db.SubmitChanges();
                return 1;
            }
        }


                         //////////////////////So sách datetime////////////////////////
        public int isEqualDate(DateTime dateA, DateTime dateB)
        {
            if (dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day)
                return 1;
            return 0;
        }

        bool nhoHonDate(DateTime dateA, DateTime dateB)
        {

            return dateA.Year <= dateB.Year && dateA.Month <= dateB.Month && dateA.Day <= dateB.Day;
        }

        bool lonHonDate(DateTime dateA, DateTime dateB)
        {

            return dateA.Year >= dateB.Year && dateA.Month >= dateB.Month && dateA.Day >= dateB.Day;
        }

    }
}
