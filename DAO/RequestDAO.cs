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
    public class RequestDAO
    {
        public bool AddNewRequest(RequestDTO req)
        {
            string strCmd = "add_request";
            SqlParameter id = new SqlParameter("@ReqID", req.ReqID);
            SqlParameter userID = new SqlParameter("@UserID", req.UserID);
            SqlParameter bookTitleID = new SqlParameter("@BookTitleID", req.BookTitleID);
            SqlParameter reqDate = new SqlParameter("@ReqDate", req.ReqDate);
            SqlParameter reqStatus = new SqlParameter("@ReqStatus", req.ReqStatus);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, userID, bookTitleID, reqDate, reqStatus);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool UpdateRequest(RequestDTO req)
        {
            string strCmd = "update_request";
            SqlParameter id = new SqlParameter("@ReqID", req.ReqID);
            SqlParameter userID = new SqlParameter("@UserID", req.UserID);
            SqlParameter bookTitleID = new SqlParameter("@BookTitleID", req.BookTitleID);
            SqlParameter reqDate = new SqlParameter("@ReqDate", req.ReqDate);
            SqlParameter reqStatus = new SqlParameter("@ReqStatus", req.ReqStatus);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, userID, bookTitleID, reqDate, reqStatus);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool DeleteRequest(string ReqID)
        {
            string strCmd = "delete_request";
            SqlParameter id = new SqlParameter("@ReqID", ReqID);
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
        public List<DTO.RequestDTO> SelectAllAuthorByDataReader()
        {
            List<DTO.RequestDTO> list = new List<DTO.RequestDTO>();
            string strCmd = "select_all_request";
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DTO.RequestDTO dto = new DTO.RequestDTO
                    {
                        ReqID = rd.GetString(0),
                        UserID = rd.GetString(1),
                        BookTitleID = rd.GetString(2),
                        ReqDate = rd.GetDateTime(3),
                        ReqStatus = rd.GetInt32(4)
                    };
                    list.Add(dto);
                }
            }
            return list;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DataSet SelectAllRequestByDataSet()
        {
            string strCmd = "select_all_request";
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
        public bool IsRequestExisted(string id)
        {
            string strCmd = "e_select_request_by_req_id";
            SqlParameter ID = new SqlParameter("@ReqID", id);
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
        public DTO.RequestDTO SearchRequestByRequestID(string id)
        {
            string strCmd = "e_select_request_by_req_id";
            SqlParameter ID = new SqlParameter("@ReqID", id);
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure, ID);
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    DTO.RequestDTO dto = new DTO.RequestDTO
                    {
                        ReqID = rd.GetString(0),
                        UserID = rd.GetString(1),
                        BookTitleID = rd.GetString(2),
                        ReqDate = rd.GetDateTime(3),
                        ReqStatus = rd.GetInt32(4)
                    };
                    return dto;
                }
            }
            return null;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DataSet SelectRequestByRequestStatus(int status)
        {
            string strCmd = "select_request_by_request_status";
            SqlParameter stt = new SqlParameter("@Status", status);
            try
            {
                return _DataProvicer.ExecuteQueryWithDataSet(strCmd, CommandType.StoredProcedure, stt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet SelectRequestByUserID(string UserID)
        {
            string strCmd = "select_request_by_user_id";
            SqlParameter id = new SqlParameter("@UserID", UserID);
            try
            {
                return _DataProvicer.ExecuteQueryWithDataSet(strCmd, CommandType.StoredProcedure, id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
