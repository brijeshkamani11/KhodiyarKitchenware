using KhodiyarKitchenware.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProviderDAL
/// </summary>

namespace KhodiyarKitchenware.DAL
{
	public class ProviderDAL : DatabaseConfig
	{
	
		#region Constructor 
		public ProviderDAL()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#endregion Constructor
		
		#region Local Variables
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
		#endregion Local Variables

		#region Insert Operation
		public Boolean Insert(ProviderENT entProvider)
		{
			using (SqlConnection objConn = new SqlConnection(ConnectionString))
			{
				objConn.Open();
				using (SqlCommand objCmd = objConn.CreateCommand())
				{
					try
					{
						#region Prepare Command
						objCmd.CommandType = CommandType.StoredProcedure;
						objCmd.CommandText = "PR_Provider_Insert";
						objCmd.Parameters.Add("@ProviderId", SqlDbType.Int).Direction = ParameterDirection.Output;
						objCmd.Parameters.AddWithValue("@ProviderName", SqlDbType.VarChar).Value = entProvider.ProviderName;
						objCmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = entProvider.Address;
						objCmd.Parameters.AddWithValue("@ContactNo", SqlDbType.VarChar).Value = entProvider.ContactNo;
						#endregion Prepare Command

						objCmd.ExecuteNonQuery();

						if (objCmd.Parameters["@ProviderId"] != null)
							entProvider.ProviderId = Convert.ToInt32(objCmd.Parameters["@ProviderId"].Value);

						return true;
					}
					catch (SqlException sqlex)
					{
						Message = sqlex.Message.ToString();
						return false;
					}
					catch (Exception ex)
					{
						Message = ex.Message.ToString();
						return false;
					}
					finally
					{
						if (objConn.State == ConnectionState.Open)
							objConn.Close();
					}
				}
			}
		}
		#endregion Insert Operation

		#region Delete Operation
		public Boolean Delete(SqlInt32 ProviderId)
		{
			using (SqlConnection objConn = new SqlConnection(ConnectionString))
			{
				objConn.Open();
				using (SqlCommand objCmd = objConn.CreateCommand())
				{
					try
					{
						#region Prepare Command
						objCmd.CommandType = CommandType.StoredProcedure;
						objCmd.CommandText = "PR_Provider_DeleteByPK";
						objCmd.Parameters.AddWithValue("@ProviderId", ProviderId);
						#endregion Prepare Command

						objCmd.ExecuteNonQuery();

						return true;
					}
					catch (SqlException sqlex)
					{
						Message = sqlex.Message.ToString();
						return false;
					}
					catch (Exception ex)
					{
						Message = ex.Message.ToString();
						return false;
					}
					finally
					{
						if (objConn.State == ConnectionState.Open)
							objConn.Close();
					}
				}
			}
		}
		#endregion Delete Operation

		#region Update Operation
		public Boolean Update(ProviderENT entProvider)
		{
			using (SqlConnection objConn = new SqlConnection(ConnectionString))
			{
				objConn.Open();
				using (SqlCommand objCmd = objConn.CreateCommand())
				{
					try
					{
						#region Prepare Command
						objCmd.CommandType = CommandType.StoredProcedure;
						objCmd.CommandText = "PR_Provider_UpdateByPK";
						objCmd.Parameters.AddWithValue("@ProviderId", entProvider.ProviderId);
						objCmd.Parameters.AddWithValue("@ProviderName", entProvider.ProviderName);
						objCmd.Parameters.AddWithValue("@Address", entProvider.Address);
						objCmd.Parameters.AddWithValue("@ContactNo", entProvider.ContactNo);
						#endregion Prepare Command

						objCmd.ExecuteNonQuery();

						return true;
					}
					catch (SqlException sqlex)
					{
						Message = sqlex.Message.ToString();
						return false;
					}
					catch (Exception ex)
					{
						Message = ex.Message.ToString();
						return false;
					}
					finally
					{
						if (objConn.State == ConnectionState.Open)
							objConn.Close();
					}
				}
			}
		}
		#endregion Update Operation
		#region Select Operation


