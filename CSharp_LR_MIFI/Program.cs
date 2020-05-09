using Microsoft.VisualBasic.FileIO;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharp_LR_MIFI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            var p = new Principal();
            var pd = new Action(p.Sleep);
            pd += p.Eat;
            pd += p.BeLate;
            pd?.Invoke();
            #region Teacher
            //var t = new Teacher();
            //var td = new Action(t.Sleep);
            //td += t.Eat;
            //td += t.BeLate;
            //td?.Invoke();
            #endregion
            #region Student
            //var s = new Student();
            //var sd = new Action(s.Sleep);
            //sd += s.Eat;
            //sd += s.BeLate;
            //sd?.Invoke();
            #endregion
            #region Assistant
            //var a = new Assistant();
            //var ad = new Action(a.Sleep);
            //ad += a.Eat;
            //ad += a.BeLate;
            //ad?.Invoke();
            #endregion

            Console.ReadKey();
        }
    }
}
