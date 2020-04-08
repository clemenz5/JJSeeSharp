namespace JJSeeSharp{
using System;

class Controller
{
    const string newCar = "Neues Auto";
    const string exit = "Exit"; 
    const string newLine = "";
    
   public Controller(){ 
   int i = 1;
   Console.WriteLine("Start");
    while(i==1){
               string input;
        input = Console.ReadLine();

    if (input.Equals(newCar)){
        car Auto = new RandomStuff().getCar();
        Console.WriteLine(Auto);
    }
    else if (input.Equals(exit)){
        i = 2;
        Console.WriteLine("Programm beendet");
    }
    else if (input.Equals(newLine)){
       
    }
    else {
       Console.WriteLine("Befehl nicht erkannt");
   }
   }
   
   } 
}
}
