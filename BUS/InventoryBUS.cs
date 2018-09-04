using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class InventoryBUS
    {
        private DAO.InventoryDAO dao = new DAO.InventoryDAO();

        public DataTable getAllInventoryByDataSet()
        {
            DataTable dt = dao.SelectAllInventoryByDataSet().Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }

        public bool AddNewInventory(InventoryDTO inv)
        {
            return dao.AddNewInventory(inv);
        }

        public bool UpdateInventory(InventoryDTO inv, int stt)
        {
            return dao.UpdateInventory(inv, stt);
        }
        
        public bool DeleteInventory(string InventoryID)
        {
            return dao.DeleteInventory(InventoryID);
        }

        public bool IsInventoryIDExisted(string id)
        {
            return dao.IsInventoryExisted(id);
        }

        private DTO.InventoryDTO SearchInventoryByInventoryID(string id)
        {
            return dao.SearchInventoryByInventoryID(id);
        }

        public bool UpdateInventory(string id, int status)
        {
            DTO.InventoryDTO dto = this.SearchInventoryByInventoryID(id);
            return dao.UpdateInventory(dto, status);
        }

        public bool UpdateInventoryStatusByBookID(string BookID, int Status)
        {
            return dao.UpdateInventoryStatusByBookID(BookID, Status);
        }

    }
}
