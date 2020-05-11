using System;


namespace CSharp_LR_MIFI
{
    class Student : Person, IPerson
    {
        public int year { get; set; }
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

        public void Sleep()
        {
            Console.WriteLine("I can't sleep, I have to study. ");
        }

        public void Eat()
        {
            Console.WriteLine("*Cooks instant noodles*");
        }

        public void BeLate()
        {
            Console.WriteLine("I'm sorry I'm late, can I join the class?");
        }
    }
}
