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
    public class LoanDAO
    {
        public bool AddNewLoan(LoanDTO loan)
        {
            string strCmd = "add_loan";
            SqlParameter id = new SqlParameter("@LoanID", loan.LoanID);
            SqlParameter reqID = new SqlParameter("@ReqID", loan.ReqID);
            SqlParameter bookID = new SqlParameter("@BookID", loan.BookID);
            SqlParameter expiredDate = new SqlParameter("@ExpiredDate", loan.ExpiredDate);
            SqlParameter borrowedDate = new SqlParameter("@BorrowedDate", loan.BorrowedDate);
            SqlParameter status = new SqlParameter("@Status", loan.Status);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, reqID, bookID, expiredDate, borrowedDate, status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool UpdateLoan(LoanDTO loan)
        {
            string strCmd = "update_loan";
            SqlParameter id = new SqlParameter("@LoanID", loan.LoanID);
            SqlParameter reqID = new SqlParameter("@ReqID", loan.ReqID);
            SqlParameter bookID = new SqlParameter("@BookID", loan.BookID);
            SqlParameter expiredDate = new SqlParameter("@ExpiredDate", loan.ExpiredDate);
            SqlParameter borrowedDate = new SqlParameter("@BorrowedDate", loan.BorrowedDate);
            SqlParameter status = new SqlParameter("@Status", loan.Status);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, reqID, bookID, expiredDate, borrowedDate, status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool DeleteLoan(string LoanID)
        {
            string strCmd = "delete_loan";
            SqlParameter id = new SqlParameter("@LoanID", LoanID);
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
        public List<DTO.LoanDTO> SelectAllLoanByDataReader()
        {
            List<DTO.LoanDTO> list = new List<DTO.LoanDTO>();
            string strCmd = "select_all_loan";
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DTO.LoanDTO dto = new DTO.LoanDTO
                    {
                        LoanID = rd.GetString(0),
                        ReqID = rd.GetString(1),
                        BookID = rd.GetString(2),
                        ExpiredDate = rd.GetDateTime(3),
                        BorrowedDate = rd.GetDateTime(4),
                        Status = rd.GetInt32(5)
                    };
                    list.Add(dto);
                }
            }
            return list;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DataSet SelectAllLoanByDataSet()
        {
            string strCmd = "select_all_loan";
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
        public bool IsLoanrExisted(string id)
        {
            string strCmd = "e_select_loan_by_loan_id";
            SqlParameter ID = new SqlParameter("@LoanID", id);
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
        public DataSet SelectLoanByID(string UserID)
        {
            string strCmd = "select_loan_by_user_id";
            SqlParameter ID = new SqlParameter("@UserID", UserID);
            try
            {
                return _DataProvicer.ExecuteQueryWithDataSet(strCmd, CommandType.StoredProcedure, ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet SelectLoanByStatus(int status)
        {
            string strCmd = "e_select_loan_by_status";
            SqlParameter ID = new SqlParameter("@Status", status);
            try
            {
                return _DataProvicer.ExecuteQueryWithDataSet(strCmd, CommandType.StoredProcedure, ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool UpdateLoanStatusByLoanID(string LoanID, int Status)
        {
            string strCmd = "e_update_loan_status_by_loan_id";
            SqlParameter id = new SqlParameter("@LoanID", LoanID);
            SqlParameter status = new SqlParameter("@Status", Status);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------

    }
}
