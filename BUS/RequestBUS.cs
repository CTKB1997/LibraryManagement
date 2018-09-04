using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class RequestBUS
    {
        private DAO.RequestDAO dao = new DAO.RequestDAO();

        private string getNewReqID()
        {
            int ans = 0;
            List<DTO.RequestDTO> list = dao.SelectAllAuthorByDataReader();
            foreach(DTO.RequestDTO dto in list) 
            {
                string num = dto.ReqID.Substring(3);
                if (int.Parse(num) > ans)
                {
                    ans = int.Parse(num);
                }
            }
            ans++;
            return "req" + ans.ToString();
        }

        public bool AddNewRequest(string UserID, string BookTitleID)
        {
            RequestDTO req = new RequestDTO
            {
                ReqID = getNewReqID(),
                UserID = UserID,
                BookTitleID = BookTitleID,
                ReqDate = DateTime.Today,
                ReqStatus = 0
            };
            return dao.AddNewRequest(req);
        }

        private DTO.RequestDTO SearchRequestByRequestID(string id)
        {
            return dao.SearchRequestByRequestID(id);
        }

        public bool UpdateRequest(string id, int status)
        {
            DTO.RequestDTO dto = this.SearchRequestByRequestID(id);
            dto.ReqStatus = status;
            return dao.UpdateRequest(dto);
        }

        public DataTable SelectRequestByRequestStatus(int status)
        {
            DataTable dt = dao.SelectRequestByRequestStatus(status).Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }

        public DataTable SelectRequestByUserID(string UserID)
        {
            DataTable dt = dao.SelectRequestByUserID(UserID).Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }

        public DataTable SelectAllRequest()
        {
            DataTable dt = dao.SelectAllRequestByDataSet().Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }
    }
}
