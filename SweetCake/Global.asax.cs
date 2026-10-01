using SweetCake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace SweetCake
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            List<SanPhamBanh> danhSachSanPham = new List<SanPhamBanh>();
            SanPhamBanh banh1 = new SanPhamBanh()
            {
                maBanh = "1",
                tenBanh = "Bánh Xoài Dừa",
                giaBanh = 100000m,
                anhBanh = "YOGURT-1.png",
                moTa = "Bánh bông lan vani kem tươi và mứt trái cây\r\n\r\n                Nhân bánh mềm xốp được bao quanh bởi một lớp kem tươi, phủ lên trên mặt bánh là lớp cốt dừa sánh mịn và mứt xoài chua ngọt",
                loaiBanh = "Bánh Mousse"
            };
            SanPhamBanh banh2 = new SanPhamBanh()
            {
                maBanh = "2",
                tenBanh = "Bánh Xoài",
                giaBanh = 120000m,
                anhBanh = "FRESH-MANGO.png",
                moTa = "Bánh bông lan vani kem tươi và mứt trái cây\r\n\r\n                Nhân bánh mềm xốp được bao quanh bởi một lớp kem tươi, phủ lên trên mặt bánh là lớp cốt dừa sánh mịn và mứt xoài chua ngọt",
                loaiBanh = "Bánh Sinh nhật"
            };
            danhSachSanPham.Add(banh1);
            danhSachSanPham.Add(banh2);
            Application["DanhSachSanPham"] = danhSachSanPham;

        }
    }
}