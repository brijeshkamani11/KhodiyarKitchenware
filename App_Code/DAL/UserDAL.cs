using KhodiyarKitchenware.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserDAL
/// </summary>

namespace KhodiyarKitchenware.DAL
{
	public class UserDAL : DatabaseConfig
	{
	
		#region Constructor 
		public UserDAL()
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
		public Boolean Insert(UserENT entUser)
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
						objCmd.CommandText = "PR_User_Insert";
						objCmd.Parameters.Add("@UserId", SqlDbType.Int).Direction = ParameterDirection.Output;
						objCmd.Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = entUser.UserName;
						objCmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = entUser.Password;
						objCmd.Parameters.AddWithValue("@DisplayName", SqlDbType.VarChar).Value = entUser.DisplayName;
						objCmd.Parameters.AddWithValue("@MobileNo", SqlDbType.VarChar).Value = entUser.MobileNo;
						#endregion Prepare Command

						objCmd.ExecuteNonQuery();

						if (objCmd.Parameters["@UserId"] != null)
							entUser.UserId = Convert.ToInt32(objCmd.Parameters["@UserId"].Value);

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
		public Boolean Delete(SqlInt32 UserId)
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
						objCmd.CommandText = "PR_User_DeleteByPK";
						objCmd.Parameters.AddWithValue("@UserId", UserId);
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
		public Boolean Update(UserENT entUser)
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
						objCmd.CommandText = "PR_User_UpdateByPK";
						objCmd.Parameters.AddWithValue("@UserId", entUser.UserId);
						objCmd.Parameters.AddWithValue("@UserName", entUser.UserName);
						objCmd.Parameters.AddWithValue("@Password", entUser.Password);
						objCmd.Parameters.AddWithValue("@DisplayName", entUser.DisplayName);
						objCmd.Parameters.AddWithValue("@MobileNo", entUser.MobileNo);
						objCmd.Parameters.AddWithValue("@isAdmin", entUser.isAdmin);
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
						objCmd.CommandText = "PR_User_SelectAll";
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
						objCmd.CommandText = "PR_User_SelectForDropDownList";
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
		public UserENT SelectByPK(SqlInt32 UserId)
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
						objCmd.CommandText = "PR_User_SelectByPK";
						objCmd.Parameters.AddWithValue("@UserId",UserId);
						#endregion Prepare Command

						#region ReadData and Set Controls
						UserENT entUser = new UserENT();
						using(SqlDataReader objSDR = objCmd.ExecuteReader())
						{
							while (objSDR.Read())
							{
								if (!objSDR["UserId"].Equals(DBNull.Value))
								{
									entUser.UserId = Convert.ToInt32(objSDR["UserId"]);
								}
								if (!objSDR["UserName"].Equals(DBNull.Value))
								{
									entUser.UserName = Convert.ToString(objSDR["UserName"]);
								}
								if (!objSDR["Password"].Equals(DBNull.Value))
								{
									entUser.Password = Convert.ToString(objSDR["Password"]);
								}
								if (!objSDR["DisplayName"].Equals(DBNull.Value))
								{
									entUser.DisplayName = Convert.ToString(objSDR["DisplayName"]);
								}
								if (!objSDR["MobileNo"].Equals(DBNull.Value))
								{
									entUser.MobileNo = Convert.ToString(objSDR["MobileNo"]);
								}
							}
						}

						return entUser;
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