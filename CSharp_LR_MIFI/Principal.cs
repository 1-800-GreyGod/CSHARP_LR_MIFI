using System;


namespace CSharp_LR_MIFI
{
    enum Department
    {
        none,
        sis

    }
    class Principal : Person, IPerson, IDepartmentWorker
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
        public override void GetInfo()
        {
            Console.WriteLine($"My name is {name}, I'm {age} y.o and I'm the principal of {department} department.");
        }

        public void Sleep()
        {
            Console.WriteLine("*Sleeps peacefully*");
        }

        public void Eat()
        {
            Console.WriteLine("*Orders food on-line*");
        }

        public void BeLate()
        {
            Console.WriteLine("I'm not late, you all came early!");
        }

        public void AskAQuestion(Student student)
        {
            Console.WriteLine($"So, {student.name}, what is the so-called 'brother' of the deleterious code?");
        }

    }
}
