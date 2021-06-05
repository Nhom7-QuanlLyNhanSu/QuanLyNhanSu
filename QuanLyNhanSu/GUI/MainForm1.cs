using System;
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
        DangNhapBLL DN = new DangNhapBLL();
        BLLDonTu DT = new BLLDonTu();
        BLLChucVu cv = new BLLChucVu();
        BLLHopDong hd = new BLLHopDong();
        BLLQLNhanVien nv = new BLLQLNhanVien();
        BLLPhongBan pb = new BLLPhongBan();
        string manvdn;
        protected string fileName = "null";
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
            navigationFrameMain.SelectedPage = navigationPageNhanSu;
        }

        private void barButtonItem2_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemPhBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPagePhongBan;
            dataGridViewPHONGBAN.DataSource = pb.loadDGVDSPB();
        }

        private void barButtonItemChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            navigationFrameMain.SelectedPage = navigationPageChucVu;
            dataGridViewChuVu.DataSource = cv.loaddgvDSCV();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPageDonTu;
           // DataTable datadon
            dataGridViewDonTu_DonTu.DataSource = DT.loadDonTuByMANVofBLL(manvdn);

           // for (int i = 0; i < datadon.Rows.Count; i++)
           // {
           //     DataRow dr = datadon.Rows[i];
           //     ListViewItem item = new ListViewItem(dr[1].ToString());
           //     ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, datadon.Rows[i][0].ToString());
           //     item.SubItems.Add(dr[2].ToString());
           //     item.SubItems.Add(dr[3].ToString());
           //     item.SubItems.Add(dr[4].ToString());
           //     item.SubItems.Add(subitem);
           //     listViewDonTu_DonTu.Items.Add(item);
               
           // }
           //listViewDonTu_DonTu.View = View.Details;
           //listViewDonTu_DonTu.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
           //listViewDonTu_DonTu.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
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
            string hinh;
            hinh = NV.BLLhinh;

            if (NV.machuvu.Equals("MAR003") || NV.machuvu.Equals("MAR004"))
            {
                barButtonItemTaoBangLuong.Enabled = true;
                barButtonItemQLngaynghi_hr.Enabled = true;
                barButtonItemPhanCa_HR.Enabled = true;
                barButtonItemDuyetPhieuChi.Enabled = true;
                barButtonItemDuyetPhieuThu.Enabled = true;
                barButtonItemDuyetDonTu.Enabled = true;
                barButtonItemNhanSu_HR.Enabled = true;
                barButtonItemThietLapCa.Enabled = true;
            }
            else
            {

                barButtonItemTaoBangLuong.Enabled = false;
                barButtonItemQLngaynghi_hr.Enabled = false;
                barButtonItemPhanCa_HR.Enabled = false;
                barButtonItemDuyetPhieuChi.Enabled = false;
                barButtonItemDuyetPhieuThu.Enabled = false;
                barButtonItemDuyetDonTu.Enabled = false;
                barButtonItemNhanSu_HR.Enabled = false;
                barButtonItemThietLapCa.Enabled = false;
            }

