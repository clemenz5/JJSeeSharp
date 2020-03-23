using System;

namespace JJSeeSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
           try { 
           Human jj = new Human("JJ", 19, gender.male);
            Console.WriteLine(jj.getName());
            Console.WriteLine(jj.getAge());
            Console.WriteLine(jj.getGender());

            jj.setGender(gender.apachecombathelicopter);
            Console.WriteLine(jj.getGender());
            try {
                jj.setAge(21);
            }
            catch(ArgumentException){
                Console.WriteLine("ungültiges Alter");
            }
            }

            catch(ArgumentException){
                Console.WriteLine("ungültiges Startalter");
            }

           
            
            

            


        } 
    }
}
