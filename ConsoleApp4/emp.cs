using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Text;

namespace ConsoleApp4
{
    class emp
    {
       public  int eno;
        public string name, designation;
        double salary;
        public emp(int eno, String name,string designation,double salary)
        {
            this.eno = eno;
            this.name = name;
            this.designation = designation;
            this.salary = salary;


        }
        public void display()
        {
            Console.WriteLine("emp no=" + eno);
            Console.WriteLine("name=" + name);
            Console.WriteLine("designation=" + designation);
            Console.WriteLine("salary=" + salary);
        }

    }
}
