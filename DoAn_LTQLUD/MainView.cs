﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAn_LTQLUD
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }
        private bool checkactiveform(Form frm)
        {
            foreach(var childfrm in MdiChildren)
            {
                if(childfrm.Name == frm.Name)
                {
                    childfrm.Activate();
                    return true;
                }
            }
            return false;
        }
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formKhuVuc frm = new formKhuVuc();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoHang frm = new frmKhoHang();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDonViTinh frm = new frmDonViTinh();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhomHang frm = new frmNhomHang();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHangHoa frm = new frmHangHoa();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTyGia frm = new frmTyGia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBoPhan frm = new frmBoPhan();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMuaHang frm = new frmMuaHang();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MainView frm = new MainView();
            this.Close();
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formPhanQuyen frm = new formPhanQuyen();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhatKyHeThong frm = new frmNhatKyHeThong();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLienHe frm = new frmLienHe();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.Show();
        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTin frm = new frmThongTin();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.Show();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process tv = new Process();
            tv.StartInfo.FileName = @"C:\Program Files (x86)\TeamViewer\TeamViewer.exe";
            //tv.StartInfo.Arguments = "ProcessStart.cs"; // if you need some
            tv.Start();
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://perfect.com.vn/huong-dan-su-dung-phan-mem-quan-ly-ban-hang.html");
        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=wBcm3q5-NdA");}

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTonKho frm = new frmTonKho();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();

        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChuyenKho frm = new frmChuyenKho();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSoDuDauKy frm = new frmSoDuDauKy();
            if (checkactiveform(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSaoLuu frm = new frmSaoLuu();
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhucHoi frm = new frmPhucHoi();
            frm.Show();
        }
    }
}
