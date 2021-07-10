using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserENT
/// </summary>

namespace KhodiyarKitchenware.ENT
{
	public class UserENT
	{
	
	#region Constructor 
	public UserENT()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	#endregion Constructor
	
	#region UserId

	protected SqlInt32 _UserId;

	public SqlInt32 UserId
	{
		get
		{
			return _UserId;
		}		
		set
		{
			_UserId= value;
		}
	}

	#endregion UserId

	#region UserName

	protected SqlString _UserName;

	public SqlString UserName
	{
		get
		{
			return _UserName;
		}		
		set
		{
			_UserName= value;
		}
	}

	#endregion UserName

	#region Password

	protected SqlString _Password;

	public SqlString Password
	{
		get
		{
			return _Password;
		}		
		set
		{
			_Password= value;
		}
	}

		#endregion Password

		#region isAdmin

		protected SqlBoolean _isAdmin;

		public SqlBoolean isAdmin
		{
			get
			{
				return _isAdmin;
			}
			set
			{
				_isAdmin = value;
			}
		}

		#endregion isAdmin


		#region DisplayName

		protected SqlString _DisplayName;

	public SqlString DisplayName
	{
		get
		{
			return _DisplayName;
		}		
		set
		{
			_DisplayName= value;
		}
	}

	#endregion DisplayName

	#region MobileNo

	protected SqlString _MobileNo;

	public SqlString MobileNo
	{
		get
		{
			return _MobileNo;
		}		
		set
		{
			_MobileNo= value;
		}
	}

	#endregion MobileNo

	}
}
