using KhodiyarKitchenware.ENT;
using KhodiyarKitchenware.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductsBAL
/// </summary>

namespace KhodiyarKitchenware.BAL
{
	public class ProductsBAL
	{
	
		#region Constructor
		public ProductsBAL()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#endregion Constructor

		#region Local Variable

		protected string _Message;

		public string Message
		{
			get
			{
				return _Message;
			}
			set
			{
				 _Message = value;
			}
		}
		#endregion Local Variable

		#region Insert Operation
		public Boolean Insert(ProductsENT entProducts)
		{
			ProductsDAL dalProducts = new ProductsDAL();
			if (dalProducts.Insert(entProducts))
			{
				return true;
			}
			else
			{
				Message = dalProducts.Message;
				return false;
			}
		}
		#endregion Insert Operation

		#region Update Operation
		public Boolean Update(ProductsENT entProducts)
		{
			ProductsDAL dalProducts = new ProductsDAL();
			if (dalProducts.Update(entProducts))
			{
				return true;
			}
			else
			{
				Message = dalProducts.Message;
				return false;
			}
		}
		#endregion Update Operation

		#region Delete Operation
		public Boolean Delete(SqlInt32 ProductId)
		{
			ProductsDAL dalProducts = new ProductsDAL();
			if (dalProducts.Delete(ProductId))
			{
				return true;
			}
			else
			{
				Message = dalProducts.Message;
				return false;
			}
		}
		#endregion Delete Operation

		#region Select Operation

		#region Select All
		public DataTable SelectAll()
		{
			ProductsDAL dalProducts = new ProductsDAL();
			return dalProducts.SelectAll();
		}
		#endregion Select All

		#region SelectForDropdownList
		public DataTable SelectForDropdownList()
		{
			ProductsDAL dalProducts = new ProductsDAL();
			return dalProducts.SelectForDropdownList();
		}
		#endregion SelectForDropdownList

		#region SelectByPK
		public ProductsENT SelectByPK(SqlInt32 ProductId)
		{
			ProductsDAL dalProducts = new ProductsDAL();
			return dalProducts.SelectByPK(ProductId);
		}
		#endregion SelectByPK

		#endregion Select Operation
	}
}