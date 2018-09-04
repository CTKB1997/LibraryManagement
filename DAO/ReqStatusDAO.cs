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
    public class ReqStatusDAO
    {
        public bool AddNewReqStatus(ReqStatusDTO req)
        {
            string strCmd = "add_request_status";
            SqlParameter id = new SqlParameter("@ReqStatus", req.ReqStatus);
            SqlParameter name = new SqlParameter("@ReqStatusInfo", req.ReqStatusInfo);
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
        public bool UpdateReqStatus(ReqStatusDTO req)
        {
            string strCmd = "update_request_status";
            SqlParameter id = new SqlParameter("@ReqStatus", req.ReqStatus);
            SqlParameter name = new SqlParameter("@ReqStatusInfo", req.ReqStatusInfo);
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
        public bool DeleteReqStatus(string ReqStatus)
        {
            string strCmd = "delete_request_status";
            SqlParameter id = new SqlParameter("@ReqStatus", ReqStatus);
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
        public List<DTO.ReqStatusDTO> SelectAllReqStatusByDataReader()
        {
            List<DTO.ReqStatusDTO> list = new List<DTO.ReqStatusDTO>();
            string strCmd = "select_all_request_status";
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DTO.ReqStatusDTO dto = new DTO.ReqStatusDTO
                    {
                        ReqStatus = rd.GetInt32(0),
                        ReqStatusInfo = rd.GetString(1),
                    };
                    list.Add(dto);
                }
            }
            return list;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DataSet SelectAllCategoryByDataSet()
        {
            string strCmd = "select_all_request_status";
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
