using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SweetCake.Models;
using System.Web.UI.HtmlControls;

namespace SweetCake
{
    public partial class SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<SanPhamBanh> danhSachSanPhamBanh = (List<SanPhamBanh>)Application["DanhSachSanPham"]; ;
            foreach(SanPhamBanh x in danhSachSanPhamBanh)
            {
                HtmlGenericControl newDiv = new HtmlGenericControl("div");
                newDiv.Attributes["class"] = "the_san_pham"; 

                HtmlGenericControl newImg = new HtmlGenericControl("img");
                newImg.Attributes["src"] = x.anhBanh;
                newDiv.Controls.Add(newImg);

                HtmlGenericControl newP1 = new HtmlGenericControl("p");
                newP1.InnerText = x.tenBanh;
                newDiv.Controls.Add(newP1);

                HtmlGenericControl newP2 = new HtmlGenericControl ("p");
                newP2.InnerText = x.giaBanh.ToString("N0") +"đ";
                newDiv.Controls.Add(newP2);

                HtmlGenericControl newA =  new HtmlGenericControl("a");
                newA.Attributes["href"] = "ChiTietSanPham.aspx?id=" +x.maBanh;
                newA.InnerText = "Xem bánh";
                newDiv.Controls.Add(newA);

                danhSachBanh.Controls.Add(newDiv);
            }
    }
}
}