using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AuthorDTO
    {
        private string _AuthorID;
        private string _AuthorName;

        public AuthorDTO() { }

        public AuthorDTO(string AuthorName, string AuthorID)
        {
            this.AuthorName = AuthorName;
            this.AuthorID = AuthorID;
        }

        public string AuthorName
        {
            get { return _AuthorName; }
            set { _AuthorName = value; }
        }
        public string AuthorID {
            get { return _AuthorID; }
            set { _AuthorID = value; }
        }
    }
}
