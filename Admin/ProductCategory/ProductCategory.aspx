<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.Master" AutoEventWireup="true" CodeBehind="ProductCategory.aspx.cs" Inherits="KhodiyarKitchenware.Admin.ProductCategory.ProductCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Product Categories
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" id="form1">
        <div style="text-align: center;">
        <h1>PRODUCT CATEGORY LIST</h1>

    </div>

    <div class="container">
        <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
        <div class="row">
            <div class="col-md-12 text-right" style="padding-bottom: 1%">

                <div class="row float-right">
                    <asp:HyperLink ID="hlAddProductCategory" runat="server" NavigateUrl="~/Admin/ProductCategory/ProductCategoryAddEdit.aspx" Text="Add New Product Category" CssClass="btn btn-info"></asp:HyperLink>
                </div>
                <br />
            </div>

            <div class="col-md-12">
                <asp:GridView ID="gvProductCategoryList" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered" OnRowCommand="gvProductCategoryList_RowCommand">
                    <Columns>

                        <asp:BoundField DataField="ProductCategoryID" HeaderText="ID " />
                        <asp:BoundField DataField="ProductCategoryName" HeaderText="Product Category" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" OnClientClick="return confirm('Are you sure you want to delete this Product Category?');" runat="server" Text="Delete" CssClass="btn btn-danger " CommandArgument='<%# Eval("ProductCategoryId") %>' />
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:HyperLink runat="server" ID="hlEdit" CssClass="btn btn-info" NavigateUrl='<%# "~/Admin/ProductCategory/ProductCategoryAddEdit.aspx?ProductCategoryId=" + Eval("ProductCategoryId")%>' Text="Edit"></asp:HyperLink>

                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                </asp:GridView>

            </div>
        </div>

    </div>

    </form>
</asp:Content>
