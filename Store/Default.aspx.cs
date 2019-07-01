using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StoreBusinessLayer;
using Store.BusinessModels;

namespace Store
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        /// <summary>
        /// Read Data From DataBase
        /// </summary>
        public void ReadData()
        {
            StoreBusinessLayer.StoreBusinessLayer oStoreBusinessLayer = new StoreBusinessLayer.StoreBusinessLayer();

            StoreInventoryBL oStoreInventoryBL = new StoreInventoryBL();
            IList<StoreInventoryBL> iStoreInventoryBL = new List<StoreInventoryBL>();

            iStoreInventoryBL = oStoreBusinessLayer.ReadDataBL();

            gridViewStoreInventory.DataSource = iStoreInventoryBL;
            gridViewStoreInventory.DataBind();
        }

        /// <summary>
        /// Insert Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void buttonInsertData_Click(object sender, EventArgs e)
        {
            string contentName = textBoxContentName.Text;
            int contentQuantity = Convert.ToInt32(textBoxContentQuantity.Text);
            StoreBusinessLayer.StoreBusinessLayer oStoreBusinessLayer = new StoreBusinessLayer.StoreBusinessLayer();
            StoreInventoryBL oStoreInventoryBL = new StoreInventoryBL();

            oStoreInventoryBL.ContentName = contentName;
            oStoreInventoryBL.ContentQuantity = contentQuantity;

            int rowCount = oStoreBusinessLayer.InsertDataDL(oStoreInventoryBL);

            if (rowCount >= 1)
            {
                ReadData();
            } 
        }

        /// <summary>
        /// Update Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void buttonUpdateData_Click(object sender, EventArgs e)
        {
            string contentName = textBoxContentName.Text;
            int contentQuantity = Convert.ToInt32(textBoxContentQuantity.Text);
            int contentID = Convert.ToInt32(textBoxContentID.Text);
            StoreBusinessLayer.StoreBusinessLayer oStoreBusinessLayer = new StoreBusinessLayer.StoreBusinessLayer();
            StoreInventoryBL oStoreInventoryBL = new StoreInventoryBL();

            oStoreInventoryBL.ContentName = contentName;
            oStoreInventoryBL.ContentQuantity = contentQuantity;
            oStoreInventoryBL.Id = contentID;

            int rowCount = oStoreBusinessLayer.UpdateDataBL(oStoreInventoryBL);

            if (rowCount >= 1)
            {
                ReadData();
            }
        }

        protected void buttonDeleteData_Click(object sender, EventArgs e)
        {
            int contentID = Convert.ToInt32(textBoxContentID.Text);
            StoreBusinessLayer.StoreBusinessLayer oStoreBusinessLayer = new StoreBusinessLayer.StoreBusinessLayer();
            StoreInventoryBL oStoreInventoryBL = new StoreInventoryBL();

            oStoreInventoryBL.Id = contentID;

            int rowCount = oStoreBusinessLayer.DeleteDataBL(oStoreInventoryBL);

            if (rowCount >= 1)
            {
                ReadData();
            }
        }
    }
}