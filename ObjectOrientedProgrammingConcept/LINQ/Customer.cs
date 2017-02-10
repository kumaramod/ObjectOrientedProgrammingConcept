using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConcept.LINQ
{
    public class Customer
    {
        public int  CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCity { get; set; }
    }


    public class CustomerDetails
    {
        public int ID { get; set; }
        public long CustomerMobileNumber { get; set; }
        public DateTime CustomerPurchageDate { get; set; }
        public int CustomerID { get; set; }
    }
}
