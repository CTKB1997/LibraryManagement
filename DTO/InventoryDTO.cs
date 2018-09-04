using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InventoryDTO
    {
        private string _InventoryID;
        private string _BookID;
        private string _Index;
        private int _Status;

        public InventoryDTO(string InventoryID, string BookID, string Index, int Status)
        {
            this.InventoryID = InventoryID;
            this.BookID = BookID;
            this.Index = Index;
            this.Status = Status;
        }

        public InventoryDTO() { }

        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Index
        {
            get { return _Index; }
            set { _Index = value; }
        }
        public string BookID
        {
            get { return _BookID; }
            set { _BookID = value; }
        }
        public string InventoryID
        {
            get { return _InventoryID; }
            set { _InventoryID = value; }
        }
    }
}
