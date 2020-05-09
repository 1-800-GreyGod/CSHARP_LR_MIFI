using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LR_MIFI
{
    class Assistant : Person
    {
        public string teacherName { get; set; }
        public Assistant() : base ()
        {
            while (true)
            {
                Console.WriteLine("Enter the teachers' name: ");
                string teacherName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(teacherName))
                {
                    Console.WriteLine("Incorrect input!");
                    continue;
                }
                else
                {
                    this.teacherName = teacherName;
                    break;
                }
            }
        }

        public Assistant(string name, int age, Teacher teacher) : base(name, age)
        {
            this.teacherName = teacher.name;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"My name is {name}, I'm {age} y.o and I'm the assistant of {teacherName}.");
        }
    }
}
