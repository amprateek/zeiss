using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.DataAccess;

namespace Zeiss.BL
{
    public class CustomerBL
    {
        public string firstName;
        public string lastName;
        public string DOB;
        public long mobile;


        public CustomerBL GetCustDetails(string custID)
        {
            CustomerDA custD1 = new CustomerDA();
            custD1 = custD1.GetCustomerDetails(mobile);

            CustomerBL custB1 = new CustomerBL();
            custB1.custId = custD1.custID;
            custB1.firstName = custD1.firstName;
            custB1.lastName = custD1.lastName;
            custB1.DOB = custD1.DOB;

            return custB1;
        }
    }
}
