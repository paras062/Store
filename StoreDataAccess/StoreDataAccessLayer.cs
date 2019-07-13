using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.DataModels;
using System.Data.SqlClient;
using System.Data;

namespace StoreDataAccess
{
    public class StoreDataAccessLayer
    {
        Connection oConnection = new Connection();
        SqlCommand oSqlCommand = new SqlCommand();

        /// <summary>
        /// Method to read data
        /// </summary>
        /// <returns></returns>
        public IList<StoreInventoryDL> ReadDataDL()
        {
            //List collection to store data models
            IList<StoreInventoryDL> iStoreInventoryDL = new List<StoreInventoryDL>();

            //Object to data models
            StoreInventoryDL oStoreInventoryDL = null;

            if (ConnectionState.Closed == oConnection.oSqlConnection.State)
            {
                oConnection.oSqlConnection.Open();
            }

            oSqlCommand.CommandText = "SELECT * FROM dbo.StoreInventory";
            oSqlCommand.Connection = oConnection.oSqlConnection;

            try
            {
                SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();
                while (oSqlDataReader.Read())
                {
                    oStoreInventoryDL = new StoreInventoryDL();
                    oStoreInventoryDL.Id = Convert.ToInt32(oSqlDataReader["Id"]);
                    oStoreInventoryDL.ContentName = oSqlDataReader["ContentName"].ToString();
                    oStoreInventoryDL.ContentQuantity = Convert.ToInt32(oSqlDataReader["ContentQuantity"]);

                    iStoreInventoryDL.Add(oStoreInventoryDL);

                }

            }
            catch
            {
                throw;
            }

            //return oStoreInventory;
            return iStoreInventoryDL;

        }

        /// <summary>
        /// Metod to Insert Data
        /// </summary>
        /// <param name="oStoreInventoryDL"></param>
        /// <returns></returns>
        public int InsertDataDL(StoreInventoryDL oStoreInventoryDL) {

            if (ConnectionState.Closed == oConnection.oSqlConnection.State)
            {
                oConnection.oSqlConnection.Open();
            }

            oSqlCommand.CommandText = "INSERT INTO dbo.StoreInventory(ContentName, ContentQuantity) VALUES (@ContentName, @ContentQuantity)";
            oSqlCommand.Parameters.AddWithValue("@ContentName", oStoreInventoryDL.ContentName);
            oSqlCommand.Parameters.AddWithValue("@ContentQuantity", oStoreInventoryDL.ContentQuantity);

            //Open Connection
            oSqlCommand.Connection = oConnection.oSqlConnection;

            //execute command
            int rowCount = oSqlCommand.ExecuteNonQuery();
            
            return rowCount;
        }


        /// <summary>
        /// Metho to Update Data
        /// </summary>
        /// <param name="oStoreInventoryDL"></param>
        /// <returns></returns>
        public int UpdateDataDL(StoreInventoryDL oStoreInventoryDL) {

            if (ConnectionState.Closed == oConnection.oSqlConnection.State)
            {
                oConnection.oSqlConnection.Open();
            }

            oSqlCommand.CommandText = "UPDATE dbo.StoreInventory SET ContentName = @ContentName, ContentQuantity = @ContentQuantity WHERE ID = @ContentID";
            oSqlCommand.Parameters.AddWithValue("@ContentName", oStoreInventoryDL.ContentName);
            oSqlCommand.Parameters.AddWithValue("@ContentQuantity", oStoreInventoryDL.ContentQuantity);
            oSqlCommand.Parameters.AddWithValue("@ContentID", oStoreInventoryDL.Id);

            //Open Connection
            oSqlCommand.Connection = oConnection.oSqlConnection;

            //execute command
            int rowCount = oSqlCommand.ExecuteNonQuery();

            return rowCount;
        }


        /// <summary>
        /// Method to Delete Data
        /// </summary>
        /// <param name="oStoreInventoryDL"></param>
        /// <returns></returns>
        public int DeleteDataDL(StoreInventoryDL oStoreInventoryDL)
        {
            if (ConnectionState.Closed == oConnection.oSqlConnection.State)
            {
                oConnection.oSqlConnection.Open();
            }

            oSqlCommand.CommandText = "DELETE FROM dbo.StoreInventory WHERE ID = @ContentID";
            oSqlCommand.Parameters.AddWithValue("@ContentID", oStoreInventoryDL.Id);

            //Open Connection
            oSqlCommand.Connection = oConnection.oSqlConnection;

            //execute command
            int rowCount = oSqlCommand.ExecuteNonQuery();

            return rowCount;
        }
    }
}
