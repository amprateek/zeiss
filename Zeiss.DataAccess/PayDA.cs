using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DataAccess
{
    public class CustomerDA
    {
        public string firstName;
        public string lastName;
        public string DOJ;
        public long mobile;

        public CustomerDA GetCustomerDetails(long mobile)
        {
            CustomerDA cust = new CustomerDA();
            cust.firstName = "Ram";
            cust.lastName = "Raj";
            cust.DOB = "25-07-22";
            return cust;
        }
    }
}
