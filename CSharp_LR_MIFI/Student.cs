using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LR_MIFI
{
    class Student : Person
    {
        public int year { get; protected set; }
        public Student() : base()
        {            
                while (true)
                {
                    Console.WriteLine("Enter the year: ");
                    int year;
                    bool check = (Int32.TryParse(Console.ReadLine(), out year));
                    if (year < 0 || year > 5 || check == false)
                    {
                        Console.WriteLine("Incorrect input!");
                        continue;
                    }
                    else
                    {
                        this.year = year;
                        break;
                    }
                }
        }
        public Student(string name, int age, int year) : base(name, age)
        {
            this.year = year;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"My name is {name}, I'm {age} y.o and I'm a year {year} student.");
        }
        
    }
}
