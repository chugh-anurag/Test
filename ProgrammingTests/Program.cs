using System;
using System.Linq;
using Data;
using Data.Interfaces;
using Entities;
using System.Collections.Generic;

namespace ProgrammingTests
{
    public class Program
    {
        private static ITestRepository _testRepository; 

        private static void Main(string[] args)
        {
            // instantiate the Test Repo
            _testRepository = new TestRepository();

            /*
             * Object Model redesign and implementation tasks
             * 
             * 1. Read through the object model and data used to create our test repository
             * 2. Write an abstract class from which IrishCompany, SoleTrader and ForeignCompany will inherit
             * 3. Write an Interface for the Address Class, implement it and refactor 
             *    all classes which require an address to use the new interface instead. 
             * 4. Implement FindAllCompanies method in Test Repository
             * 5. Implement NumberOfYearsEmployed property on Employment.
             */

            /*
             *  Linq queries and Algorithms
             * 
             * 1. Get Count of all Companies(Sole traders, Irish and Foreign Companies) in the "Database"
             * 2. Write a linq query to find all Employees still employed by Company "Irish1" and write out their names
             * 3. Write a query to find the total number of years that all employees (still employed or not) have worked.               
             * 
             * 4. Implement the FizzBuzz method below exactly to requirements
             * 5. Implement ReverseWords to requirements, taking care that it 
             *    doesn't fail for any of the cases in TestAlgorithms
             * 
             */

            TestAlgorithms();
            TestLinqQueries();
        }

        public static void TestLinqQueries()
        {
            TestRepository testRepo = new TestRepository();
            int countCompanies = (from n in testRepo.IrishCompanies
                                  select n).Count()+
                                  (from n in testRepo.ForeignCompanies
                                   select n).Count() +
                                   (from n in testRepo.SoleTraders
                                    select n).Count();

            
            var empNames = from n in testRepo.IrishCompanies
                           from m in n.Employments
                           where n.Name == "Irish1" && m.EmploymentEndDate > DateTime.Today
                           select m.Employee.Name;

            int countEmployees = (from n in testRepo.IrishCompanies
                                  from m in n.Employments
                                  select m).Count() +
                                  (from n in testRepo.SoleTraders
                                   from m in n.Employments
                                   select m).Count() +
                                   (from n in testRepo.ForeignCompanies
                                    from m in n.Employments
                                    select m).Count();
        }

        public static void TestAlgorithms()
        {
            FizzBuzz();
            Console.ReadLine();

            ReverseWords("This is a programming test");
            Console.ReadLine();

            ReverseWords("");
            Console.ReadLine();

            ReverseWords(null);
            Console.ReadLine();

        }


        /// <summary>
        /// </summary>
        public static void FizzBuzz()
        {
            /*
                Fizz Buzz
             * 
             * using an array from 1 - 100
             * 
             * Print the word "Fizz" for each multiple of 3
             * Print the word "Buzz" for each multiple of 5
             * Print the word "FizzBuzz" for each multiple of 3 & 5
             * else print the number
             * 
             */
            int[] arr = Enumerable.Range(1, 100).ToArray();
            foreach(int i in arr)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine("{0}",i);
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sentence"></param>
        public static string ReverseWords(string sentence)
        {
            /*
             * write a function to reverse the words in a string which 
             * does not use a framework reverse method
             * 
             * should test for nulls, empty string etc
             * 
             * Bonus Points if you can write this as an Extension Method
             */
            String[] sentArr = sentence.Split(' ');
            String revSentence = null;
            for(int i = sentArr.Length - 1; i >=0 ; i--)
            {
                revSentence += (sentArr[i] + " ");
            }
            return revSentence;
        }
    }
}
