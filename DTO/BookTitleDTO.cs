using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookTitleDTO
    {
        private string _BookTitleID;
        private string _Title;
        private string _AuthorID;
        private string _CategoryID;

        public BookTitleDTO(string BookTitleID, string Title, string AuthorID, string CategoryID)
        {
            this.BookTitleID = BookTitleID;
            this.Title = Title;
            this.AuthorID = AuthorID;
            this.CategoryID = CategoryID;
        }

        public BookTitleDTO() { }

        

        public string BookTitleID
        {
            get { return _BookTitleID; }
            set { _BookTitleID = value; }
        }
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        public string AuthorID
        {
            get { return _AuthorID; }
            set { _AuthorID = value; }
        }
        public string CategoryID
        {
            get { return _CategoryID; }
            set { _CategoryID = value; }
        }
    }
}
