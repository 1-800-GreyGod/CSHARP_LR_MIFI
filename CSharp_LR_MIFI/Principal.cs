using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LR_MIFI
{
    enum Department
    {
        none,
        sis

    }
    class Principal : Person
    {
        public Department department { get; set; }
        public Principal() : base()
        {
            while (true)
            {
                Console.WriteLine("Enter the department: ");
                string department=Console.ReadLine();
                if(Enum.IsDefined(typeof(Department),department.ToLower())==false)
                {
                    Console.WriteLine("Department doesn't exist");
                    continue;
                }
                else
                {
                    this.department = (Department)Enum.Parse(typeof(Department), department.ToLower());
                    break;
                }

            }
        }

        public Principal(string name, int age, Department department) : base(name, age)
        {
            this.department = department;
        }
        public void GetInfo()
        {
            Console.WriteLine($"My name is {name}, I'm {age} y.o and I'm the principal of {department} department.");
        }
    }
}
