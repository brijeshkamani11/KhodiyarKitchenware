using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductCategoryENT
/// </summary>

namespace KhodiyarKitchenware.ENT
{
	public class ProductCategoryENT
	{
	
	#region Constructor 
	public ProductCategoryENT()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	#endregion Constructor
	
	#region ProductCategoryId

	protected SqlInt32 _ProductCategoryId;

	public SqlInt32 ProductCategoryId
	{
		get
		{
			return _ProductCategoryId;
		}		
		set
		{
			_ProductCategoryId= value;
		}
	}

	#endregion ProductCategoryId

	#region ProductCategoryName

	protected SqlString _ProductCategoryName;

	public SqlString ProductCategoryName
	{
		get
		{
			return _ProductCategoryName;
		}		
		set
		{
			_ProductCategoryName= value;
		}
	}

	#endregion ProductCategoryName

	}
}
