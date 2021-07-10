using KhodiyarKitchenware.ENT;
using KhodiyarKitchenware.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProviderBAL
/// </summary>

namespace KhodiyarKitchenware.BAL
{
	public class ProviderBAL
	{
	
		#region Constructor
		public ProviderBAL()
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
		public Boolean Insert(ProviderENT entProvider)
		{
			ProviderDAL dalProvider = new ProviderDAL();
			if (dalProvider.Insert(entProvider))
			{
				return true;
			}
			else
			{
				Message = dalProvider.Message;
				return false;
			}
		}
		#endregion Insert Operation

		#region Update Operation
		public Boolean Update(ProviderENT entProvider)
		{
			ProviderDAL dalProvider = new ProviderDAL();
			if (dalProvider.Update(entProvider))
			{
				return true;
			}
			else
			{
				Message = dalProvider.Message;
				return false;
			}
		}
		#endregion Update Operation

		#region Delete Operation
		public Boolean Delete(SqlInt32 ProviderId)
		{
			ProviderDAL dalProvider = new ProviderDAL();
			if (dalProvider.Delete(ProviderId))
			{
				return true;
			}
			else
			{
				Message = dalProvider.Message;
				return false;
			}
		}
		#endregion Delete Operation

		#region Select Operation

		#region Select All
		public DataTable SelectAll()
		{
			ProviderDAL dalProvider = new ProviderDAL();
			return dalProvider.SelectAll();
		}
		#endregion Select All

		#region SelectForDropdownList
		public DataTable SelectForDropdownList()
		{
			ProviderDAL dalProvider = new ProviderDAL();
			return dalProvider.SelectForDropdownList();
		}
		#endregion SelectForDropdownList

		#region SelectByPK
		public ProviderENT SelectByPK(SqlInt32 ProviderId)
		{
			ProviderDAL dalProvider = new ProviderDAL();
			return dalProvider.SelectByPK(ProviderId);
		}
		#endregion SelectByPK

		#endregion Select Operation
	}
}