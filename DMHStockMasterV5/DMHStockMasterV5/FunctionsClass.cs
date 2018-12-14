using System.Data;
using System.Data.SqlClient;

namespace DMHStockMasterV5
{
    public class FunctionsClass : UtilsClass
    {
       // private UtilsClass utilsClass = new UtilsClass();   // Get the connection string for the Data transactions
        public string GetLocationName(string RecordName,string SqlCmd)
        {
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandText = SqlCmd,
                    CommandType = CommandType.Text,
                    Connection = sqlConnection
                };
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@WarehouseRef", RecordName);
                return (string)sqlCommand.ExecuteScalar();
            }
        }
        public string GetSupplierName(string SupplierRef)
        {
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandText = "SELECT SupplierRef from tblSuppliers WHERE SupplierRef=@SupplierRef",
                    CommandType = CommandType.Text,
                    Connection = sqlConnection
                };
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                return (string)sqlCommand.ExecuteScalar();
            }
        }
        public int GetStockQty(string StockCode, string LocationRef)
        {
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandText = "SELECT Qty from qryStockLevel WHERE LocationRef=@LocationRef AND StockCode=@StockCode",
                    CommandType = CommandType.Text,
                    Connection = sqlConnection
                };
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@LocationRef", LocationRef);
                sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                return (int)sqlCommand.ExecuteScalar();
            }
        }
        public int CheckStockCode(string StockCode)
        {
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandText = "SELECT COUNT(*) from tblStock WHERE StockCode=@StockCode",
                    CommandType = CommandType.Text,
                    Connection = sqlConnection
                };
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                return (int)sqlCommand.ExecuteScalar();
            }
        }
        public int GetLastID(string sqlCmd)
        {
            using (SqlConnection sqlConnection = new SqlConnection(GetConnString(0)))
            {
                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandText = sqlCmd,
                    CommandType = CommandType.Text,
                    Connection = sqlConnection
                };
                sqlConnection.Open();
                return (int)sqlCommand.ExecuteScalar();
            }
        }
    }
}
