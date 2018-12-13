using System.Data;
using System.Data.SqlClient;

namespace DMHStockMasterV5
{
    class DeleteClass : UtilsClass
    {
        private bool DeleteFromDB;
        UtilsClass utilities = new UtilsClass();
        public bool DeleteStockMovements()
        {
            // Tested Date: ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };
                    sqlCommand.Parameters.AddWithValue("@StockCode", "");
                    sqlCommand.Parameters.AddWithValue("@SupplierRef", "");
                    sqlCommand.Parameters.AddWithValue("@Location", "");
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteWarehouse()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteShop()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteSupplier()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteStockCode()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeletePurchaseOrder()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeletePurchaseOrderLines()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteWHAdjustment()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteWHAdjustmentLines()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteShopDelivery()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteShopDeliveryLines()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteShopAdjustment()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteShopAdjustmentLines()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteShopTransfers()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteShopTransferLines()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteShopReturn()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteShopReturnLines()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteShopSale()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteShopSaleLines()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteVAT()
        {
            // Tested Date : ??/??/2018
            DeleteFromDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString()))
            {
                DeleteFromDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    DeleteFromDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    DeleteFromDB = false;
                    throw;
                }
            }
            return DeleteFromDB;
        }
    }
}
}
