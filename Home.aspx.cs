using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KhodiyarKitchenware
{
    public partial class Defualt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["KhodiyarKitchenwareConnectionString"].ConnectionString.ToString());
            try
            {
                cnn.Open();
            }
            catch (Exception ex) { }
            finally
            {
                cnn.Close();
            }
        }
    }
}