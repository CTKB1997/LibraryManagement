using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RequestDTO
    {
        private string _ReqID;
        private string _UserID;
        private string _BookTitleID;
        private DateTime _ReqDate;
        private int _ReqStatus;

        public RequestDTO() { }

        public RequestDTO(string ReqID, string UserID, string BookTitleID, DateTime ReqDate, int ReqStatus)
        {
            this.ReqID = ReqID;
            this.UserID = UserID;
            this.BookTitleID = BookTitleID;
            this.ReqDate = ReqDate;
            this.ReqStatus = ReqStatus;
        }

        public string ReqID
        {
            get { return _ReqID; }
            set { _ReqID = value; }
        }
        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public string BookTitleID
        {
            get { return _BookTitleID; }
            set { _BookTitleID = value; }
        }
        public DateTime ReqDate
        {
            get { return _ReqDate; }
            set { _ReqDate = value; }
        }
        public int ReqStatus
        {
            get { return _ReqStatus; }
            set { _ReqStatus = value; }
        }
    }
}
