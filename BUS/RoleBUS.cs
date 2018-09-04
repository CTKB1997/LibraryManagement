using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RoleBUS
    {
        private DAO.RoleDAO dao = new DAO.RoleDAO();

        public bool IsRoleExisted(string id)
        {
            return dao.IsRoleExisted(id);
        }
    }
}
