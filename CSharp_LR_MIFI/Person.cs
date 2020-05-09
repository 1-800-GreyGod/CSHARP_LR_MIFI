using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LR_MIFI
{
   
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person ()
        {
            while (true)
            {
                Console.WriteLine("Enter the name: ");
                string name=Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Incorrect input!");
                    continue;
                }
                else
                {
                    this.name = name;
                    break;
                }
               
            }
            while (true)
            {
                Console.WriteLine("Enter the age: ");
                {
                    int age;
                    bool check = (Int32.TryParse(Console.ReadLine(), out age));
                    if (age<0 || age> 150 || check==false)
                    {
                        Console.WriteLine("Incorrect input!");
                        continue;
                    }
                    else
                    {
                        this.age = age;
                        break;
                    }
                }
            }
            
        }
    }
}
