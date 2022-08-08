using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.BL;

namespace Zeiss.PaySlip
{ 
    public class PaySlip
    {
        string custFirstName;
        string custLastName;
        DateTime DOB;
        long mobile;

        public void PrintCustomerDetails(long mobile)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Details of Customer with mobile number " + mobile);
            Console.WriteLine("-----------------------");
            CustomerBL cust = new CustomerBL();
            cust = cust.GetCustDetails(mobile);
            Console.WriteLine("Name :" + cust.firstName+ " " + cust.lastName);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Date of Birth :" + cust.DOB);
            Console.WriteLine("-----------------------");
        }
    }
}
