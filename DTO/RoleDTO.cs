using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDTO
    {
        private string _RoleID;
        private string _RoleName;

        public RoleDTO() { }

        public RoleDTO(string RoleID, string RoleName)
        {
            this.RoleID = RoleID;
            this.RoleName = RoleName;
        }

        public string RoleID
        {
            get { return _RoleID; }
            set { _RoleID = value; }
        }
        public string RoleName
        {
            get { return _RoleName; }
            set { _RoleName = value; }
        }
    }
}
