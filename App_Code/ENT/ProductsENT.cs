using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductsENT
/// </summary>

namespace KhodiyarKitchenware.ENT
{
	public class ProductsENT
	{
	
	#region Constructor 
	public ProductsENT()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	#endregion Constructor
	
	#region ProductId

	protected SqlInt32 _ProductId;

	public SqlInt32 ProductId
	{
		get
		{
			return _ProductId;
		}		
		set
		{
			_ProductId= value;
		}
	}

	#endregion ProductId

	#region ProductName

	protected SqlString _ProductName;

	public SqlString ProductName
	{
		get
		{
			return _ProductName;
		}		
		set
		{
			_ProductName= value;
		}
	}

	#endregion ProductName

	#region ShortDescription

	protected SqlString _ShortDescription;

	public SqlString ShortDescription
	{
		get
		{
			return _ShortDescription;
		}		
		set
		{
			_ShortDescription= value;
		}
	}

	#endregion ShortDescription

	#region Description

	protected SqlString _Description;

	public SqlString Description
	{
		get
		{
			return _Description;
		}		
		set
		{
			_Description= value;
		}
	}

	#endregion Description

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

	#region Price

	protected SqlDecimal _Price;

	public SqlDecimal Price
	{
		get
		{
			return _Price;
		}		
		set
		{
			_Price= value;
		}
	}

	#endregion Price

	#region Stock

	protected SqlInt32 _Stock;

	public SqlInt32 Stock
	{
		get
		{
			return _Stock;
		}		
		set
		{
			_Stock= value;
		}
	}

	#endregion Stock

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

	#region ImageURL

	protected SqlString _ImageURL;

	public SqlString ImageURL
	{
		get
		{
			return _ImageURL;
		}		
		set
		{
			_ImageURL= value;
		}
	}

	#endregion ImageURL

	#region ProductCreatedDate

	protected SqlDateTime _ProductCreatedDate;

	public SqlDateTime ProductCreatedDate
	{
		get
		{
			return _ProductCreatedDate;
		}		
		set
		{
			_ProductCreatedDate= value;
		}
	}

	#endregion ProductCreatedDate

	#region ProductModifiedDate

	protected SqlDateTime _ProductModifiedDate;

	public SqlDateTime ProductModifiedDate
	{
		get
		{
			return _ProductModifiedDate;
		}		
		set
		{
			_ProductModifiedDate= value;
		}
	}

	#endregion ProductModifiedDate

	}
}
