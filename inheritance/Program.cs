using System;

namespace inheritance
{
    class VisitingEmployees : Employees
    {
        public int VisitingSalary;
        public int VisitingHours;
    }

    class PermanentEmployees : Employees
    {
        public int PermanentSalary;
        public int PermanentHours;
    }

    class Employees
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public int EmpContactNo;
    }


    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployees shrey = new PermanentEmployees();
            shrey.EmpId = 25185;



            VisitingEmployees ansh = new VisitingEmployees();
            ansh.EmpId = 25139;


            Console.WriteLine(shrey.EmpId);
            Console.WriteLine(ansh.EmpId);
            Console.ReadLine();
        }
    }
}
