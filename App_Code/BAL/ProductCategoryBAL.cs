using KhodiyarKitchenware.ENT;
using KhodiyarKitchenware.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductCategoryBAL
/// </summary>

namespace KhodiyarKitchenware.BAL
{
	public class ProductCategoryBAL
	{
	
		#region Constructor
		public ProductCategoryBAL()
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
		public Boolean Insert(ProductCategoryENT entProductCategory)
		{
			ProductCategoryDAL dalProductCategory = new ProductCategoryDAL();
			if (dalProductCategory.Insert(entProductCategory))
			{
				return true;
			}
			else
			{
				Message = dalProductCategory.Message;
				return false;
			}
		}
		#endregion Insert Operation

		#region Update Operation
		public Boolean Update(ProductCategoryENT entProductCategory)
		{
			ProductCategoryDAL dalProductCategory = new ProductCategoryDAL();
			if (dalProductCategory.Update(entProductCategory))
			{
				return true;
			}
			else
			{
				Message = dalProductCategory.Message;
				return false;
			}
		}
		#endregion Update Operation

		#region Delete Operation
		public Boolean Delete(SqlInt32 ProductCategoryId)
		{
			ProductCategoryDAL dalProductCategory = new ProductCategoryDAL();
			if (dalProductCategory.Delete(ProductCategoryId))
			{
				return true;
			}
			else
			{
				Message = dalProductCategory.Message;
				return false;
			}
		}
		#endregion Delete Operation

		#region Select Operation

		#region Select All
		public DataTable SelectAll()
		{
			ProductCategoryDAL dalProductCategory = new ProductCategoryDAL();
			return dalProductCategory.SelectAll();
		}
		#endregion Select All

		#region SelectForDropdownList
		public DataTable SelectForDropdownList()
		{
			ProductCategoryDAL dalProductCategory = new ProductCategoryDAL();
			return dalProductCategory.SelectForDropdownList();
		}
		#endregion SelectForDropdownList

		#region SelectByPK
		public ProductCategoryENT SelectByPK(SqlInt32 ProductCategoryId)
		{
			ProductCategoryDAL dalProductCategory = new ProductCategoryDAL();
			return dalProductCategory.SelectByPK(ProductCategoryId);
		}
		#endregion SelectByPK

		#endregion Select Operation
	}
}