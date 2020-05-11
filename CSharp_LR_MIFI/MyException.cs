using System;


namespace CSharp_LR_MIFI
{
    class MyException: Exception
    {
        public MyException() : base ("This is a custom made exception")
        {

        }
        public void CheckMethod()
        {
            Console.WriteLine("Check message");
        }
    }
}
