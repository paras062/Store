using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.BusinessModels;
using Store.DataModels;
using StoreDataAccess;

namespace StoreBusinessLayer
{
    public class StoreBusinessLayer
    {
        //Create object of Data Access Layer to read the methods
        StoreDataAccessLayer oStoreDataAccess = new StoreDataAccessLayer();

        //Create object of Business Model to read model variables
        StoreInventoryBL oStoreInventoryBL = null;

        //Create object of Data Model to read model variables
        StoreInventoryDL oStoreInventoryDL = new StoreInventoryDL();


        /// <summary>
        /// Method to read data from DataAccessLayer
        /// </summary>
        /// <returns></returns>
        public IList<StoreInventoryBL> ReadDataBL()
        {

            //Create list for business model
            IList<StoreInventoryBL> iStoreInventoryBL = new List<StoreInventoryBL>();

            //Create list for data model
            IList<StoreInventoryDL> iStoreInventoryDL = new List<StoreInventoryDL>();

            iStoreInventoryDL = oStoreDataAccess.ReadDataDL();

            //iStoreInventoryBL.Add = iStoreInventoryDL;

            foreach (var item in iStoreInventoryDL)
            {
                oStoreInventoryBL = new StoreInventoryBL();
                oStoreInventoryBL.Id = item.Id;
                oStoreInventoryBL.ContentName = item.ContentName;
                oStoreInventoryBL.ContentQuantity = item.ContentQuantity;

                iStoreInventoryBL.Add(oStoreInventoryBL);
            }


            //Populating data model object with the data coming from Data Access Layer's ReadData() Method
            //oStoreInventoryDL = oStoreDataAccess.ReadDataDL();




            //Populating Business data model varialbes with that of data model's
            //oStoreInventoryBL.Id = oStoreInventoryDL.Id;
            //oStoreInventoryBL.ContentName = oStoreInventoryDL.ContentName;
            //oStoreInventoryBL.ContentQuantity = oStoreInventoryDL.ContentQuantity;

            //returning business data model object to view.
            return iStoreInventoryBL;

        }

        /// <summary>
        /// Method to Insert Data
        /// </summary>
        /// <param name="oStoreInventoryBL"></param>
        /// <returns></returns>

        public int InsertDataDL(StoreInventoryBL oStoreInventoryBL)
        {
            StoreDataAccessLayer oStoreDataAccessLayer = new StoreDataAccessLayer();
            StoreInventoryDL oStoreInventoryDL = new StoreInventoryDL();

            oStoreInventoryDL.ContentName = oStoreInventoryBL.ContentName;
            oStoreInventoryDL.ContentQuantity = oStoreInventoryBL.ContentQuantity;

            int rowCount = oStoreDataAccessLayer.InsertDataDL(oStoreInventoryDL);
            return rowCount;
        }

        /// <summary>
        /// Method to Update Data
        /// </summary>
        /// <param name="oStoreInventoryBL"></param>
        /// <returns></returns>
        public int UpdateDataBL(StoreInventoryBL oStoreInventoryBL)
        {
            StoreDataAccessLayer oStoreDataAccessLayer = new StoreDataAccessLayer();
            StoreInventoryDL oStoreInventoryDL = new StoreInventoryDL();

            oStoreInventoryDL.ContentName = oStoreInventoryBL.ContentName;
            oStoreInventoryDL.ContentQuantity = oStoreInventoryBL.ContentQuantity;
            oStoreInventoryDL.Id = oStoreInventoryBL.Id;

            int rowCount = oStoreDataAccessLayer.UpdateDataDL(oStoreInventoryDL);
            return rowCount;
        }


        public int DeleteDataBL(StoreInventoryBL oStoreInventoryBL) {
            StoreDataAccessLayer oStoreDataAccessLayer = new StoreDataAccessLayer();
            StoreInventoryDL oStoreInventoryDL = new StoreInventoryDL();

            oStoreInventoryDL.Id = oStoreInventoryBL.Id;

            int rowCount = oStoreDataAccessLayer.DeleteDataDL(oStoreInventoryDL);
            return rowCount;
        }
    }
}
