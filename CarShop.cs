namespace JJSeeSharp{
using System.Collections.Generic;
using System;
    class CarShop{

    LinkedList<car> Liste = new LinkedList<car>();
    public void storeCar(car auto){
        Liste.AddFirst(auto);
        Console.WriteLine(Liste.Count);
    }
    
    }
}