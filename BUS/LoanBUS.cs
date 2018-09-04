using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class LoanBUS
    {
        private DAO.LoanDAO dao = new DAO.LoanDAO();

        private string getNewLoan()
        {
            int ans = 0;
            Console.WriteLine(ans);
            List<DTO.LoanDTO> list = dao.SelectAllLoanByDataReader();
            foreach (DTO.LoanDTO dto in list)
            {
                string num = dto.LoanID.Substring(4);
                if (int.Parse(num) > ans)
                {
                    ans = int.Parse(num);
                }
            }
            ans++;
            return "loan" + ans.ToString();
        }

        public bool AddNewLoan(string ReqID, string BookID)
        {
            LoanDTO loan = new LoanDTO
            {
                LoanID = getNewLoan(),
                ReqID = ReqID,
                BookID = BookID,
                BorrowedDate = DateTime.Today,
                ExpiredDate = DateTime.Today.AddDays(15),
                Status = 0
            };
            bool result = dao.AddNewLoan(loan);
            return result;
        }
        public DataTable getLoanByID(string UserID)
        {
            DataTable dt = dao.SelectLoanByID(UserID).Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }
        public DataTable getAllLoans()
        {
            DataTable dt = dao.SelectAllLoanByDataSet().Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;

        }

        public DataTable getLoanByStatus(int status)
        {
            DataTable dt = dao.SelectLoanByStatus(status).Tables[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }

        public bool UpdateLoanStatusByLoanID(string loanID, int status)
        {
            return dao.UpdateLoanStatusByLoanID(loanID, status);
        }
    }
}
