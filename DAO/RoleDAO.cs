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
    public class RoleDAO
    {
        public bool AddNewRole(RoleDTO role)
        {
            string strCmd = "add_role";
            SqlParameter id = new SqlParameter("@RoleID", role.RoleID);
            SqlParameter name = new SqlParameter("@RoleName", role.RoleName);
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
        public bool UpdateRole(RoleDTO role)
        {
            string strCmd = "add_role";
            SqlParameter id = new SqlParameter("@RoleID", role.RoleID);
            SqlParameter name = new SqlParameter("@RoleName", role.RoleName);
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
        public bool DeleteRole(string RoleID)
        {
            string strCmd = "delete_role";
            SqlParameter id = new SqlParameter("@RoleID", RoleID);
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
        public List<DTO.RoleDTO> SelectAllRoleByDataReader()
        {
            List<DTO.RoleDTO> list = new List<DTO.RoleDTO>();
            string strCmd = "select_all_role";
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DTO.RoleDTO dto = new DTO.RoleDTO
                    {
                        RoleID = rd.GetString(0),
                        RoleName = rd.GetString(1),
                    };
                    list.Add(dto);
                }
            }
            return list;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DataSet SelectAllRoleByDataSet()
        {
            string strCmd = "select_all_role";
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
            string strCmd = "e_select_author_by_book_id";
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
        public bool IsRoleExisted(string id)
        {
            string strCmd = "e_select_role_by_role_id";
            SqlParameter ID = new SqlParameter("@RoleID", id);
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
