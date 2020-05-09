using Microsoft.VisualBasic.FileIO;
using System;

namespace CSharp_LR_MIFI
{
    class Program
    {
        static void Main(string[] args)
        {

            var p = new Principal();
            var t = new Teacher();
            var s = new Student();
            p.GetInfo();
            t.GetInfo();
            s.GetInfo();
            Console.ReadKey();
        }
    }
}
