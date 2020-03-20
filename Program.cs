using System;

namespace JJSeeSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
           Human jj = new Human("JJ", 19, Gender.male);
            Console.WriteLine(jj.getName());
        }
    }
}