		#region SelectAll
		public DataTable SelectAll()
		{
			using (SqlConnection objConn = new SqlConnection(ConnectionString))
			{
				objConn.Open();
				using (SqlCommand objCmd = objConn.CreateCommand())
				{
					try
					{
						#region Prepare Command
						objCmd.CommandType = CommandType.StoredProcedure;
						objCmd.CommandText = "PR_Provider_SelectAll";
						#endregion Prepare Command

						#region ReadData and Set Controls
						DataTable dt = new DataTable();
						using (SqlDataReader objSDR = objCmd.ExecuteReader())
						{
							dt.Load(objSDR);
						}
						return dt;
						#endregion ReadData and Set Controls
					}
					catch (SqlException sqlex)
					{
						Message = sqlex.Message.ToString();
						return null;
					}
					catch (Exception ex)
					{
						Message = ex.Message.ToString();
						return null;
					}
					finally
					{
						if (objConn.State == ConnectionState.Open)
							objConn.Close();
					}
				}
			}
		}
		#endregion SelectAll

		#region SelectForDropdown
		public DataTable SelectForDropdownList()
		{
			using (SqlConnection objConn = new SqlConnection(ConnectionString))
			{
				objConn.Open();
				using (SqlCommand objCmd = objConn.CreateCommand())
				{
					try
					{
						#region Prepare Command
						objCmd.CommandType = CommandType.StoredProcedure;
						objCmd.CommandText = "PR_Provider_SelectForDropDownList";
						#endregion Prepare Command

						#region ReadData and Set Controls
						DataTable dt = new DataTable();
						using (SqlDataReader objSDR = objCmd.ExecuteReader())
						{
							dt.Load(objSDR);
						}
						return dt;
						#endregion ReadData and Set Controls
					}
					catch (SqlException sqlex)
					{
						Message = sqlex.Message.ToString();
						return null;
					}
					catch (Exception ex)
					{
						Message = ex.Message.ToString();
						return null;
					}
					finally
					{
						if (objConn.State == ConnectionState.Open)
							objConn.Close();
					}
				}
			}
		}
		#endregion SelectForDropdown

		#region SelectBYPK
		public ProviderENT SelectByPK(SqlInt32 ProviderId)
		{
			using (SqlConnection objConn = new SqlConnection(ConnectionString))
			{
				objConn.Open();
				using (SqlCommand objCmd = objConn.CreateCommand())
				{
					try
					{
						#region Prepare Command
						objCmd.CommandType = CommandType.StoredProcedure;
						objCmd.CommandText = "PR_Provider_SelectByPK";
						objCmd.Parameters.AddWithValue("@ProviderId",ProviderId);
						#endregion Prepare Command

						#region ReadData and Set Controls
						ProviderENT entProvider = new ProviderENT();
						using(SqlDataReader objSDR = objCmd.ExecuteReader())
						{
							while (objSDR.Read())
							{
								if (!objSDR["ProviderId"].Equals(DBNull.Value))
								{
									entProvider.ProviderId = Convert.ToInt32(objSDR["ProviderId"]);
								}
								if (!objSDR["ProviderName"].Equals(DBNull.Value))
								{
									entProvider.ProviderName = Convert.ToString(objSDR["ProviderName"]);
								}
								if (!objSDR["Address"].Equals(DBNull.Value))
								{
									entProvider.Address = Convert.ToString(objSDR["Address"]);
								}
								if (!objSDR["ContactNo"].Equals(DBNull.Value))
								{
									entProvider.ContactNo = Convert.ToString(objSDR["ContactNo"]);
								}
							}
						}

						return entProvider;
						#endregion ReadData and Set Controls
					}
					catch (SqlException sqlex)
					{
						Message = sqlex.Message.ToString();
						return null;
					}
					catch (Exception ex)
					{
						Message = ex.Message.ToString();
						return null;
					}
					finally
					{
						if (objConn.State == ConnectionState.Open)
							objConn.Close();
					}
				}
			}
		}
		#endregion SelectBYPK
		#endregion Select Operation
	}
}