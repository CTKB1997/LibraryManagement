using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class UserBUS
    {
        private DAO.UserDAO dao = new DAO.UserDAO();

        public int CheckLogin(string UserID, string Password)
        {
            return dao.CheckLogin(UserID, Password);
        }

        public DataTable getAllUserByDataSet()
        {
            DataTable dt = dao.SelectAllUserByDataSet().Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }

        public bool AddNewUser(UserDTO user)
        {
            return dao.AddNewUser(user);
        }

        public bool UpdateUser(UserDTO user)
        {
            return dao.UpdateUser(user);
        }

        public bool DeleteUser(string userID)
        {
            return dao.DeleteUser(userID);
        }
        public bool IsUserExisted(string id)
        {
            return dao.IsUserExisted(id);
        }
    }
}
