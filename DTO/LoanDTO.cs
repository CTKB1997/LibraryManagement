using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoanDTO
    {
        private string _LoanID;
        private string _ReqID;
        private string _BookID;
        private DateTime _ExpiredDate;
        private DateTime _BorrowedDate;
        private int _Status;

        public LoanDTO() { }

        public LoanDTO(string LoanID, string ReqID, string BookID, DateTime ExpiredDate, DateTime BorrowedDate, int Status)
        {
            this.LoanID = LoanID;
            this.ReqID = ReqID;
            this.BookID = BookID;
            this.ExpiredDate = ExpiredDate;
            this.BorrowedDate = BorrowedDate;
            this.Status = Status;
        }

        public string LoanID
        {
            get { return _LoanID; }
            set { _LoanID = value; }
        }
        public string ReqID
        {
            get { return _ReqID; }
            set { _ReqID = value; }
        }
        public string BookID
        {
            get { return _BookID; }
            set { _BookID = value; }
        }
        public DateTime ExpiredDate
        {
            get { return _ExpiredDate; }
            set { _ExpiredDate = value; }
        }
        public DateTime BorrowedDate
        {
            get { return _BorrowedDate; }
            set { _BorrowedDate = value; }
        }
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
    }
}
