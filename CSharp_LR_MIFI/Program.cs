
using System;


namespace CSharp_LR_MIFI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Principal
            //var p = new Principal();          
            //var pd = new Action(p.Sleep);
            //pd += p.Eat;
            //pd += p.BeLate;
            //pd?.Invoke();
            #endregion

            var t = new Teacher("t",20,(Subject) 2);
            var s = new Student("S1", 18, 1);
            var s1 = new Student("S1",18,1);
            var s2 = new Student("S1", 18, 1);
            var sample = new Student[] { s, s1, s2 };
            var ex = new MyException();
            t.Error += ex.CheckMethod;
            t.AbsentCount(sample);
            Console.ReadKey();
        }

 
    }
}
