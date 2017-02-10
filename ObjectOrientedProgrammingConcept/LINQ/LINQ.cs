using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConcept.LINQ
{
    public class LINQ
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer {
                    CustomerID=101,
                    CustomerName="Amod",
                    CustomerCity="Patna"
                },
                new Customer {
                    CustomerID=102,
                    CustomerName="Pravin",
                    CustomerCity="Agra"
                },
                new Customer {
                    CustomerID=103,
                    CustomerName="Praphakar",
                    CustomerCity="Patna"
                }
            };

            List<CustomerDetails> customerDetails = new List<CustomerDetails>()
            {
                new CustomerDetails {
                    ID=1,
                    CustomerMobileNumber=8588954491,
                    CustomerPurchageDate=new DateTime(),
                    CustomerID=101
                },
                new CustomerDetails {
                    ID=2,
                    CustomerMobileNumber=8588954455,
                    CustomerPurchageDate=new DateTime(),
                    CustomerID=102
                },
                new CustomerDetails {
                    ID=3,
                    CustomerMobileNumber=8588954466,
                    CustomerPurchageDate=new DateTime(),
                    CustomerID=103
                }
            };
            Console.WriteLine("----------------------Example of LINQ Obtaing DataSource------------------------");
            var customerList = from cust in customers
                               select cust;

            //Print Result
            foreach (var customer in customerList)
            {
                Console.WriteLine("Customer Name={0}, Customer City={1}", customer.CustomerName, customer.CustomerCity);
            }

            Console.WriteLine("---------------------------Example of order by----------------------------------");
            var queryLondonCustomers3 = from cust in customers
                                        where cust.CustomerCity == "Patna"
                                        orderby cust.CustomerName ascending
                                        select cust;

            foreach (var customer in queryLondonCustomers3)
            {
                Console.WriteLine("Customer Name={0}, Customer City={1}", customer.CustomerName, customer.CustomerCity);
            }

            Console.WriteLine("---------------------------Example of group by----------------------------------");
            
            var customerListByGroupBy = from cust in customers
                               group cust by cust.CustomerCity;

            foreach (var customerGroup in customerListByGroupBy)
            {
                Console.WriteLine("Group by City= {0}", customerGroup.Key);
                foreach (Customer customer in customerGroup)
                {
                    Console.WriteLine("Customer Name={0}, Customer City={1}", customer.CustomerName, customer.CustomerCity);
                }
            }

            Console.WriteLine("------------------------------Join Example--------------------------------------");

            var innerJoinQuery = from cust in customers
                                 join custDetails in customerDetails on cust.CustomerID equals custDetails.CustomerID
                                 select new { CustomerName = cust.CustomerName, CustomerCity = cust.CustomerCity, CustomerMobileNumber= custDetails.CustomerMobileNumber };

            var innerJoinQuery1 = from cust in customers
                                 join custDetails in customerDetails on cust.CustomerID equals custDetails.CustomerID
                                 select new { cust.CustomerName, cust.CustomerCity, custDetails.CustomerMobileNumber };

            foreach (var customer in innerJoinQuery)
            {
                Console.WriteLine("Customer Name={0}, Customer City={1}, Customer Mobile Number={2}", customer.CustomerName, customer.CustomerCity, customer.CustomerMobileNumber);
            }

            Console.ReadKey();
        }
    }
}
