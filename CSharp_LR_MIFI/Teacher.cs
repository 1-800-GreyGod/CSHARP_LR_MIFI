using System;


namespace CSharp_LR_MIFI
{
    
    enum Subject
    {
        none,
        programming,
        nits
    }
    class Teacher : Person, IPerson, IDepartmentWorker
    {
        public delegate void CountErrorHandler();
        public event CountErrorHandler Error;
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
        public override void GetInfo()
        {
            Console.WriteLine($"My name is {name}, I'm {age} y.o and I'm the teacher of {subject}.");
        }

        public void Sleep()
        {
            Console.WriteLine("*Sleeps peacefully*");
        }

        public void Eat()
        {
            Console.WriteLine("*Goes to the canteen*");   
        }

        public void BeLate()
        {
            Console.WriteLine("Sorry, I had a very important meeting. ");
        }

        public void AskAQuestion(Student student)
        {
            Console.WriteLine($"So, {student.name}, what is the mane principle of nuclear power plant work ");
        }

        public void AbsentCount(Student[] students)
        {

            try
            {
                var absent = new char[2];
                for(int i=0; i<=students.Length;i++)
                {
                    absent[i] = '+';
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Error?.Invoke();
            }
            finally
            {
                Console.WriteLine("Process terminated");
            }
        }
    }
}
