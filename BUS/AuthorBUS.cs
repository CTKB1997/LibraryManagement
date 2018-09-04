using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AuthorBUS
    {
        private DAO.AuthorDAO dao = new DAO.AuthorDAO();

        public DataTable GetAllAuthorByDataSet()
        {
            DataTable dt = dao.SelectAllAuthorByDataSet().Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }

        public bool AddNewAuthor(AuthorDTO auth)
        {
            return dao.AddNewAuthor(auth);
        }

        public bool UpdateAuthor(AuthorDTO auth)
        {
            return dao.UpdateAuthor(auth);
        }

        public bool DeleteAuthor(string id)
        {
            return dao.DeleteAuthor(id);
        }
        public bool IsAuthorExisted(string id)
        {
            return dao.IsAuthorExisted(id);
        }

    }
}
