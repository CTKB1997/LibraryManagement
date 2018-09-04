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
    public class BookDAO
    {
        public bool AddNewBook(BookDTO book)
        {
            string strCmd = "add_book";
            SqlParameter id = new SqlParameter("@BookID", book.BookID);
            SqlParameter name = new SqlParameter("@BookTitleID", book.BookTitleID);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, name);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool UpdateBook(BookDTO book)
        {
            string strCmd = "update_book";
            SqlParameter id = new SqlParameter("@BookID", book.BookID);
            SqlParameter name = new SqlParameter("@BookTitleID", book.BookTitleID);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, name);
            }
            catch (Exception ex)
            {
                return false;
                //throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool DeleteBook(string BookID)
        {
            string strCmd = "delete_book";
            SqlParameter id = new SqlParameter("@BookID", BookID);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id);
            }
            catch (Exception ex)
            {
                return false;
                //throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public List<DTO.BookDTO> SelectAllBookByDataReader()
        {
            List<DTO.BookDTO> list = new List<DTO.BookDTO>();
            string strCmd = "select_all_book";
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DTO.BookDTO dto = new DTO.BookDTO
                    {
                        BookID = rd.GetString(0),
                        BookTitleID = rd.GetString(1),
                    };
                    list.Add(dto);
                }
            }
            return list;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DataSet SelectAllBookByDataSet()
        {
            string strCmd = "select_all_book";
            try
            {
                return _DataProvicer.ExecuteQueryWithDataSet(strCmd, CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                return null;
                //throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool IsBookIDExisted(string id)
        {
            string strCmd = "e_select_book_by_book_id";
            SqlParameter ID = new SqlParameter("@BookID", id);
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
