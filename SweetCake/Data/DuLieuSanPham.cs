using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SweetCake.Models;

namespace SweetCake.Data

{
    public class DuLieuSanPham
    {
        public List<SanPhamBanh> sanPhams = new List<SanPhamBanh>();
        public DuLieuSanPham (){
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
        sanPhams.Add(banh1);
        sanPhams.Add(banh2);
        }
}
}