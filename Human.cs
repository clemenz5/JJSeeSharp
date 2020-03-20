
using System;
namespace JJSeeSharp
{
    class Human{
      private string mName;
      private int mAge;
      private Gender mSex = Gender.apachecombathelicopter;

      public Human(string name, int age, Gender sex){
        mName = name;
        mAge = age;
        mSex = sex;
      }

      public String getName(){
          return mName;
      }
      

}
}