using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BookTitleDAO
    {
        public bool AddNewBookTitle(BookTitleDTO bt)
        {
            string strCmd = "add_book_title";
            SqlParameter id = new SqlParameter("@BookTitleID", bt.BookTitleID);
            SqlParameter name = new SqlParameter("@Title", bt.Title);
            SqlParameter author = new SqlParameter("@AuthorID", bt.AuthorID);
            SqlParameter category = new SqlParameter("@CategoryID", bt.CategoryID);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, name, author, category);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return false;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool UpdateBookTitle(BookTitleDTO bt)
        {
            string strCmd = "update_book_title";
            SqlParameter id = new SqlParameter("@BookTitleID", bt.BookTitleID);
            SqlParameter name = new SqlParameter("@Title", bt.Title);
            SqlParameter author = new SqlParameter("@AuthorID", bt.AuthorID);
            SqlParameter category = new SqlParameter("@CategoryID", bt.CategoryID);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, name, author, category);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return false;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool DeleteBookTitle(string BookTitleID)
        {
            string strCmd = "delete_book_title";
            SqlParameter id = new SqlParameter("@BookTitleID", BookTitleID);
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
        public List<DTO.BookTitleDTO> SelectAllBookTitleByDataReader()
        {
            List<DTO.BookTitleDTO> list = new List<DTO.BookTitleDTO>();
            string strCmd = "select_all_book_title";
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DTO.BookTitleDTO dto = new DTO.BookTitleDTO
                    {
                        BookTitleID = rd.GetString(0),
                        Title = rd.GetString(1),
                        AuthorID = rd.GetString(2),
                        CategoryID = rd.GetString(3),
                    };
                    list.Add(dto);
                }
            }
            return list;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DataSet SelectAllBookTitleByDataSet()
        {
            string strCmd = "select_all_book_title";
            try
            {
                return _DataProvicer.ExecuteQueryWithDataSet(strCmd, CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool IsBookTitleIDExisted(string id)
        {
            string strCmd = "e_select_book_title_by_book_title_id";
            SqlParameter ID = new SqlParameter("@BookTitleID", id);
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

    }
}
