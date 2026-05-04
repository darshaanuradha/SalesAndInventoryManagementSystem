using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IMS.AppLogic
{
    internal class InventoryService
    {
        public DataTable GetCategories()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT CategoryID, CategoryName FROM Categories";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        return dt;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
        }

        public DataTable GetProducts()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT p.ProductID, c.CategoryName, p.ProductName,
                                 p.UnitPrice, p.UnitsInStock, p.ReorderLevel
                                 FROM Products p
                                 INNER JOIN Categories c ON p.CategoryID = c.CategoryID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        return dt;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
        }

        public bool InsertProduct(int categoryId, string productName, decimal unitPrice, int unitsInStock, int reorderLevel)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO Products 
                                (CategoryID, ProductName, UnitPrice, UnitsInStock, ReorderLevel)
                                VALUES 
                                (@CategoryID, @ProductName, @UnitPrice, @UnitsInStock, @ReorderLevel)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // ✅ Strongly typed parameters (best practice)
                    cmd.Parameters.Add("@CategoryID", SqlDbType.Int).Value = categoryId;
                    cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = productName;
                    cmd.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = unitPrice;
                    cmd.Parameters.Add("@UnitsInStock", SqlDbType.Int).Value = unitsInStock;
                    cmd.Parameters.Add("@ReorderLevel", SqlDbType.Int).Value = reorderLevel;

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0; // success
                    }
                    catch (Exception)
                    {
                        // log error if needed
                        return false;
                    }
                }
            }
        }

        public bool UpdateProduct(int productId, int categoryId, string productName, decimal unitPrice, int unitsInStock, int reorderLevel)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE Products SET 
                            CategoryID = @CategoryID,
                            ProductName = @ProductName,
                            UnitPrice = @UnitPrice,
                            UnitsInStock = @UnitsInStock,
                            ReorderLevel = @ReorderLevel
                         WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = productId;
                    cmd.Parameters.Add("@CategoryID", SqlDbType.Int).Value = categoryId;
                    cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = productName;

                    var priceParam = cmd.Parameters.Add("@UnitPrice", SqlDbType.Decimal);
                    priceParam.Value = unitPrice;
                    priceParam.Precision = 10;
                    priceParam.Scale = 2;

                    cmd.Parameters.Add("@UnitsInStock", SqlDbType.Int).Value = unitsInStock;
                    cmd.Parameters.Add("@ReorderLevel", SqlDbType.Int).Value = reorderLevel;

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0; 
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }

        public bool DeleteProduct(int productId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = productId;

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }
    }
}