//C:\Users\Admin\AppData\Local\GitHubDesktop\app-2.8.2\QuanLyNhanSu\QuanLyNhanSu\GUI\HINH\avatar\avartar.png
//C:\Users\Admin\AppData\Local\GitHubDesktop\app-2.8.2\QuanLyNhanSu\QuanLyNhanSu\GUI\Resources\son1.png
            try
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Admin/AppData/Local/GitHubDesktop/app-2.8.2/QuanLyNhanSu/QuanLyNhanSu/GUI/Resources/" + hinh);
            }
            catch
            {
               //pictureBox1.Image = Image.FromFile("C:/Users/Admin/AppData/Local/GitHubDesktop/app-2.8.2/QuanLyNhanSu/QuanLyNhanSu/GUI/HINH/avatar/avartar.png");
            }



        }

        public void LoadTenTK(string ma)
        {
           
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // LoadThongTAIKHOAN(manvdn);
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItemTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadThongTAIKHOAN(manvdn);

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
            Ca.ListCa(manvdn);




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
            LoadThongTAIKHOAN(manvdn);
            LoadMatrix();
            panelEditMK_TaiKhoan.Hide();
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất không?", "Hỏi đáp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs.Equals(DialogResult.Yes))
            {
                this.Visible = false;
                FormDangNhap f = new FormDangNhap();
                f.Show();
                //this.Close();
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void labelXacNhan_MK_TaiKhoan_Click(object sender, EventArgs e)
        {
            if (TB_NEWMK_TaiKhoan.Text == null || TB_OLDMK_TaiKhoan.Text == null || TB_REMK_TaiKhoan.Text == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }

            if (TB_NEWMK_TaiKhoan.Text != TB_REMK_TaiKhoan.Text)
                MessageBox.Show("Nhập lại mật khẩu mới, hai mật khẩu không giống nhau!");

            int kt = DN.DangNhap(manvdn, TB_OLDMK_TaiKhoan.Text);

            if (kt == 1)
            {
                int i = DN.BLLDoiMK(manvdn, TB_NEWMK_TaiKhoan.Text);
                if (i == 1)
                {

                    DialogResult rs = MessageBox.Show("Vui lòng đăng xuất để sử dụng mật khẩu mới?", "Hỏi đáp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs.Equals(DialogResult.Yes))
                    {
                        this.Visible = false;
                        FormDangNhap f = new FormDangNhap();
                        f.Show();
                        //this.Close();
                    }
                }
                else
                    MessageBox.Show("Đổi mật khẩu thấy bại!");
            }
            else
                MessageBox.Show("Mật khẩu sai, vui lòng nhập lại!");
        }

        private void label_Huy_MK_TaiKhoan_Click(object sender, EventArgs e)
        {
            panelEditMK_TaiKhoan.Hide();
            TB_NEWMK_TaiKhoan.Text = ""; TB_OLDMK_TaiKhoan.Text = ""; TB_REMK_TaiKhoan.Text = "";
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panelEditMK_TaiKhoan.Hide();
            TB_NEWMK_TaiKhoan.Text = ""; TB_OLDMK_TaiKhoan.Text = ""; TB_REMK_TaiKhoan.Text = "";
        }

        private void btn_DoiMK_TaiKhoan_Click(object sender, EventArgs e)
        {
            panelEditMK_TaiKhoan.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dataGridViewChuVu.DataSource = cv.loaddgvDSCVTheoMa(txtTK.Text);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm chức vụ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (cv.themCV(cv.taoMaTD(), txtTen.Text) == 1)
                {
                    MessageBox.Show("Thêm thành công!");
                    dataGridViewChuVu.DataSource = cv.loaddgvDSCV();
                    txtMa.Text = "";
                    txtTen.Text = "";

                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                    dataGridViewChuVu.DataSource = cv.loaddgvDSCV();
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn sửa chức vụ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (cv.suaCV(txtTen.Text, txtMa.Text) == 1)
                {
                    MessageBox.Show("Sửa thành công!");
                    dataGridViewChuVu.DataSource = cv.loaddgvDSCV();
                    txtMa.Text = "";
                    txtTen.Text = "";

                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                    dataGridViewChuVu.DataSource = cv.loaddgvDSCV();
                }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa chức vụ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (cv.xoaCV(dataGridViewChuVu.CurrentRow.Cells[0].Value.ToString()) == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    dataGridViewChuVu.DataSource = cv.loaddgvDSCV();
                    txtMa.Text = "";
                    txtTen.Text = "";

                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                    dataGridViewChuVu.DataSource = cv.loaddgvDSCV();
                }
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }

        private void simpleButtonSEARCH_HD_Click(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = hd.loadDGVDSHDTheoMa(txtTK_HD.Text);
        }

        private void barButtonItemHopDong_HR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPageHopDong_HR;
            dgvDSHD.DataSource = hd.loadDGVDSHD();

        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButtonXEMTATCA_HD_Click(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = hd.loadDGVDSHD();

        }

        private void btnThem_HD_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm hợp đồng?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime dtBD = dtpNgayBD_HD.Value;
                DateTime dtKT = dtpNgayKT_HD.Value;
                DateTime dtNK = dtpNK_HD.Value;
                if (hd.ThemHD(hd.taoMaHDTDBLL(), txtTen_HD.Text, dtBD, dtKT, dtNK, "Còn hiệu lực", txtND_HD.Text).ToString() == "1")
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvDSHD.DataSource = hd.loadDGVDSHD();
                    txtMa_HD.Text = "";
                    txtTen_HD.Text = "";
                    dtpNgayBD_HD.Value = DateTime.Now;
                    dtpNgayKT_HD.Value = DateTime.Now;
                    dtpNK_HD.Value = DateTime.Now;
                    txtND_HD.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                    dgvDSHD.DataSource = hd.loadDGVDSHD();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void simpleButtonCLEAR_HD_Click(object sender, EventArgs e)
        {
            txtMa_HD.Text = "";
            txtTen_HD.Text = "";
            dtpNgayBD_HD.Value = DateTime.Now;
            dtpNgayKT_HD.Value = DateTime.Now;
            dtpNK_HD.Value = DateTime.Now;
            txtND_HD.Text = "";
        }

        private void simpleButtonSUA_HD_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn muốn sửa hợp đồng?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime dtBD = dtpNgayBD_HD.Value;
                DateTime dtKT = dtpNgayKT_HD.Value;
                DateTime dtNK = dtpNK_HD.Value;
                if (hd.SuaHD(txtTen_HD.Text, dtBD, dtKT, dtNK, "Còn hiệu lực", txtND_HD.Text, txtMa_HD.Text) == 1)
                {
                    MessageBox.Show("Sửa thành công!");
                    dgvDSHD.DataSource = hd.loadDGVDSHD();
                    txtMa_HD.Text = "";
                    txtTen_HD.Text = "";
                    dtpNgayBD_HD.Value = DateTime.Now;
                    dtpNgayKT_HD.Value = DateTime.Now;
                    dtpNK_HD.Value = DateTime.Now;
                    txtND_HD.Text = "";
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                    dgvDSHD.DataSource = hd.loadDGVDSHD();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void simpleButton_XOA_HD_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa hợp đồng?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (hd.XoaHD(dgvDSHD.CurrentRow.Cells[0].Value.ToString()) == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvDSHD.DataSource = hd.loadDGVDSHD();
                    txtMa_HD.Text = "";
                    txtTen_HD.Text = "";
                    dtpNgayBD_HD.Value = DateTime.Now;
                    dtpNgayKT_HD.Value = DateTime.Now;
                    dtpNK_HD.Value = DateTime.Now;
                    txtND_HD.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                    dgvDSHD.DataSource = hd.loadDGVDSHD();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void navigationPageNhanSu_Paint(object sender, PaintEventArgs e)
        {

             navigationFrameMain.SelectedPage = navigationPageNhanSu;

        }

        private void btnShowAll_QLNV_Click(object sender, EventArgs e)
        {
            dataGridViewNhanSu.DataSource = nv.loadDSNV();

        }

        private void btnTimKiem_QLNV_Click(object sender, EventArgs e)
        {
            dataGridViewNhanSu.DataSource = nv.loadDSNVTheoMa(txtTimKiem_QLNV.Text);
        }

        private void barButtonItemNhanSu_HR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrameMain.SelectedPage = navigationPageNhanSu;

            dataGridViewNhanSu.DataSource = nv.loadDSNV();
            cbbPhongBan_QLNV.DataSource = nv.loadCBBPhongban();
            cbbPhongBan_QLNV.DisplayMember = "TENPH";
            cbbPhongBan_QLNV.ValueMember = "MAPH";
        }

        private void bnbrowse_QLNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {


                fileName = dlg.FileName;

            }
        }

        private void btnThem_QLNV_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm nhân viên?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime dtpNS = dtpNgaySinh_QLNV.Value;
                DateTime dtpNVL = dtpNgayVL_QLNV.Value;

                if (nv.themNV(nv.taoMaTD(), txtTen_QLNV.Text, cbbGioiTinh_QLNV.Text, dtpNS, txtSDT_QLNV.Text, cbbPB_QLNV.SelectedValue.ToString(), cbbChucVu_QLNV.SelectedValue.ToString(), txtMaLuong_QLNV.Text, dtpNVL, txtTinhTrang_QLNV.Text, cbbChedolam_QLNV.Text, txtMaHD_QLNV.Text, fileName) == 1)
                {
                    MessageBox.Show("Thêm thành công!");
                    dataGridViewNhanSu.DataSource = nv.loadDSNV();
                    btnThem_QLNV.Enabled = false;
                    txtMa_QLNV.Text = "";
                    txtTen_QLNV.Text = "";
                    dtpNgaySinh_QLNV.Value = DateTime.Now;
                    txtSDT_QLNV.Text = "";
                    txtMaLuong_QLNV.Text = "";
                    txtTinhTrang_QLNV.Text = "";
                    txtMaHD_QLNV.Text = "";
                    dtpNgayVL_QLNV.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                    dataGridViewChuVu.DataSource = nv.loadDSNV();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnSua_QLNV_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn sửa nhân viên?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime dtpNS = dtpNgaySinh_QLNV.Value;
                DateTime dtpNVL = dtpNgayVL_QLNV.Value;

                if (nv.suaNV(txtTen_QLNV.Text, cbbGioiTinh_QLNV.Text, dtpNS, txtSDT_QLNV.Text, cbbPB_QLNV.SelectedValue.ToString(), cbbChucVu_QLNV.SelectedValue.ToString(), txtMaLuong_QLNV.Text, dtpNVL, txtTinhTrang_QLNV.Text, cbbChedolam_QLNV.Text, txtMaHD_QLNV.Text, fileName, txtMa_QLNV.Text) == 1)
                {
                    MessageBox.Show("Sửa thành công!");
                    dataGridViewNhanSu.DataSource = nv.loadDSNV();
                    btnThem_QLNV.Enabled = false;
                    txtMa_QLNV.Text = "";
                    txtTen_QLNV.Text = "";
                    dtpNgaySinh_QLNV.Value = DateTime.Now;
                    txtSDT_QLNV.Text = "";
                    txtMaLuong_QLNV.Text = "";
                    txtTinhTrang_QLNV.Text = "";
                    txtMaHD_QLNV.Text = "";
                    dtpNgayVL_QLNV.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                    dataGridViewChuVu.DataSource = nv.loadDSNV();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnXoa_QLNV_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa nhân viên?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (nv.xoaNV(txtMa_QLNV.Text) == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    dataGridViewNhanSu.DataSource = nv.loadDSNV();
                    btnThem_QLNV.Enabled = false;
                    txtMa_QLNV.Text = "";
                    txtTen_QLNV.Text = "";
                    dtpNgaySinh_QLNV.Value = DateTime.Now;
                    txtSDT_QLNV.Text = "";
                    txtMaLuong_QLNV.Text = "";
                    txtTinhTrang_QLNV.Text = "";
                    txtMaHD_QLNV.Text = "";
                    dtpNgayVL_QLNV.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                    dataGridViewChuVu.DataSource = nv.loadDSNV();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnClear_QLNV_Click(object sender, EventArgs e)
        {
            btnThem_QLNV.Enabled = false;
            txtMa_QLNV.Text = "";
            txtTen_QLNV.Text = "";
            dtpNgaySinh_QLNV.Value = DateTime.Now;
            txtSDT_QLNV.Text = "";
            txtMaLuong_QLNV.Text = "";
            txtTinhTrang_QLNV.Text = "";
            txtMaHD_QLNV.Text = "";
            dtpNgayVL_QLNV.Value = DateTime.Now;
        }

        private void simpleButtonTim__PB_Click(object sender, EventArgs e)
        {
            dataGridViewPHONGBAN.DataSource = pb.loadDGVTheoMa(txtTK_PB.Text);
        }

        private void simpleButtonThem_PB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm phòng ban?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (pb.themPB(pb.taoMaTD(), txtTen_PB.Text, txtTruongPhong_PB.Text) == 1)
                {
                    MessageBox.Show("Thêm thành công!");
                    dataGridViewPHONGBAN.DataSource = pb.loadDGVDSPB();
                    txtMa_PB.Text = "";
                    txtTen_PB.Text = "";
                    txtTruongPhong_PB.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                    dataGridViewPHONGBAN.DataSource = pb.loadDGVDSPB();
                }
            }
        }

        private void simpleButtonSua_PB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn sửa phòng ban?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (pb.suaPB(txtTen_PB.Text, txtTruongPhong_PB.Text, txtMa_PB.Text) == 1)
                {
                    MessageBox.Show("Sửa thành công!");
                    dataGridViewPHONGBAN.DataSource = pb.loadDGVDSPB();
                    txtMa_PB.Text = "";
                    txtTen_PB.Text = "";
                    txtTruongPhong_PB.Text = "";
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                    dataGridViewPHONGBAN.DataSource = pb.loadDGVDSPB();
                }
            }
        }

        private void simpleButtonXoa_PB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa phòng ban?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (pb.xoaPB(dataGridViewPHONGBAN.CurrentRow.Cells[0].Value.ToString()) == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    dataGridViewPHONGBAN.DataSource = pb.loadDGVDSPB();
                    txtMa_PB.Text = "";
                    txtTen_PB.Text = "";
                    txtTruongPhong_PB.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                    dataGridViewPHONGBAN.DataSource = pb.loadDGVDSPB();
                }
            }
        }

        private void simpleButtonClear_PB_Click(object sender, EventArgs e)
        {
            txtMa_PB.Text = "";
            txtTen_PB.Text = "";
            txtTruongPhong_PB.Text = "";
        }

    }
}