using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class UserDAO
    {
        public int _CheckLogin(string UserID, string Password)
        {
            string strConnection = _DataProvicer.getConnectionString();
            string strCmd = "check_login";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(strCmd, cnn);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.CommandType = CommandType.StoredProcedure;
            int result = -1;
            SqlDataReader rd;
            try
            {
                cnn.Open();
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    result = int.Parse(rd.GetString(0));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return result;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public int CheckLogin(string UserID, string Password)
        {
            string strCmd = "check_login";
            SqlParameter user = new SqlParameter("@UserID", UserID);
            SqlParameter password = new SqlParameter("@Password", Password);
            int result = -1;
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure, user, password);
            if (rd.HasRows)
            {
                rd.Read();
                result = int.Parse(rd.GetString(0));
            }
            return result;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool AddNewUser(UserDTO user)
        {
            string strCmd = "add_user";
            SqlParameter id = new SqlParameter("@UserID", user.UserID);
            SqlParameter name = new SqlParameter("@UserName", user.UserName);
            SqlParameter password = new SqlParameter("@Password", user.Password);
            SqlParameter phone = new SqlParameter("@Phone", user.Phone);
            SqlParameter email = new SqlParameter("@Email", user.Email);
            SqlParameter roleID = new SqlParameter("@RoleID", user.RoleID);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, name, password, phone, email, roleID);
            } catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return false;

            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public List<DTO.UserDTO> SelectAllUserByDataReader()
        {
            List<DTO.UserDTO> list = new List<DTO.UserDTO>();
            string strCmd = "select_all_user";
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DTO.UserDTO dto = new DTO.UserDTO
                    {
                        UserID = rd.GetString(0),
                        UserName = rd.GetString(1),
                        Password = rd.GetString(2),
                        Phone = rd.GetInt32(3),
                        Email = rd.GetString(4),
                        RoleID = rd.GetString(5)
                    };
                    list.Add(dto);
                }
            }
            return list;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DataSet SelectAllUserByDataSet()
        {
            string strCmd = "select_all_user";
            try
            {
                return _DataProvicer.ExecuteQueryWithDataSet(strCmd, CommandType.StoredProcedure);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool UpdateUser(UserDTO user)
        {
            string strCmd = "update_user";
            SqlParameter id = new SqlParameter("@UserID", user.UserID);
            SqlParameter name = new SqlParameter("@UserName", user.UserName);
            SqlParameter password = new SqlParameter("@Password", user.Password);
            SqlParameter phone = new SqlParameter("@Phone", user.Phone);
            SqlParameter email = new SqlParameter("@Email", user.Email);
            SqlParameter roleID = new SqlParameter("@RoleID", user.RoleID);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id, name, password, phone, email, roleID);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return false;

            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public bool DeleteUser(string UserID)
        {
            string strCmd = "delete_user";
            SqlParameter id = new SqlParameter("@UserID", UserID);
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
        public bool IsUserExisted(string id)
        {
            string strCmd = "e_select_user_by_user_id";
            SqlParameter ID = new SqlParameter("@UserID", id);
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
