using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class _MultiTableBUS
    {
        private DAO._MultiTableDAO dao = new DAO._MultiTableDAO();
        public string stt { get; set; }
        public DataTable SelectBookTitleWithTitleOrAuthorNameOrCategoryName(string s1, string s2, string s3)
        {
            DataTable dt = dao.SelectBookTitleWithTitleOrAuthorNameOrCategoryName(s1, s2, s3).Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }

        public DataTable SelectBookTitleWithTitleAndAuthorNameAndCategoryName(string s1, string s2, string s3)
        {
            DataTable dt = dao.SelectBookTitleWithTitleAndAuthorNameAndCategoryName(s1, s2, s3).Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }

        public DataTable SelectRequestByUserIDAndStatus(string userID, string status)
        {
            DataTable dt = dao.SelectRequestByUserIDAndStatus(userID, status).Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }

        public bool AcceptRequest(string reqID)
        {
            BUS.RequestBUS reqBUS = new BUS.RequestBUS();
            //reqBUS.UpdateRequest(reqID, 2);
            DAO.RequestDAO reqDAO = new DAO.RequestDAO();
            DTO.RequestDTO reqDTO = reqDAO.SearchRequestByRequestID(reqID);
            DAO._MultiTableDAO mulDAO = new DAO._MultiTableDAO();
            DataTable dt = mulDAO.FindBookIDAndInventoryIDByBookTitleID(reqDTO.BookTitleID, "0").Tables[0];
            if (dt != null)
            {
                string bookID, inventoryID;
                try
                {
                    bookID = dt.Rows[0]["BookID"].ToString();
                    inventoryID = dt.Rows[0]["InventoryID"].ToString();
                } catch (Exception ex)
                {
                    return false;
                }
                Console.WriteLine(bookID);
                Console.WriteLine(inventoryID);
                if (bookID != null && inventoryID != null)
                {
                    try
                    {
                        bool result = true;
                        result &= reqBUS.UpdateRequest(reqID, 2);
                        Console.WriteLine(result);
                        InventoryBUS invBUS = new InventoryBUS();
                        result &= invBUS.UpdateInventory(inventoryID, 1);

                        Console.WriteLine(result);
                        LoanBUS loBUS = new LoanBUS();
                        if (result) {
                            result &= loBUS.AddNewLoan(reqID, bookID);
                            Console.WriteLine(result);
                            if (result == true)
                            {
                                stt = "Inventory: " + inventoryID;
                            }
                            return result;
                        } else
                        {
                            reqBUS.UpdateRequest(reqID, 0);
                            invBUS.UpdateInventory(inventoryID, 0);
                        }
                    } catch (Exception ex)
                    {
                        Console.WriteLine("Exception: " + ex.Message);
                        reqBUS.UpdateRequest(reqID, 0);
                        InventoryBUS invBUS = new InventoryBUS();
                        invBUS.UpdateInventory(inventoryID, 0);
                    }
                }
            }
            return false;
        }
    }
}
