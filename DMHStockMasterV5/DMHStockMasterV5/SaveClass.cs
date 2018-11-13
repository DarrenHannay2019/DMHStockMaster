using System;
using System.Data;
using System.Data.SqlClient;

namespace DMHStockMasterV5
{
    class SaveClass
    {
        UtilsClass utilities = new UtilsClass();
        private int ID;
        private bool SaveToDB;
        private string username;
        public SaveClass()
        {
            username = utilities.Username();
        }
        public bool SaveStockMovements(string StockCode, string SupplierRef, string LocationRef, int LocationType, int MovementType, int MovementQtyHangers, DateTime MovementDate, decimal MovementValue, string Reference, int TransferReference)
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblStockMovements(StockCode,SupplierRef,Location,LocationType,MovementType,MovementQtyHangers,MovementDate,MovementValue,Reference,TransferReference,CreatedBy,CreatedDate) VALUES(@StockCode,@SupplierRef,@Location,@LocationType,@MovementType,@MovementQtyHangers,@MovementDate,@MovementValue,@Reference,@TransferReference,@CreatedBy,@CreatedDate)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };
                    sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                    sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                    sqlCommand.Parameters.AddWithValue("@Location", LocationRef);
                    sqlCommand.Parameters.AddWithValue("@LocationType", LocationType);
                    sqlCommand.Parameters.AddWithValue("@MovementType", MovementType);
                    sqlCommand.Parameters.AddWithValue("@MovementQtyHangers", MovementQtyHangers);
                    sqlCommand.Parameters.AddWithValue("@MovementDate", MovementDate);
                    sqlCommand.Parameters.AddWithValue("@MovementValue", MovementValue);
                    sqlCommand.Parameters.AddWithValue("@Reference", Reference);
                    sqlCommand.Parameters.AddWithValue("@TransferReference", TransferReference);
                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
       
