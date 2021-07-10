using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataConfig
/// </summary>

namespace KhodiyarKitchenware
{
	public class DatabaseConfig
	{
	
		#region Constructor 
		public DatabaseConfig()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#endregion Constructor
		
		#region Connection String
		public static string ConnectionString = ConfigurationManager.ConnectionStrings["KhodiyarKitchenwareConnectionString"].ConnectionString.ToString();
		#endregion Connection String
	}
}