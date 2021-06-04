﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;

namespace GUI
{
    public partial class MainForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BLLNhanVien NV = new BLLNhanVien();

        string manvdn;
        
        public MainForm1(string ma)
        {
            manvdn = ma;
            InitializeComponent();
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrameMain.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            //navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];

            navigationFrameMain.SelectedPage = NavigationPageTaiKhoan;
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void officeNavigationBar_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemNhanSu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // navigationFrameMain.SelectedPage = navigationPageNhanSu;
        }

        private void barButtonItem2_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemPhBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPagePhongBan;
        }

        private void barButtonItemChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPageChucVu;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPageDonTu;
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPageDonXinNghi;
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPageDonVangMat;
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPageDonCheckInOut;
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPageDonXinNghi;
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPageDonVangMat;
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPageDonCheckInOut;
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           //C:\Users\Admin\AppData\Local\GitHubDesktop\app-2.8.2\QuanLyNhanSu\QuanLyNhanSu\GUI\Resources\LOGO (1)1.png
           
            barButtonItemThongBao.Caption = "Thông Báo Mới";
            barButtonItemThongBao.ImageOptions.ImageUri.Uri = "language";
            //------------------------------------------------------------------------------
            //CÁCH ĐỔI HÌNH BẰNG LINK DẪN FOLDER :
            //barButtonItemThongBao.ImageUri.Uri = "C:/Users/Admin/AppData/Local/GitHubDesktop/app-2.8.2/QuanLyNhanSu/QuanLyNhanSu/GUI/Resources/LOGO (1)1.png";
        }

        private void barListItem1_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }

        private void lb_ChucVu_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        ///================================================================================================================================
        ///                       Tài khoản                      
        ///================================================================================================================================

        public void LoadThongTAIKHOAN(string ma)
        {
            NV.LoadThongTinNhanVien(ma);
            lb_TenNV_pageTAIKHOAN.Text = NV.BLLtenNV;
            lb_ChucVu_pageTAIKHOAN.Text = NV.BLLchucvu;
            lb_NgaySinh.Text = NV.BLLngaysinh;
            labelTaikhoan_TaiKhoan.Text = NV.BLLmaNV;
            lbPhongBan_TaiKhoan.Text = NV.BLLphongban;
            lbNgayVaoLam_TaiKhoan.Text = NV.BLLngayvaolam;

        }

        public void LoadTenTK(string ma)
        {
           
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             LoadThongTAIKHOAN(manvdn);
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItemTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = NavigationPageTaiKhoan;
        }

        ///================================================================================================================================
        ///                       LICH - CHẤM CÔNG                      
        ///================================================================================================================================

        ////----------------------------------------------khai báo

        #region Peoperties
       
        private List<List<ADAY>> matrix1;

        public List<List<ADAY>> Matrix1
        {
            get { return matrix1; }
            set { matrix1 = value; }
        }

        //--------------- CHUYỀN DATA
        private CaData ca;

        public CaData Ca
        {
            get { return ca; }
            set { ca = value; }
        }

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        #endregion

        // ////----------------------------------------------hàm phụ

        void LoadMatrix()
        {
            Matrix1 = new List<List<ADAY>>();

            ADAY olbaday = new ADAY() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix1.Add(new List<ADAY>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    ADAY btn = new ADAY() { Width = Cons.dateButtomWidth, Height = Cons.dateButtomHeight };
                    btn.Location = new Point(olbaday.Location.X + olbaday.Width + Cons.margin, olbaday.Location.Y);

                    //0--------Click----------------
                    //btn.Click += btn_Click;
                    //btn.Viewbtn += btn_Viewbtn;
                    btn.Viewpanel += btn_Viewpanel;

                    pnlMatrix.Controls.Add(btn);
                    Matrix1[i].Add(btn);

                    olbaday = btn;
                }
                olbaday = new ADAY() { Width = -Cons.margin, Height = 0, Location = new Point(0, olbaday.Location.Y + Cons.dateButtomHeight + Cons.margin) };
            }
            SetDefaultDate();
        }

        void btn_Viewpanel(object sender, EventArgs e)
        {
            //////////////SỰ KIỆN MỞ FORM///////////////////
            //if (string.IsNullOrEmpty((sender as ADAY).Textday1))
            //    return;
            //DailyPlan daily = new DailyPlan(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as ADAY).Textday1)));
            //daily.Show();
            /////////////////////////////////////////////////
        }

        void btn_Viewbtn(object sender, EventArgs e)
        {
            //////////////SỰ KIỆN MỞ FORM///////////////////
            //if (string.IsNullOrEmpty((sender as ADAY).Textday1))
            //    return;
            //DailyCa daily = new DailyCa(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as ADAY).Textday1)), manvdn, "CA001");
            //daily.Show();
            /////////////////////////////////////////////////

            if (string.IsNullOrEmpty((sender as ADAY).Textday1))
                return;
            DailyCa daily = new DailyCa(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as ADAY).Textday1)), manvdn, (sender as ADAY).Macaa1);
            daily.Show();

        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                    return 31;
                case 3:
                    return 31;
                case 5:
                    return 31;
                case 7:
                    return 31;
                case 8:
                    return 31;
                case 10:
                    return 31;
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;

                default:
                    return 30;
            }

        }
        //sửa cái này nữa nhá
        void AddNumberInMatrixByDate(DateTime date)
        {
            //ClearMatrix();
            //DateTime useDate = new DateTime(date.Year, date.Month, 1);

            //int line = 0;
            
            //for (int i = 1; i <= DayOfMonth(date); i++)
            //{
            //    int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
            //    ADAY btn = Matrix1[line][column];
            //    btn.numberDay(i.ToString());

            //    if (isEqualDate(useDate, DateTime.Now))
            //    {
            //        btn.BackColor = Color.Yellow;
            //    }

            //    if (isEqualDate(useDate, date))
            //    {
            //        btn.BackColor = Color.Aqua;
            //    }

            //    if (column >= 6)
            //        line++;

            //    useDate = useDate.AddDays(1);

            //}
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            /////////////////////////////////
            Ca = new CaData();
            //Ca.Ca = new List<CaItem>();
            Ca.ListCa();




            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                ADAY btn = Matrix1[line][column];

                btn.numberDay(i.ToString());

                foreach (var cahomnay in Ca.Ca)
                {
                    //if ((cahomnay.DayOfTuan-1) == column && date.Month >= cahomnay.DateBD.Month && date.Day >= cahomnay.DateBD.Day ) ///the nha them nha!!!
                    //{
                    //    btn.calamDay(cahomnay.Maca);
                    //    btn.BackColor = Color.Pink;
                    //}
                    if ((cahomnay.DayOfTuan - 1) == column && lonHonDate(useDate, cahomnay.DateBD) && nhoHonDate(useDate, cahomnay.DateKT)) ///the nha them nha!!!
                    {
                        btn.calamDay(cahomnay.Maca);
                        btn.BackColor = Color.Pink;
                        btn.Viewbtn +=btn_Viewbtn;
                    }
                    else
                    {
                        //btn.removeLableAday();
                    }
                }


                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }

                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                }

                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);


            }


        }


        bool isEqualDate(DateTime dateA, DateTime dateB)
        {

            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        bool nhoHonDate(DateTime dateA, DateTime dateB)
        {

            return dateA.Year <= dateB.Year && dateA.Month <= dateB.Month && dateA.Day <= dateB.Day;
        }

        bool lonHonDate(DateTime dateA, DateTime dateB)
        {

            return dateA.Year >= dateB.Year && dateA.Month >= dateB.Month && dateA.Day >= dateB.Day;
        }

        void ClearMatrix()
        {

            for (int i = 0; i < Matrix1.Count; i++)
            {
                for (int j = 0; j < Matrix1[i].Count; j++)
                {
                    ADAY btn = Matrix1[i][j];
                    btn.numberDay("");
                    btn.removeLableAday();
                    btn.BackColor = Color.White;
                }
            }
        }

        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;

        }

        // ////----------------------------------------------Load lịch làm

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
           // LoadMatrix();
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberInMatrixByDate((sender as DateTimePicker).Value);
            //btnMonDay.Text = "MonDay";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnPreviours_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnToDay_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            LoadMatrix();
        }

    }
}