        public void SaveToSystemLog(string stockcode, string supplierref, string location, int qty, string movementtype, string recordtype, DateTime mdate, string reference)
        {
            // Tested Date: ??/??/2018
            using (SqlConnection conn = new SqlConnection(utilities.GetConnString()))
            {
                SqlCommand ICmd = new SqlCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = "INSERT INTO tblSystemLog (StockCode,SupplierRef,Location,Qty,MovementType,RecordType,MovementDate,Tim" +
                "estamp,Reference,CreatedBy) VALUES (@StockCode,@SupplierRef,@Location,@Qty,@MovementType,@RecordType" +
                ",@MovementDate,@Timestamp,@Reference,@CreatedBy)"
                };
                ICmd.Connection.Open();
                ICmd.Parameters.AddWithValue("@StockCode", stockcode);
                ICmd.Parameters.AddWithValue("@SupplierRef", supplierref);
                ICmd.Parameters.AddWithValue("@Location", location);
                ICmd.Parameters.AddWithValue("@Qty", qty);
                ICmd.Parameters.AddWithValue("@MovementType", movementtype);
                ICmd.Parameters.AddWithValue("@RecordType", recordtype);
                ICmd.Parameters.AddWithValue("@MovementDate", mdate);
                ICmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                ICmd.Parameters.AddWithValue("@Reference", reference);
                ICmd.Parameters.AddWithValue("@CreatedBy", username);
                ICmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public bool SaveWarehouse(string WarehouseRef, string WarehouseName, string Address1, string Address2, string Address3, string Address4, string PostCode, string ContactName, string Telephone, string Telephone2, string Fax, string eMail, string Memo, bool WarehouseType)
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblWarehouses (WarehouseRef,WarehouseName,Address1,Address2,Address3,Address4,PostCode,ContactName,Telephone,Telephone2,Fax,eMail,WarehouseType,Memo,CreatedBy,CreatedDate) VALUES (@WarehouseRef,@WarehouseName,@Address1,@Address2,@Address3,@Address4,@PostCode,@ContactName,@Telephone,@Telephone2,@Fax,@eMail,@WarehouseType,@Memo,@CreatedBy,@CreatedDate)",
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
                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveShop(string ShopRef, string ShopName, string Address1, string Address2, string Address3, string Address4, string PostCode, string ContactName, string Telephone, string Telephone2, string Fax, string eMail, string Memo, bool ShopType, bool VATPayable)
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblShop(ShopRef,ShopName,Address1,Address2,Address3,Address4,PostCode,ContactName,Telephone,Telephone2,Fax,eMail,ShopType,CreatedBy,CreatedDate,Memo,VATPayable) VALUES (@ShopRef,@ShopName,@Address1,@Address2,@Address3,@Address4,@PostCode,@ContactName,@Telephone,@Telephone2,@Fax,@eMail,@ShopType,@CreatedBy,@CreatedDate,@Memo,@VATPayable)",
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
                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlCommand.Parameters.AddWithValue("@Memo", Memo);
                    sqlCommand.Parameters.AddWithValue("@VATPayable", VATPayable);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveSupplier(string SupplierRef, string SupplierName, string Address1, string Address2, string Address3, string Address4, string PostCode, string ContactName, string Telephone, string Telephone2, string Fax, string eMail, string Memo)
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblSuppliers (WarehouseRef,WarehouseName,Address1,Address2,Address3,Address4,PostCode,ContactName,Telephone,Telephone2,Fax,eMail,Memo,CreatedBy,CreatedDate) VALUES (@WarehouseRef,@WarehouseName,@Address1,@Address2,@Address3,@Address4,@PostCode,@ContactName,@Telephone,@Telephone2,@Fax,@eMail,@Memo,@CreatedBy,@CreatedDate)",
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
                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveStockCode()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SavePurchaseOrder()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SavePurchaseOrderLines()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };


                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveWHAdjustment(string WarehouseRef,string Reference,int TotalLossItems,int TotalGainItems,DateTime MovementDate)
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblWarehouseAdjustments(WarehouseRef,Reference,TotalLossItems,TotalGainItems,MovementDate,CreatedBy,CreatedDate) VALUES (@WarehouseRef,@Reference,@TotalLossItems,@TotalGainItems,@MovementDate,@CreatedBy,@CreatedDate)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };
					sqlCommand.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);

                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveWHAdjustmentLines()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblWarehouseAdjustmentsLines(WarehouseAdjustID,StockCode,MovementType,Qty,Value) VALUES (@WarehouseAdjustID,@StockCode,@MovementType,@Qty,@Value)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };


                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveShopDelivery()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblShopDeliveries(ShopRef,WarehouseRef,Reference,TotalItems,DeliveryDate,Notes,CreatedBy,CreatedDate) VALUES (@ShopRef,@WarehouseRef,@Reference,@TotalItems,@DeliveryDate,@Notes,@CreatedBy,@CreatedDate)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveShopDeliveryLines()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblShopDeliveriesLines (DeliveriesID,StockCode,DeliveredQty) VALUES (@DeliveriesID,@StockCode,@DeliveredQty)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveShopAdjustment()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblShopAdjustments(ShopRef,Reference,TotalLossItems,TotalGainItems,MovementDate,CreatedBy,CreatedDate) VALUES (@ShopRef,@Reference,@TotalLossItems,@TotalGainItems,@MovementDate,@CreatedBy,@CreatedDate)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveShopAdjustmentLines()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblShopAdjustmentsLines(ShopAdjustID,StockCode,MovementType,Qty,Value) VALUES (@ShopAdjustID,@StockCode,@MovementType,@Qty,@Value)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveShopTransfers()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblShopTransfers (Reference,TransferDate,ShopRef,ShopName,ToShopRef,ToShopName,TotalQtyOut,TotalQtyIn,CreatedBy,CreatedDate) VALUES (@Reference,@TransferDate,@ShopRef,@ShopName,@ToShopRef,@ToShopName,@TotalQtyOut,@TotalQtyIn,@CreatedBy,@CreatedDate)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveShopTransferLines()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblShopTransferLines (TransferID,SMTOID,SMTIID,StockCode,CurrentQty,TOQty,TIQty) VALUES (@TransferID,@SMTOID,@SMTIID,@StockCode,@CurrentQty,@TOQty,@TIQty)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveShopReturn()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblReturns(ShopRef,WarehouseRef,Reference,TotalItems,TransactionDate,CreatedBy,CreatedDate) VALUES (@ShopRef,@WarehouseRef,@Reference,@TotalItems,@TransactionDate,@CreatedBy,@CreatedDate)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveShopReturnLines()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblReturnLines (ReturnID,StockCode,Qty,Value) VALUES (@ReturnID,@StockCode,@Qty,@Value)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveShopSale()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblSales (ShopRef,ShopName,SAReference,TransactionDate,TotalQty,TotalValue,CreatedBy,CreatedDate,VATAmount) VALUES (@ShopRef,@ShopName,@SAReference,@TransactionDate,@TotalQty,@TotalValue,@CreatedBy,@CreatedDate,@VATAmount)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveShopSaleLines()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "INSERT INTO tblSalesLines (SalesID,StockCode,CurrentQty,QtySold,SalesAmount,StockMovementID) VALUES (@SalesID,@StockCode,@CurrentQty,@QtySold,@SalesAmount,@StockMovementID)",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }
        public bool SaveVAT()
        {
            // Tested Date : ??/??/2018
            SaveToDB = false;
            using (SqlConnection sqlConnection = new SqlConnection(utilities.GetConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = "",
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@CreatedBy", username);
                    sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    SaveToDB = true;
                    sqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    SaveToDB = false;
                    throw;
                }
            }
            return SaveToDB;
        }

    }
}
