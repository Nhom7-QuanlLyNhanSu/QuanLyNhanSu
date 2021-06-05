using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLDonTu
    {
        DALDonTu dt = new DALDonTu();

        public string Bmanv;    //MANV CHAR(6),
        public string Bmadon;    //MADON CHAR(6),
        public string Bloaidon;    //MALOAIDON CHAR(6),
        public string Bnguoilap;    //NGUOILAP CHAR(6),
        public int Btaoho;    //TAOHO INT,
        public string Bnguouduyet;    //NGUOIDUYET CHAR(6),
        public DateTime Bngaytao;    //NGAYTAO DATETIME,
        public string Btrangthai;    //TRANGTHAI NVARCHAR(30),
        public string Bghichu;    //GHICHU NVARCHAR(50),
        //public string Dmadt    //MADON CHAR(6),
        public string Blydo;    //LYDO NVARCHAR(60),
        public DateTime Bngaybd;        //NGAYBD DATETIME,
        public DateTime Bngaykt;        //NGAYKT DATETIME,
        public DateTime Bgiobd;        //GIOBD DATETIME,
        public DateTime Bgiokt;        //GIOKT DATETIME,
        public int Btinhcong;        //TINHCONG INT,
        public string Bmota;        //MOTA NVARCHAR(200),
        public int Bphat;        //PHAT INT,

        public BLLDonTu()
        {
        
        
        }
               ////load loai 
        public DataTable loadLoaiDon()
        {
            return dt.loadLoaiDonDAL();
        }
        //load don tu theo ma nhan vien
        public DataTable loadDonTuByMANVofBLL(string manv)
        {
            return dt.loadDonTuByMANVofDAL(manv);
        }
        //load don tu theo ngay
        public DataTable loadDonTuByNGAYTAOofBLL(DateTime ngaytao)
        {
            return dt.loadDonTuByNGAYTAOofDAL(ngaytao);
        }
    }
}
