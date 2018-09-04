using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class _MultiTableDAO
    {
        public DataSet SelectBookTitleWithTitleOrAuthorNameOrCategoryName(string title, string author, string category)
        {
            string strCmd = "e_select_book_title_with_title_or_author_name_or_category_name";
            SqlParameter Title = new SqlParameter("@Title", title);
            SqlParameter Author = new SqlParameter("@AuthorName", author);
            SqlParameter Category = new SqlParameter("@CategoryName", category);

            try
            {
                return _DataProvicer.ExecuteQueryWithDataSet(strCmd, CommandType.StoredProcedure, Title, Author, Category);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet SelectBookTitleWithTitleAndAuthorNameAndCategoryName(string title, string author, string category)
        {
            string strCmd = "e_select_book_title_with_title_and_author_name_and_category_name";
            SqlParameter Title = new SqlParameter("@Title", title);
            SqlParameter Author = new SqlParameter("@AuthorName", author);
            SqlParameter Category = new SqlParameter("@CategoryName", category);

            try
            {
                return _DataProvicer.ExecuteQueryWithDataSet(strCmd, CommandType.StoredProcedure, Title, Author, Category);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet SelectRequestByUserIDAndStatus(string userID, string status)
        {
            string strCmd = "e_select_request_by_user_id_and_status";
            SqlParameter user = new SqlParameter("@UserID", userID);
            SqlParameter stt = new SqlParameter("@Status", status);

            try
            {
                return _DataProvicer.ExecuteQueryWithDataSet(strCmd, CommandType.StoredProcedure, user, stt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet FindBookIDAndInventoryIDByBookTitleID(string title, string status)
        {
            string strCmd = "select_book_id_inventory_id_title_author_name_category_name_when_inventory_status_by_book_title_id";
            SqlParameter tt = new SqlParameter("@BookTitleID", title);
            SqlParameter stt = new SqlParameter("@Status", status);

            try
            {
                return _DataProvicer.ExecuteQueryWithDataSet(strCmd, CommandType.StoredProcedure, tt, stt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
