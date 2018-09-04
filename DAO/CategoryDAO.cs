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
    public class CategoryDAO
    {
        public bool AddNewCategory(CategoryDTO cate)
        {
            string strCmd = "add_category";
            SqlParameter id = new SqlParameter("@CategoryID", cate.CategoryID);
            SqlParameter name = new SqlParameter("@CategoryName", cate.CategoryName);
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
        public bool UpdateCategory(CategoryDTO cate)
        {
            string strCmd = "update_category";
            SqlParameter id = new SqlParameter("@CategoryID", cate.CategoryID);
            SqlParameter name = new SqlParameter("@CategoryName", cate.CategoryName);
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
        public bool DeleteCategory(string CategoryID)
        {
            string strCmd = "delete_category";
            SqlParameter id = new SqlParameter("@CategoryID", CategoryID);
            try
            {
                return _DataProvicer.ExecuteNonQuery(strCmd, CommandType.StoredProcedure, id);
            }
            catch (Exception ex)
            {
                // throw new Exception(ex.Message);
                return false;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public List<DTO.CategoryDTO> SelectAllCategoryByDataReader()
        {
            List<DTO.CategoryDTO> list = new List<DTO.CategoryDTO>();
            string strCmd = "select_all_category";
            SqlDataReader rd = _DataProvicer.ExecuteQueryWithDataReader(strCmd, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DTO.CategoryDTO dto = new DTO.CategoryDTO
                    {
                        CategoryID = rd.GetString(0),
                        CategoryName = rd.GetString(1),
                    };
                    list.Add(dto);
                }
            }
            return list;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        public DataSet SelectAllCategoryByDataSet()
        {
            string strCmd = "select_all_category";
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
        public bool IsCategoryExisted(string id)
        {
            string strCmd = "e_select_category_by_category_id";
            SqlParameter ID = new SqlParameter("@CategoryID", id);
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
