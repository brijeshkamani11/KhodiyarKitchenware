using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProviderENT
/// </summary>

namespace KhodiyarKitchenware.ENT
{
	public class ProviderENT
	{
	
	#region Constructor 
	public ProviderENT()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	#endregion Constructor
	
	#region ProviderId

	protected SqlInt32 _ProviderId;

	public SqlInt32 ProviderId
	{
		get
		{
			return _ProviderId;
		}		
		set
		{
			_ProviderId= value;
		}
	}

	#endregion ProviderId

	#region ProviderName

	protected SqlString _ProviderName;

	public SqlString ProviderName
	{
		get
		{
			return _ProviderName;
		}		
		set
		{
			_ProviderName= value;
		}
	}

	#endregion ProviderName

	#region Address

	protected SqlString _Address;

	public SqlString Address
	{
		get
		{
			return _Address;
		}		
		set
		{
			_Address= value;
		}
	}

	#endregion Address

	#region ContactNo

	protected SqlString _ContactNo;

	public SqlString ContactNo
	{
		get
		{
			return _ContactNo;
		}		
		set
		{
			_ContactNo= value;
		}
	}

	#endregion ContactNo

	}
}
