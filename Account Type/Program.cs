using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Type
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<AccountType> accountList = new List<AccountType>()
            {
                new AccountType
                {
                    Type ="Saving",
                    custList= new List<Customer>()
                    {
                        new Customer()
                        {
                            Id=1,
                            Name="sam",
                            Loans= new List<Loan>()
                            {
                                new Loan()
                                {
                                    Type="home loan",
                                    RateOfInt=8,
                                },
                                new Loan()
                                {
                                    Type="car loan",
                                    RateOfInt=7.5,
                                }

                            }
                        },
                        new Customer()
                        {
                            Id = 2,
                            Name="Rupesh",
                            Loans=new List<Loan>()
                            {
                                new Loan()
                                {
                                    Type="home loan",
                                    RateOfInt=8.3,
                                }
                            }
                        },
                        new Customer()
                        {
                            Id=3,
                            Name="jay",
                            Loans=new List<Loan>()
                            {
                                new Loan()
                                {
                                    Type="Education",
                                    RateOfInt=9.1,
                                }
                            }
                        }

                    }
                },
                new AccountType
                {
                    Type ="Current",
                    custList= new List<Customer>()
                    {
                        new Customer()
                        {
                            Id=4,
                            Name="raju",
                            Loans= new List<Loan>()
                            {
                                new Loan()
                                {
                                    Type="gold loan",
                                    RateOfInt=8,
                                }
                            }
                        },
                         new Customer()
                        {
                            Id=5,
                            Name="ajay",
                            Loans= new List<Loan>()
                            {
                                new Loan()
                                {
                                    Type="gold loan",
                                    RateOfInt=10,
                                }
                            }
                        },
                          new Customer()
                        {
                            Id=6,
                            Name="vijay",
                            Loans= new List<Loan>()
                            {
                                new Loan()
                                {
                                    Type="credit card loan",
                                    RateOfInt=13,
                                }
                            }
                        },
                           new Customer()
                           {   
                            Id=7,
                            Name="karan",
                            Loans= new List<Loan>()
                            {
                                new Loan()
                                {
                                    Type="credit card loan",
                                    RateOfInt=13,
                                }
                            }
                           }
                    }

                }
            }; 
            foreach(AccountType a in accountList)
            {
                Console.WriteLine(a.Type);
                foreach(Customer c in a.custList)
                {
                    Console.WriteLine("\t"+c.Name+" "+c.Id+" ");
                    foreach (Loan l in c.Loans)
                    {
                        Console.WriteLine("  \t" + l.Type + " " + l.RateOfInt + " ");
                    }

                }
            }
        }
    }
};


        
    
    public class Loan
{
    public string Type { get; set; }
    public double RateOfInt { get; set; }
}
public class Customer
{
    public string Name { get; set; }
    public int Id { get; set; }
    public List<Loan> Loans = new List<Loan>();
}
public class AccountType
{
    public string Type { get; set; }
    public List<Customer> custList = new List<Customer>();
}

