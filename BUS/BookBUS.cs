using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BookBUS
    {
        private DAO.BookDAO dao = new DAO.BookDAO();

        public DataTable getAllBookIDByDataSet()
        {
            DataTable dt = dao.SelectAllBookByDataSet().Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }

        public bool AddNewBookID(BookDTO book)
        {
            return dao.AddNewBook(book);
        }

        public bool UpdateBook(BookDTO book)
        {
            return dao.UpdateBook(book);
        }

        public bool DeleteAuthor(string id)
        {
            return dao.DeleteBook(id);
        }
        public bool IsBookIDExisted(string id)
        {
            return dao.IsBookIDExisted(id);
        }
    }
}
