using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                while(true)
                {
                    Details d = new Details();

                    Console.WriteLine("Enter the name:");
                    d.Name = Console.ReadLine();

                    Console.WriteLine("Enter the Age:");
                    d.Age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter RollNo:");
                    d.RollNo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter marks:");
                    d.Marks = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter percentage:");
                    d.Percentage = Convert.ToDouble(Console.ReadLine());
                    if (d.valid())
                    {
                        Console.WriteLine(d.valid());
                    }
                    Console.WriteLine("Do you want to search another student press 1-yes or 2 -no");
                    int select = Convert.ToInt32(Console.ReadLine());

                    
                    if(select<1 )
                    {
                        break;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("invalid input");
            }
            }
        }
    }
    class Details

    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int RollNo { get; set; }
        public int Marks { get; set; }
        public double Percentage { get; set; }
        public bool valid()
            {
            if (Marks > 35)
            {
                Console.WriteLine("Student is pass :"+Marks);
            }
            else
            {
                Console.WriteLine("Student is fale"+Marks);
            }
            if(Percentage>50)
            {
                Console.WriteLine("Student is qulified with{0}",Percentage);
            }
            else
            {
                Console.WriteLine("Student is not qulified {0}",Percentage);
            }
            return false;
            }
    }

