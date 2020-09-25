using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of employees");
            int n = int.Parse(Console.ReadLine());
            emp[] array = new emp[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the details");
                int eno = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                string designation = Console.ReadLine();
                double salary = double.Parse(Console.ReadLine());
                array[i] = new emp(eno, name, designation, salary);
            }
            string[] s = new string[n];
             int m = 0;
            foreach (emp obj in array)
            { 
                s[m] = obj.name;
                m++;
            }
            Array.Sort(s);
            for(int i = 0; i < s.Length; i++)
            {

                for (int j = 0; j < array.Length; j++)
                {
                    if (s[i].Equals(array[j].name))
                    {
                        array[j].display();
                        break;
                    }
                }
                
                   
            }
        }
    }
}
