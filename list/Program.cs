using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee()
            //{
            //    name = "shrey",
            //    age = 22,
            //    designation = "developer"
            //};
            //Employee emp2 = new Employee()
            //{
            //    name = "ram",
            //    age = 21,
            //    designation = "developer"
            //};
            //Employee emp3 = new Employee()
            //{
            //    name = "shyam",
            //    age = 23,
            //    designation = "developer"
            //};

            //List<Employee> EmpList = new List<Employee>();
            //EmpList.Add(emp1);
            //EmpList.Add(emp2);
            //EmpList.Add(emp3);

            //foreach (Employee emp in EmpList)
            //{
            //    Console.WriteLine("Employee name : {0}  Age is : {1}  Designation is : {2}",emp.name,emp.age,emp.designation);
            //}

            List<int> myNumbers = new List<int>();
            myNumbers.Add(11);
            myNumbers.Add(12);
            myNumbers.Add(13);
            myNumbers.Add(14);

            Console.WriteLine(myNumbers[2]);

            //List<string> names = new List<string>();
            //names.Add("shrey");
            //names.Add("ram");
            //names.Add("shyam");
            //names.Add(null);
            //names.Add("shrey");

            //foreach (int item in myNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (string item in names)
            //{
            //    Console.WriteLine(item);
            //}



            // For Sorting -------------------------------->>>>
            //List<int> myNumbers = new List<int>();
            //myNumbers.Add(14);
            //myNumbers.Add(11);
            //myNumbers.Add(13);
            //myNumbers.Add(12);
            //myNumbers.Add(13);

            /*Console.WriteLine(myNumbers.Count);   */          // count property


            //foreach (int item in myNumbers)
            //{
            //    Console.WriteLine(item);
            //}


            //myNumbers.Sort();             //  sort property
            /*myNumbers.AddRange(myNumbers);*/  //   add Range method
            //myNumbers.Insert(1, 10);               // insert method
            //myNumbers.InsertRange(2,myNumbers);      // insert range method 
            //myNumbers.Remove(12);                 // remove method
            //myNumbers.RemoveAt(4);                  // remove at method
            //myNumbers.RemoveRange(2,3);                 // RemoveRange method

            //Console.WriteLine("----------------------------");

            //foreach (int item in myNumbers)
            //{
            //    Console.WriteLine(item);
            //}




            Console.ReadLine();
        }
    }
}
