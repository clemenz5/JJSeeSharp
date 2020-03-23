namespace JJSeeSharp{
using System;

class RandomStuff{

Random rnd = new Random();

public RandomStuff(){

}

public car getCar(){
    car MySummerCar = new car(getRandomColour(), getRandomBrand(), new car.seat(getRandomBool(), car.seat.rating.ss, car.seat.material.gold, rnd.Next(0,99)),rnd.Next(1,22));
    return MySummerCar; 
}

bool getRandomBool(){
    if(rnd.Next(0, 2)==1){  
    return true;
    }
    else return false;
}

car.farbe getRandomColour(){
   int rndmnumber = rnd.Next(0, 4);
   if(rndmnumber == 0)
   { return car.farbe.red;}

   if (rndmnumber == 1)
   { return car.farbe.green;}

   if(rndmnumber == 2)
   { return car.farbe.dingding;}

   else
   { return car.farbe.mxkaercher;}
}

car.brand getRandomBrand(){
   int rndmnumber = rnd.Next(0, 5);
   if(rndmnumber == 0)
   { return car.brand.vw;}

   if (rndmnumber == 1)
   { return car.brand.audi;}

   if(rndmnumber == 2)
   { return car.brand.ford;}

    if (rndmnumber == 3)
    { return car.brand.mx5;}

   else
   { return car.brand.babawagen;}
    }
 }

}

