using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BookTitleBUS
    {
        private DAO.BookTitleDAO dao = new DAO.BookTitleDAO();

        public DataTable GetAllBookTitleByDataSet()
        {
            DataTable dt = dao.SelectAllBookTitleByDataSet().Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }

        public bool AddNewBookTitle(BookTitleDTO bt)
        {
            return dao.AddNewBookTitle(bt);
        }

        public bool UpdateBookTitle(BookTitleDTO bt)
        {
            return dao.UpdateBookTitle(bt);
        }

        public bool DeleteBookTitle(string id)
        {
            return dao.DeleteBookTitle(id);
        }

        public bool IsBookTitleIDExisted(string id)
        {
            return dao.IsBookTitleIDExisted(id);
        }

    }
}
