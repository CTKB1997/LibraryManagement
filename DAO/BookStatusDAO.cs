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
    public class BookStatusDAO
    {
        public bool AddNewBookStatus(BookStatusDTO bs)
        {
            string strCmd = "add_book_status";
            SqlParameter id = new SqlParameter("@Status", bs.Status);
            SqlParameter name = new SqlParameter("@StatusInfo", bs.StatusInfo);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool UpdateBookStatus(BookStatusDTO bs)
        {
            string strCmd = "update_book_status";
            SqlParameter id = new SqlParameter("@Status", bs.Status);
            SqlParameter name = new SqlParameter("@StatusInfo", bs.StatusInfo);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool DeleteBookStatus(string Status)
        {
            string strCmd = "delete_book_status";
            SqlParameter id = new SqlParameter("@Status", Status);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public List<DTO.BookStatusDTO> SelectAllBookStatusByDataReader()
        {
            List<DTO.BookStatusDTO> list = new List<DTO.BookStatusDTO>();
            string strCmd = "select_all_book_status";
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DTO.BookStatusDTO dto = new DTO.BookStatusDTO
                    {
                        Status = rd.GetInt32(0),
                        StatusInfo = rd.GetString(1),
                    };
                    list.Add(dto);
                }
            }
            return list;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DataSet SelectAllBookStatusByDataSet()
        {
            string strCmd = "select_all_book_status";
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

    }
}
