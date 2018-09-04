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
    public class AuthorDAO
    {
        public bool AddNewAuthor(AuthorDTO auth)
        {
            string strCmd = "add_author";
            SqlParameter id = new SqlParameter("@AuthorID", auth.AuthorID);
            SqlParameter name = new SqlParameter("@AuthorName", auth.AuthorName);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, name);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return false;
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool UpdateAuthor(AuthorDTO auth)
        {
            string strCmd = "update_author";
            SqlParameter id = new SqlParameter("@AuthorID", auth.AuthorID);
            SqlParameter name = new SqlParameter("@AuthorName", auth.AuthorName);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, name);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return false;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool DeleteAuthor(string AuthorID)
        {
            string strCmd = "delete_author";
            SqlParameter id = new SqlParameter("@AuthorID", AuthorID);
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
        public List<DTO.AuthorDTO> SelectAllAuthorByDataReader()
        {
            List<DTO.AuthorDTO> list = new List<DTO.AuthorDTO>();
            string strCmd = "select_all_author";
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DTO.AuthorDTO dto = new DTO.AuthorDTO
                    {
                        AuthorID = rd.GetString(0),
                        AuthorName = rd.GetString(1),
                    };
                    list.Add(dto);
                }
            }
            return list;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DataSet SelectAllAuthorByDataSet()
        {
            string strCmd = "select_all_author";
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
        public bool IsAuthorExisted(string id)
        {
            string strCmd = "e_select_author_by_author_id";
            SqlParameter ID = new SqlParameter("@AuthorID", id);
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
