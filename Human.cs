using JJSeeSharp;

using System;
namespace JJSeeSharp
{
    class Human{
      private string mName;
      private int mAge;
      private gender mSex = gender.apachecombathelicopter;

      public Human(string name, int age, gender sex){
        
        if (age < 0){
          throw new ArgumentException();
        }
        else {
        mName = name;
        mAge = age;
        mSex = sex;
      }
      }

      public string getName(){
          return mName;
      }

      public int getAge(){
          return mAge;
      }

       public gender getGender(){
          return mSex;
      }

      public void setGender(gender sex){
        mSex = sex;
      } 

         public void setAge(int age){
        if(mAge > age) {
        throw new ArgumentException();
        }
        else {
        mAge = age;
        }
      } 
      
      

}
}