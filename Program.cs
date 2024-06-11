using System;

namespace HelloWorld
{
  // class Program
  // class Car
  // {
    // string color = "Blue";
    // int maxSpeed = 200;


    // String color;
    // String model;
    // int year;
    // int maxSpeed;



    // static void Main(string[] args)
    // {
    //   Console.WriteLine("SUMIT SHAH"); 

    //   Console.WriteLine(5+5);   

    //   Console.Write("SUMIT");
    //   Console.Write("SHAH");

    // string name = "Sumit";

    // Console.WriteLine("Enter your name");

    // string userName = Console.ReadLine();

    // Console.WriteLine(userName.ToUpper());


    // Car myObj1 = new Car();
    // Car myObj2 = new Car();
    // Console.WriteLine(myObj1.color);
    //  Console.WriteLine(myObj2.color);


    // Car myObj = new Car ();
    // Console.WriteLine(myObj.color);


    // Car myObj = new Car();
    // Console.WriteLine(myObj.color);
    // Console.WriteLine(myObj.maxSpeed);



    // Car myObj = new Car ();
    // myObj.color = "Blue";
    // myObj.maxSpeed = 200;
    // Console.WriteLine(myObj.color);
    // Console.WriteLine(myObj.maxSpeed);

  //   Car Ford = new Car();
  //   Ford.model = "Mustang";
  //   Ford.color = "Black";
  //   Ford.year = 1999;


  //   Car Hero = new Car();
  //   Hero.model = "Splendor";
  //   Hero.color = "Blue";
  //   Hero.year = 1999;


  //   Console.WriteLine(Ford.model);
  //   Console.WriteLine(Hero.model);

  //   }
  // }





  // CONSTRUCTOR
  // A CONSTRUCTOR IS A SPECIAL METHOD THAT IS USED TO INITIALIZE OBJECT.
  // class Bike 
  // {
  //   public string model;

  //   public Bike()
  //   {
  //     model = "Splendor";
  //   }

  //   static void Main(String[] args)
  //   {
  //     Bike Hero = new Bike();
  //     Console.WriteLine(Hero.model);
  //   }

  // }


  // CONSTRUCTOR PARAMETERS
  // class Bike
  // {
  //   public string model;
  //   public string color;
  //   public int year;

  //   public Bike(string modelName, string modelColor, int modelYear)
  //   {
  //     model = modelName;
  //     color = modelColor;
  //     year = modelYear;
  //   } 
  //   static void Main(String[] args)
  //   {
  //     Bike Hero = new Bike("Splendor", "Black", 1999);
  //     Console.WriteLine(Hero.model + " " + Hero.color + " " + Hero.year);
  //   }

  // }





  // ENCAPSULATION
  // class Person
  // {
  //   private string name;

  //   public string Name
  //   // {
  //   //   get { return name;}
  //   //   set {name = value;}
  //   // }


  //   {get; set;}
  // }

  // class Program
  // {
  //   static void Main(string[] args)
  //   {
  //     Person myObj = new Person();
  //     myObj.Name = "SUMIT";
  //     Console.WriteLine(myObj.Name);
  //   }
  // }






  // //INHERITANCE
  // class Bike
  // {
  //   public string brand = "Hero";
  //   public void honk()
  //   {
  //     Console.WriteLine("Pipp, pippp!");

  //   }
  // }

  // class Hero : Bike
  // {
  //   public string modelName = "Splendor";

  // }

  // class Program
  // {
  //   static void Main(String[] args)
  //   {
  //     Hero myBike = new Hero();
  //     myBike.honk();
  //     Console.WriteLine(myBike.brand + " " + myBike.modelName);
  //   }
  // }





  //POLYMORPHISM :
  // class Animal
  // {
  //   public virtual void animalSound()
  //   {
  //     Console.WriteLine("The animal makes a sound");
  //   }
  // }
  // class Pig : Animal
  // {
  //       public override void animalSound()
  //       {
  //           base.animalSound();
  //           Console.WriteLine("The pig says: WEE WEE");
  //       }
  //   }
  
  // class Dog : Animal
  // {
  //       public override void animalSound()
  //       {
  //           base.animalSound();
  //           Console.WriteLine("The dog says : bow bow");
  //       }
  //   }

  //   class Program
  //   {
  //     static void Main(String [] args)
  //     {
  //       Animal myAnimal = new Animal();
  //        Animal myPig = new Pig();
  //        Animal myDog = new Dog();

  //        myAnimal.animalSound();
  //        myPig.animalSound();
  //        myDog.animalSound();
  //     }
  //   }

  




  //ABSTRACTION 
  // abstract class Animal
  // {
  //   public abstract void animalSound();
  //   public void sleep()
  //   {
  //     Console.WriteLine("Zzzzz");
  //   }
  // }
  // class Pig : Animal
  // {
  //       public override void animalSound()
  //       {
  //           Console.WriteLine("The pig says : Wee Wee");
  //       }
  //   }

  //   class Program
  //   {
  //     static void Main(String[] args)
  //     {
  //       Pig myPig = new Pig();
  //       myPig.animalSound();
  //       myPig.sleep();
  //     }
  //   }






  //  INTERFACE
// interface IAnimal
// {
//     void animalSound();
// }

// class Pig : IAnimal
// {
//     public void animalSound()
//     {
//         Console.WriteLine("The pig says: WEE WEE");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Pig myPig = new Pig();
//         myPig.animalSound();
//     }
// }




//MULTIPLE INHERITANCE 
interface IFirstInterface 
{
  void myMethod();
}
interface ISecondInterface
{
  void myOtherMethod();
}

class DemoClass : IFirstInterface, ISecondInterface
{
  public void myMethod()
  {
    Console.WriteLine("Some text ....");
  }
  public void myOtherMethod()
  {
    Console.WriteLine("Some other TExt");
  }
}

class Program
{
  static void Main(String[] args)
  {
    DemoClass myObj = new DemoClass();
    myObj.myMethod();
    myObj.myOtherMethod();
  }
}

}