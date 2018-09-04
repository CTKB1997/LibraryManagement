using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        private string _UserID;
        private string _UserName;
        private string _Password;
        private int _Phone;
        private string _Email;
        private string _RoleID;

        public UserDTO() { }

        public UserDTO(string UserID, string UserName, string Password, int Phone, string Email, string RoleID)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.Phone = Phone;
            this.Email = Email;
            this.RoleID = RoleID;
        }

        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public int Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public string Email
        {
            get
            {
                if (_Email == null) return "No Info";
                return _Email;
            }
            set { _Email = value; }
        }
        public string RoleID
        {
            get { return _RoleID; }
            set { _RoleID = value; }
        }
    }
}
