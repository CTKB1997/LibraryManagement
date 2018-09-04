using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryDTO
    {
        private string _CategoryID;
        private string _CategoryName;

        public CategoryDTO() { }

        public CategoryDTO(string CategoryID, string CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
        }

        public string CategoryName
        {
            get { return _CategoryName; }
            set { _CategoryName = value; }
        }
        public string CategoryID
        {
            get { return _CategoryID; }
            set { _CategoryID = value; }
        }
    }
}
