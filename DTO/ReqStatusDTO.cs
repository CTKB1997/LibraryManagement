using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReqStatusDTO
    {
        private int _ReqStatus;
        private string _ReqStatusInfo;

        public ReqStatusDTO(int ReqStatus, string ReqStatusInfo)
        {
            this.ReqStatus = ReqStatus;
            this.ReqStatusInfo = ReqStatusInfo;
        }

        public ReqStatusDTO() { }

        public int ReqStatus
        {
            get { return _ReqStatus; }
            set { _ReqStatus = value; }
        }
        public string ReqStatusInfo
        {
            get { return _ReqStatusInfo; }
            set { _ReqStatusInfo = value; }
        }
    }
}
