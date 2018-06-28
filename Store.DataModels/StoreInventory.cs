using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataModels
{
    public class StoreInventory
    {
        public int Id { get; set; }
        public string ContentName { get; set; }
        public int ContentQuantity { get; set; }
    }
}
