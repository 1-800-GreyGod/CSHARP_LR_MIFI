﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharp_LR_MIFI
{
    enum Subject
    {
        none,
        programming,
        nits
    }
    class Teacher : Person
    {
        public Subject subject { get; set; }
        
        public Teacher() : base()
        {
            while (true)
            {
                Console.WriteLine("Enter the subject");
                string subject = Console.ReadLine();
                if (Enum.IsDefined(typeof(Subject), subject.ToLower()) == false)
                {
                    Console.WriteLine("Subject doesn't exist");
                    continue;
                }
                else
                {
                    this.subject = (Subject)Enum.Parse(typeof(Subject), subject.ToLower());
                    break;
                }
            }
        }

        public Teacher(string name, int age, Subject subject) : base(name, age)
        {
            this.subject = subject;
        }
        public void GetInfo()
        {
            Console.WriteLine($"My name is {name}, I'm {age} y.o and I'm the teacher of {subject}.");
        }
    }
}
