using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using StoreBusinessLayer;
using Store.BusinessModels;

namespace Store.Tests
{
    [TestFixture]
    public class First
    {
        //[Test]
        //public void test1()
        //{
        //    int i = 10;
        //    int b = 10;
        //    int c = i + b;
        //    Assert.AreEqual(20, c);
        //}

        [Test]
        public void ReadData_Test()
        {
            bool flag = false;

            StoreBusinessLayer.StoreBusinessLayer oStoreBusinessLayer = new StoreBusinessLayer.StoreBusinessLayer();

            StoreInventoryBL oStoreInventoryBL = new StoreInventoryBL();
            IList<StoreInventoryBL> iStoreInventoryBL = new List<StoreInventoryBL>();

            iStoreInventoryBL = oStoreBusinessLayer.ReadDataBL();

            if (iStoreInventoryBL.Count != 0 || iStoreInventoryBL != null)
            {
                flag = true;
            }

            Assert.AreEqual(flag, true);
        }

        [Test]
        public void InsertData_Test()
        {
            StoreBusinessLayer.StoreBusinessLayer oStoreBusinessLayer = new StoreBusinessLayer.StoreBusinessLayer();
            StoreInventoryBL oStoreInventoryBL = new StoreInventoryBL();

            //Data Values
            oStoreInventoryBL.ContentName = "Test Data";
            oStoreInventoryBL.ContentQuantity = 10;

            int rowCount = oStoreBusinessLayer.InsertDataDL(oStoreInventoryBL);

            Assert.GreaterOrEqual(rowCount, 1);
        }

        [Test]
        public void UpdateData_Test()
        {
            StoreBusinessLayer.StoreBusinessLayer oStoreBusinessLayer = new StoreBusinessLayer.StoreBusinessLayer();
            StoreInventoryBL oStoreInventoryBL = new StoreInventoryBL();

            //Data Values
            oStoreInventoryBL.ContentName = "Test123";
            oStoreInventoryBL.ContentQuantity = 50;
            oStoreInventoryBL.Id = 1007;

            int rowCount = oStoreBusinessLayer.UpdateDataBL(oStoreInventoryBL);

            Assert.GreaterOrEqual(rowCount, 1);
        }

        //[Test]
        //public void DeleteData_Test()
        //{
        //    StoreBusinessLayer.StoreBusinessLayer oStoreBusinessLayer = new StoreBusinessLayer.StoreBusinessLayer();
        //    StoreInventoryBL oStoreInventoryBL = new StoreInventoryBL();

        //    oStoreInventoryBL.Id = 1010;

        //    int rowCount = oStoreBusinessLayer.DeleteDataBL(oStoreInventoryBL);
        //    Assert.GreaterOrEqual(rowCount, 1);

        //    //Assert.LessOrEqual(rowCount, 1);
        //}
    }
}
