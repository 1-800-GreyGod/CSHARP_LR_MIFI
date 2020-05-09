using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LR_MIFI
{
    class Assistant : Person, IPerson, IDepartmentWorker
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

        public void Sleep()
        {
            Console.WriteLine("I can't sleep, I have to finish my work");
        }

        public void Eat()
        {
            Console.WriteLine("*Cooks instant noodles*");
        }

        public void BeLate()
        {
            Console.WriteLine($"So, what have you studied with {teacherName} on the last lecture?");
        }

        public void AskAQuestion(Student student)
        {
            Console.WriteLine($"So, {student.name}, what is a square root of 4?");
        }
    }
}
