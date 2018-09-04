using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class InventoryDAO
    {
        public bool AddNewInventory(InventoryDTO inv)
        {
            string strCmd = "add_inventory";
            SqlParameter invId = new SqlParameter("@InventoryID", inv.InventoryID);
            SqlParameter bookID = new SqlParameter("@BookID", inv.BookID);
            SqlParameter index = new SqlParameter("@Index", inv.Index);
            SqlParameter status = new SqlParameter("@Status", inv.Status);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, invId, bookID, index, status);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return false;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool UpdateInventory(InventoryDTO inv, int stt)
        { 
            string strCmd = "update_inventory";
            SqlParameter invId = new SqlParameter("@InventoryID", inv.InventoryID);
            SqlParameter bookID = new SqlParameter("@BookID", inv.BookID);
            SqlParameter index = new SqlParameter("@Index", inv.Index);
            SqlParameter status = new SqlParameter("@Status", stt);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, invId, bookID, index, status);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return false;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool DeleteInventory(string InventoryID)
        {
            string strCmd = "delete_inventory";
            SqlParameter id = new SqlParameter("@InventoryID", InventoryID);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return false;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public List<DTO.InventoryDTO> SelectAllInventoryByDataReader()
        {
            List<DTO.InventoryDTO> list = new List<DTO.InventoryDTO>();
            string strCmd = "select_all_inventory";
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DTO.InventoryDTO dto = new DTO.InventoryDTO
                    {
                        InventoryID = rd.GetString(0),
                        BookID = rd.GetString(1),
                        Index = rd.GetString(2),
                        Status = rd.GetInt32(3),
                    };
                    list.Add(dto);
                }
            }
            return list;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DataSet SelectAllInventoryByDataSet()
        {
            string strCmd = "select_all_inventory";
            try
            {
                return _DataProvicer.ExecuteQueryWithDataSet(strCmd, CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool IsInventoryExisted(string id)
        {
            string strCmd = "e_select_inventory_by_inventory_id";
            SqlParameter ID = new SqlParameter("@InventoryID", id);
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure, ID);
            if (rd.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DTO.InventoryDTO SearchInventoryByInventoryID(string id)
        {
            string strCmd = "e_select_inventory_by_inventory_id";
            SqlParameter ID = new SqlParameter("@InventoryID", id);
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure, ID);
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    DTO.InventoryDTO dto = new DTO.InventoryDTO
                    {
                        InventoryID = rd.GetString(0),
                        BookID = rd.GetString(1),
                        Index = rd.GetString(2),
                        Status = rd.GetInt32(3)                        
                    };
                    return dto;
                }
            }
            return null;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------

        public bool UpdateInventoryStatusByBookID(string BookID, int Status)
        {
            string strCmd = "e_update_inventory_status_by_book_id";
            SqlParameter bookID = new SqlParameter("@BookID", BookID);
            SqlParameter status = new SqlParameter("@Status", Status);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, bookID, status);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return false;
            }
            //------------------------------------------------------------------------------------------------------------------------------------------

        }
    }
}
