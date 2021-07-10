using KhodiyarKitchenware.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KhodiyarKitchenware.Admin.ProductCategory
{
    public partial class ProductCategory : System.Web.UI.Page
    {
        #region Load Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillGridViewProductCategory();
            }
        }
        #endregion Load Event

        #region Fill ProductCategory

        private void FillGridViewProductCategory()
        {
            ProductCategoryBAL balProductCategory = new ProductCategoryBAL();
            DataTable dtProductCategory = new DataTable();
            dtProductCategory = balProductCategory.SelectAll();
            if (dtProductCategory != null && dtProductCategory.Rows.Count > 0)
            {
                gvProductCategoryList.DataSource = dtProductCategory;
                gvProductCategoryList.DataBind();

            }

        }
        #endregion Fill ProductCategory

        #region Delete ProductCategory

        protected void gvProductCategoryList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandArgument != null)
            {
                ProductCategoryBAL balProductCategory = new ProductCategoryBAL();
                if (balProductCategory.Delete(Convert.ToInt32(e.CommandArgument.ToString().Trim())))
                {
                    Response.Redirect("~/Adminpanel/ProductCategory/ProductCategoryList.aspx");
                    lblError.Text = "";
                }
                else
                {
                    lblError.Text = balProductCategory.Message;
                }
            }
        }
        #endregion Delete ProductCategory
    }
}
