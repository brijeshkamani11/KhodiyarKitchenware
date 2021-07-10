using KhodiyarKitchenware.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductsDAL
/// </summary>

namespace KhodiyarKitchenware.DAL
{
	public class ProductsDAL : DatabaseConfig
	{
	
		#region Constructor 
		public ProductsDAL()
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
		public Boolean Insert(ProductsENT entProducts)
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
						objCmd.CommandText = "PR_Products_Insert";
						objCmd.Parameters.Add("@ProductId", SqlDbType.Int).Direction = ParameterDirection.Output;
						objCmd.Parameters.AddWithValue("@ProductName", SqlDbType.VarChar).Value = entProducts.ProductName;
						objCmd.Parameters.AddWithValue("@ShortDescription", SqlDbType.VarChar).Value = entProducts.ShortDescription;
						objCmd.Parameters.AddWithValue("@Description", SqlDbType.VarChar).Value = entProducts.Description;
						objCmd.Parameters.AddWithValue("@ProviderId", SqlDbType.Int).Value = entProducts.ProviderId;
						objCmd.Parameters.AddWithValue("@Price", SqlDbType.Decimal).Value = entProducts.Price;
						objCmd.Parameters.AddWithValue("@Stock", SqlDbType.Int).Value = entProducts.Stock;
						objCmd.Parameters.AddWithValue("@ProductCategoryId", SqlDbType.Int).Value = entProducts.ProductCategoryId;
						objCmd.Parameters.AddWithValue("@ImageURL", SqlDbType.VarChar).Value = entProducts.ImageURL;
						objCmd.Parameters.AddWithValue("@ProductCreatedDate", SqlDbType.DateTime).Value = entProducts.ProductCreatedDate;
						objCmd.Parameters.AddWithValue("@ProductModifiedDate", SqlDbType.DateTime).Value = entProducts.ProductModifiedDate;
						#endregion Prepare Command

						objCmd.ExecuteNonQuery();

						if (objCmd.Parameters["@ProductId"] != null)
							entProducts.ProductId = Convert.ToInt32(objCmd.Parameters["@ProductId"].Value);

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
		public Boolean Delete(SqlInt32 ProductId)
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
						objCmd.CommandText = "PR_Products_DeleteByPK";
						objCmd.Parameters.AddWithValue("@ProductId", ProductId);
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
		public Boolean Update(ProductsENT entProducts)
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
						objCmd.CommandText = "PR_Products_UpdateByPK";
						objCmd.Parameters.AddWithValue("@ProductId", entProducts.ProductId);
						objCmd.Parameters.AddWithValue("@ProductName", entProducts.ProductName);
						objCmd.Parameters.AddWithValue("@ShortDescription", entProducts.ShortDescription);
						objCmd.Parameters.AddWithValue("@Description", entProducts.Description);
						objCmd.Parameters.AddWithValue("@ProviderId", entProducts.ProviderId);
						objCmd.Parameters.AddWithValue("@Price", entProducts.Price);
						objCmd.Parameters.AddWithValue("@Stock", entProducts.Stock);
						objCmd.Parameters.AddWithValue("@ProductCategoryId", entProducts.ProductCategoryId);
						objCmd.Parameters.AddWithValue("@ImageURL", entProducts.ImageURL);
						objCmd.Parameters.AddWithValue("@ProductCreatedDate", entProducts.ProductCreatedDate);
						objCmd.Parameters.AddWithValue("@ProductModifiedDate", entProducts.ProductModifiedDate);
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
						objCmd.CommandText = "PR_Products_SelectAll";
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
						objCmd.CommandText = "PR_Products_SelectForDropDownList";
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
		public ProductsENT SelectByPK(SqlInt32 ProductId)
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
						objCmd.CommandText = "PR_Products_SelectByPK";
						objCmd.Parameters.AddWithValue("@ProductId",ProductId);
						#endregion Prepare Command

						#region ReadData and Set Controls
						ProductsENT entProducts = new ProductsENT();
						using(SqlDataReader objSDR = objCmd.ExecuteReader())
						{
							while (objSDR.Read())
							{
								if (!objSDR["ProductId"].Equals(DBNull.Value))
								{
									entProducts.ProductId = Convert.ToInt32(objSDR["ProductId"]);
								}
								if (!objSDR["ProductName"].Equals(DBNull.Value))
								{
									entProducts.ProductName = Convert.ToString(objSDR["ProductName"]);
								}
								if (!objSDR["ShortDescription"].Equals(DBNull.Value))
								{
									entProducts.ShortDescription = Convert.ToString(objSDR["ShortDescription"]);
								}
								if (!objSDR["Description"].Equals(DBNull.Value))
								{
									entProducts.Description = Convert.ToString(objSDR["Description"]);
								}
								if (!objSDR["ProviderId"].Equals(DBNull.Value))
								{
									entProducts.ProviderId = Convert.ToInt32(objSDR["ProviderId"]);
								}
								if (!objSDR["Price"].Equals(DBNull.Value))
								{
									entProducts.Price = Convert.ToDecimal(objSDR["Price"]);
								}
								if (!objSDR["Stock"].Equals(DBNull.Value))
								{
									entProducts.Stock = Convert.ToInt32(objSDR["Stock"]);
								}
								if (!objSDR["ProductCategoryId"].Equals(DBNull.Value))
								{
									entProducts.ProductCategoryId = Convert.ToInt32(objSDR["ProductCategoryId"]);
								}
								if (!objSDR["ImageURL"].Equals(DBNull.Value))
								{
									entProducts.ImageURL = Convert.ToString(objSDR["ImageURL"]);
								}
								if (!objSDR["ProductCreatedDate"].Equals(DBNull.Value))
								{
									entProducts.ProductCreatedDate = Convert.ToDateTime(objSDR["ProductCreatedDate"]);
								}
								if (!objSDR["ProductModifiedDate"].Equals(DBNull.Value))
								{
									entProducts.ProductModifiedDate = Convert.ToDateTime(objSDR["ProductModifiedDate"]);
								}
							}
						}

						return entProducts;
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