using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataQuanLyNhanSuTableAdapters;
using System.Data;


namespace DAL
{
    public class DALDonTu
    {
        DataQuanLyNhanSu qlns = new DataQuanLyNhanSu();
        LOAIDONTUTableAdapter loaidontu = new LOAIDONTUTableAdapter();
        DONTUTableAdapter dontuadapter = new DONTUTableAdapter();

        public string Dmanv;    //MANV CHAR(6),
        public string Dmadon;    //MADON CHAR(6),
        public string Dloaidon;    //MALOAIDON CHAR(6),
        public string Dnguoilap;    //NGUOILAP CHAR(6),
        public int Dtaoho;    //TAOHO INT,
        public string Dnguouduyet;    //NGUOIDUYET CHAR(6),
        public DateTime Dngaytao;    //NGAYTAO DATETIME,
        public string Dtrangthai;    //TRANGTHAI NVARCHAR(30),
        public string Dghichu;    //GHICHU NVARCHAR(50),
        //public string Dmadt    //MADON CHAR(6),
        public string Dlydo;    //LYDO NVARCHAR(60),
        public DateTime Dngaybd;        //NGAYBD DATETIME,
        public DateTime Dngaykt;        //NGAYKT DATETIME,
        public DateTime Dgiobd;        //GIOBD DATETIME,
        public DateTime Dgiokt;        //GIOKT DATETIME,
        public int Dtinhcong;        //TINHCONG INT,
        public string Dmota;        //MOTA NVARCHAR(200),
        public int Dphat;        //PHAT INT,

        public DALDonTu()
        { 
        
        }

        ////load loai 
        public DataTable loadLoaiDonDAL()
        {
            return loaidontu.GetData();
        }

        //loadDONTU thoe ma nhan vien

        public DataTable loadDonTuByMANVofDAL(string manv)
        {
            return dontuadapter.GetDataDonTuByManv(manv);
        }

        // load don tu theo ngay ta

        public DataTable loadDonTuByNGAYTAOofDAL(DateTime ngaytao)
        {
            return dontuadapter.GetDataDoTuByNGAYTAO(ngaytao);
        }


        //TaoDonTu
        //public int 
        ///
        ///
    }
}
