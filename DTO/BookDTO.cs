using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookDTO
    {
        private string _BookID;
        private string _BookTitleID;

        public BookDTO(string BookID, string BookTitleID)
        {
            this.BookID = BookID;
            this.BookTitleID = BookTitleID;
        }

        public BookDTO() { }

        public string BookTitleID
        {
            get { return _BookTitleID; }
            set { _BookTitleID = value; }
        }
        public string BookID
        {
            get { return _BookID; }
            set { _BookID = value; }
        }
    }
}
