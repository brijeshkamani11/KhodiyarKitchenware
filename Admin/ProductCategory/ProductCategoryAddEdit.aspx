<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.Master" AutoEventWireup="true" CodeBehind="ProductCategoryAddEdit.aspx.cs" Inherits="KhodiyarKitchenware.Admin.ProductCategory.ProductCategoryAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Product Categories
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <div class="container-fluid m-3">
            <asp:Label ID="lblError" CssClass="text-danger" runat="server" /><br />
            <h1>
                <asp:Label ID="lblHeading" runat="server" />
            </h1>

            <div class="row m-3">
                <div class="col-2">
                    Product Category Name
                </div>
                <div class="col-3">
                    <asp:TextBox ID="txtProductCategoryName" runat="server" /><br />
                    <asp:RequiredFieldValidator ID="rfvProductCategory" runat="server" ControlToValidate="txtProductCategoryName" Display="Dynamic" ErrorMessage="This Field is Required" CssClass="alert-danger" ValidationGroup="ValidateThis" />
                </div>
            </div>

            <div class="row  m-3">
                <div class="col-3 offset-2">
                    <asp:Button ID="btnSave" Text="Save" CssClass="btn-info" runat="server" OnClick="btnSave_Click" ValidationGroup="ValidateThis" />
                    <asp:Button ID="btnCancle" Text="Cancle" CssClass="btn-danger" runat="server" OnClick="btnCancle_Click" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>
