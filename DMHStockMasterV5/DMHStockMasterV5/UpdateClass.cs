using System.Data;
using System.Data.SqlClient;

namespace DMHStockMasterV5
{
    class UpdateClass:UtilsClass
    {
        UtilsClass utilities = new UtilsClass();
        private bool UpdateToDB;
        public bool UpdateWarehouse(string WarehouseRef, string WarehouseName, string Address1, string Address2, string Address3, string Address4, string PostCode, string ContactName, string Telephone, string Telephone2, string Fax, string eMail, string Memo, string WarehouseType)
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "UPDATE tblWarehouses SET WarehouseName = @WarehouseName,Address1=@Address1,Address2=@Address2,Address3=@Address3,Address4 = @Address4,PostCode = @PostCode,ContactName = @ContactName,Telephone = Telephone,Telephone2 = @Telephone2,Fax = @Fax,eMail = @eMail,Memo = @Memo,WarehouseType = @WarehouseType WHERE WarehouseRef = @WarehouseRef",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };
                    sqlCommand.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                    sqlCommand.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                    sqlCommand.Parameters.AddWithValue("@Address1", Address1);
                    sqlCommand.Parameters.AddWithValue("@Address2", Address2);
                    sqlCommand.Parameters.AddWithValue("@Address3", Address3);
                    sqlCommand.Parameters.AddWithValue("@Address4", Address4);
                    sqlCommand.Parameters.AddWithValue("@PostCode", PostCode);
                    sqlCommand.Parameters.AddWithValue("@ContactName", ContactName);
                    sqlCommand.Parameters.AddWithValue("@Telephone", Telephone);
                    sqlCommand.Parameters.AddWithValue("@Telephone2", Telephone2);
                    sqlCommand.Parameters.AddWithValue("@Fax", Fax);
                    sqlCommand.Parameters.AddWithValue("@eMail", eMail);
                    sqlCommand.Parameters.AddWithValue("@Memo", Memo);
                    sqlCommand.Parameters.AddWithValue("@WarehouseType", WarehouseType);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateShop(string ShopRef, string ShopName, string Address1, string Address2, string Address3, string Address4, string PostCode, string ContactName, string Telephone, string Telephone2, string Fax, string eMail, string Memo, string ShopType, bool VATPayable)
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "UPDATE tblShops SET ShopName = @ShopName,Street=@Street,Area=@Area,Town=@Town,County = @County,PostCode = @PostCode,ContactName = @ContactName,Telephone = Telephone,Telephone2 = @Telephone2,Fax = @Fax,eMail = @eMail,Memo = @Memo,ShopType = @ShopType,VATPayable=@VATPayable WHERE ShopRef = @ShopRef",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };
                    sqlCommand.Parameters.AddWithValue("@ShopRef", ShopRef);
                    sqlCommand.Parameters.AddWithValue("@ShopName", ShopName);
                    sqlCommand.Parameters.AddWithValue("@Address1", Address1);
                    sqlCommand.Parameters.AddWithValue("@Address2", Address2);
                    sqlCommand.Parameters.AddWithValue("@Address3", Address3);
                    sqlCommand.Parameters.AddWithValue("@Address4", Address4);
                    sqlCommand.Parameters.AddWithValue("@PostCode", PostCode);
                    sqlCommand.Parameters.AddWithValue("@ContactName", ContactName);
                    sqlCommand.Parameters.AddWithValue("@Telephone", Telephone);
                    sqlCommand.Parameters.AddWithValue("@Telephone2", Telephone2);
                    sqlCommand.Parameters.AddWithValue("@Fax", Fax);
                    sqlCommand.Parameters.AddWithValue("@eMail", eMail);
                    sqlCommand.Parameters.AddWithValue("@ShopType", ShopType);
                    sqlCommand.Parameters.AddWithValue("@Memo", Memo);
                    sqlCommand.Parameters.AddWithValue("@VATPayable", VATPayable);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateSupplier(string SupplierRef, string SupplierName, string Address1, string Address2, string Address3, string Address4, string PostCode, string ContactName, string Telephone, string Telephone2, string Fax, string eMail, string Memo)
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "UPDATE tblSuppliers SET SupplierName = @SupplierName,Address1=@Address1,Address2=@Address2,Address3=@Address3,Address4 = @Address4,PostCode = @PostCode,ContactName = @ContactName,Telephone = Telephone,Telephone2 = @Telephone2,Fax = @Fax,eMail = @eMail,Memo = @Memo WHERE SupplierRef = @SupplierRef",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };
                    sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                    sqlCommand.Parameters.AddWithValue("@SupplierName", SupplierName);
                    sqlCommand.Parameters.AddWithValue("@Address1", Address1);
                    sqlCommand.Parameters.AddWithValue("@Address2", Address2);
                    sqlCommand.Parameters.AddWithValue("@Address3", Address3);
                    sqlCommand.Parameters.AddWithValue("@Address4", Address4);
                    sqlCommand.Parameters.AddWithValue("@PostCode", PostCode);
                    sqlCommand.Parameters.AddWithValue("@ContactName", ContactName);
                    sqlCommand.Parameters.AddWithValue("@Telephone", Telephone);
                    sqlCommand.Parameters.AddWithValue("@Telephone2", Telephone2);
                    sqlCommand.Parameters.AddWithValue("@Fax", Fax);
                    sqlCommand.Parameters.AddWithValue("@eMail", eMail);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateStockCode(string StockCode, string SupplierRef, bool DeadCode, decimal AmountTaken, decimal CostValue, int DelQtyH, decimal PCMarkUp)
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "UPDATE tblStock SET SupplierRef=@SupplierRef,DeadCode=@DeadCode,AmountTaken=@AmountTaken,DeliveredQtyHangers=@DeliveredQtyHangers,CostValue=@CostValue,PCMarkUp=@PCMarkUp WHERE StockCode = @StockCode",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    ;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdatePurchaseOrder()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdatePurchaseOrderLines()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateWHAdjustment()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateWHAdjustmentLines()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateShopDelivery()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateShopDeliveryLines()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateShopAdjustment()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateShopAdjustmentLines()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateShopTransfers()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateShopTransferLines()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateShopReturn()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateShopReturnLines()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateShopSale()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateShopSaleLines()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
        public bool UpdateVAT()
        {
            // Tested Date : ??/??/2018
            UpdateToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                UpdateToDB = false;
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
                    UpdateToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    UpdateToDB = false;
                    throw;
                }
            }
            return UpdateToDB;
        }
    }
}
