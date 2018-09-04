using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class CategoryBUS
    {
        private DAO.CategoryDAO dao = new DAO.CategoryDAO();

        public DataTable getAllCategoryByDataSet()
        {
            DataTable dt = dao.SelectAllCategoryByDataSet().Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }

        public bool AddNewCategory(CategoryDTO cate)
        {
            return dao.AddNewCategory(cate);
        }

        public bool UpdateCategory(CategoryDTO cate)
        {
            return dao.UpdateCategory(cate);
        }

        public bool DeleteCategory(string id)
        {
            return dao.DeleteCategory(id);
        }

        public bool IsCategoryIDExisted(string id)
        {
            return dao.IsCategoryExisted(id);
        }
    }
}
