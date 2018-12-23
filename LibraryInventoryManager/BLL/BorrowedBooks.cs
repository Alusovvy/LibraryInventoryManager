using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInventoryManager.BLL
{
   public class BorrowedBooks
    {
        public int id { get; set; }
        public string title { get; set; }
        public string authorFullName { get; set; }
        public string borrowedBy { get; set; }
        public DateTime borrowedWhen { get; set; }
        public DateTime borrowedTill { get; set; }
        public bool isOverdue { get; set; }
    }
}
