using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookStatusDTO
    {
        private int _Status;
        private string _StatusInfo;

        public BookStatusDTO() { }

        public BookStatusDTO(int Status, string StatusInfo)
        {
            this.Status = Status;
            this.StatusInfo = StatusInfo;
        }

        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string StatusInfo
        {
            get { return _StatusInfo; }
            set { _StatusInfo = value; }
        }
    }
}
