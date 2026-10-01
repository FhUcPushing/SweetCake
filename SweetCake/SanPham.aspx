<%@ Page Title="Sản phẩm"
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="SanPham.aspx.cs"
    Inherits="SweetCake.SanPham" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="MainContent"
    runat="server">

    <div class="container product-page">

        <section>
            <h1>Sản phẩm</h1>
            <p>Khám phá các loại bánh của SweetCake</p>
            <img src="product-banner.png" alt="ảnh banner sản phẩm"/>
        </section>
        <section>
            <h2>Loại bánh</h2>
            <ul>
                <li id="tat_ca_loai_banh"><a href="#">Tất cả</a></li>
                <li id="banh_kem"><a href="#">Bánh kem</a></li>
                <li id="banh_mousse"><a href="#">Bánh mousse</a></li>
                <li id="banh_sinh_nhat"><a href="#">Bánh sinh nhật</a></li>
            </ul>
        </section>
        <section>
            <label>Xem</label>
            <select>
                <option>6</option>
                <option>9</option>
                <option>12</option>
                <option>All</option>
            </select>
            <label>Sắp xếp theo: </label>
            <select>
                <option>Mới nhất</option>
                <option>Cũ nhất</option>
            </select>
        </section>
        <section>
            <h2>Danh sách bánh</h2>
            <div id="danhSachBanh" runat="server">
            </div>
        </section>
        <section>
            <button>1</button>
            <button>2</button>
            <button>></button>
        </section>
    </div>

</asp:Content>