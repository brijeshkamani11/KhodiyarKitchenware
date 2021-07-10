using KhodiyarKitchenware.BAL;
using KhodiyarKitchenware.ENT;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KhodiyarKitchenware.Admin.ProductCategory
{
    public partial class ProductCategoryAddEdit : System.Web.UI.Page
    {
        #region Load Event
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Check Request
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["ProductCategoryId"] == null)
                    lblHeading.Text = "Add New Product Category";
                else
                {
                    lblHeading.Text = "Edit Product Category";
                    fillControls(Convert.ToInt32(Request.QueryString["ProductCategoryId"]));
                }
            }
            #endregion Check Request
        }
        #endregion Load Event

        #region fill controls
        private void fillControls(SqlInt32 ProductCategoryID)
        {
            ProductCategoryENT entProductCategory = new ProductCategoryENT();
            ProductCategoryBAL balProductCategory = new ProductCategoryBAL();

            entProductCategory = balProductCategory.SelectByPK(ProductCategoryID);
            if (entProductCategory != null)
            {
                if (!entProductCategory.ProductCategoryName.IsNull)
                    txtProductCategoryName.Text = entProductCategory.ProductCategoryName.Value.ToString();
            }
            else
                lblError.Text = balProductCategory.Message;


        }
        #endregion fill Controls

        #region Bytton : Save

        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Server Side Validation

            lblError.Text = "";
            if (txtProductCategoryName.Text.Trim().ToUpper() == "")
                lblError.Text += "Enter Product Category Name <br/>";

            if (lblError.Text != "")
                return;
            #endregion Server Side Validation

            #region Collecting Data
            ProductCategoryENT entProductCategory = new ProductCategoryENT();
            if (txtProductCategoryName.Text.Trim().ToUpper() != "")
            {
                entProductCategory.ProductCategoryName = txtProductCategoryName.Text.Trim().ToUpper();
            }
            ProductCategoryBAL balProductCategory = new ProductCategoryBAL();
            #endregion Collecting Data
            if (Request.QueryString["ProductCategoryId"] == null)
            {
                #region insertingData
                if (balProductCategory.Insert(entProductCategory))
                    Response.Redirect("~/Admin/ProductCategory/ProductCategory.aspx");
                else
                    lblError.Text = balProductCategory.Message;
                #endregion insertingData
            }
            else
            {
                #region updatingData
                entProductCategory.ProductCategoryId = Convert.ToInt32(Request.QueryString["ProductCategoryId"]);
                if (balProductCategory.Update(entProductCategory))
                    Response.Redirect("~/Admin/ProductCategory/ProductCategory.aspx");
                else
                    lblError.Text = balProductCategory.Message;
                #endregion updatingData
            }


        }
        #endregion Button : Save

        #region Button : Cancle
        protected void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ProductCategory/ProductCategory.aspx");
        }
        #endregion Button : Cancle
    }
}
