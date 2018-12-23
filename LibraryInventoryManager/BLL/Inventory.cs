using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInventoryManager.BLL
{
    public class Inventory
    {
        public int id { get; set; }
        public string authorFullName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool isBorrowed { get; set; }
        public decimal qty { get; set; }
    }
}
