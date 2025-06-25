using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanDoTheThao.Models
{
    public class ItemGioHang
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public float GiamGia { get; set; }
        public string HinhAnh { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }

        public ItemGioHang(int maSP)
        {
            using (WebBanDoTheThaoEntities db = new WebBanDoTheThaoEntities())
            {
                sanpham sp = db.sanphams.Single(n => n.MaSanPham == maSP);
                MaSP = maSP;
                TenSP = sp.TenSanPham;
                SoLuong = 1;
                HinhAnh = sp.HinhAnh1;
                DonGia = sp.DonGia;
                GiamGia = GiamGia;
                //ThanhTien = SoLuong * (DonGia - (DonGia * Convert.ToDecimal(GiamGia)));

            }
        }
        public ItemGioHang(int maSP,int sl)
        {
            using (WebBanDoTheThaoEntities db = new WebBanDoTheThaoEntities())
            {
                sanpham sp = db.sanphams.Single(n => n.MaSanPham == maSP);
                MaSP = maSP;
                TenSP = sp.TenSanPham;
                SoLuong = sl;
                HinhAnh = sp.HinhAnh1;
                DonGia = sp.DonGia;
                GiamGia = GiamGia;
                //ThanhTien = SoLuong * (DonGia - (DonGia *Convert.ToDecimal( GiamGia)));
            }
        }
        public ItemGioHang()
        {

        }
    }
}