using KhodiyarKitchenware.ENT;
using KhodiyarKitchenware.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserBAL
/// </summary>

namespace KhodiyarKitchenware.BAL
{
	public class UserBAL
	{
	
		#region Constructor
		public UserBAL()
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
		public Boolean Insert(UserENT entUser)
		{
			UserDAL dalUser = new UserDAL();
			if (dalUser.Insert(entUser))
			{
				return true;
			}
			else
			{
				Message = dalUser.Message;
				return false;
			}
		}
		#endregion Insert Operation

		#region Update Operation
		public Boolean Update(UserENT entUser)
		{
			UserDAL dalUser = new UserDAL();
			if (dalUser.Update(entUser))
			{
				return true;
			}
			else
			{
				Message = dalUser.Message;
				return false;
			}
		}
		#endregion Update Operation

		#region Delete Operation
		public Boolean Delete(SqlInt32 UserId)
		{
			UserDAL dalUser = new UserDAL();
			if (dalUser.Delete(UserId))
			{
				return true;
			}
			else
			{
				Message = dalUser.Message;
				return false;
			}
		}
		#endregion Delete Operation

		#region Select Operation

		#region Select All
		public DataTable SelectAll()
		{
			UserDAL dalUser = new UserDAL();
			return dalUser.SelectAll();
		}
		#endregion Select All

		#region SelectForDropdownList
		public DataTable SelectForDropdownList()
		{
			UserDAL dalUser = new UserDAL();
			return dalUser.SelectForDropdownList();
		}
		#endregion SelectForDropdownList

		#region SelectByPK
		public UserENT SelectByPK(SqlInt32 UserId)
		{
			UserDAL dalUser = new UserDAL();
			return dalUser.SelectByPK(UserId);
		}
		#endregion SelectByPK

		#endregion Select Operation
	}
}