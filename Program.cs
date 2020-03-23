using System;

namespace JJSeeSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
          RandomStuff randomizer = new RandomStuff();
          
          car MyRandomCar = randomizer.getCar();
          Console.WriteLine(MyRandomCar.ToString());
            
            

            


        } 
    }
}
