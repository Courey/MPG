using System;
class Car
{
   public readonly string make;
   public readonly string model;
   private static decimal MilesDriven;
   private static decimal GallonsUsed;
   
   public Car(string CarMake, string CarModel)//read only
   {
      make = CarMake;
      model = CarModel;
      
   }

   private static decimal Miles
   {    
      get
      {
         return MilesDriven;
      }

      set
      {
         MilesDriven = value += MilesDriven;
      }
   }
   private static decimal Gallons
   {
      get 
      {
         return GallonsUsed;
      }
      set
      {
         GallonsUsed = value += MilesDriven;
      }
   }

   public static void StaticMilesPerGallon(decimal milage, decimal galUsed)
   {
      Car.Gallons = galUsed;
      Car.Miles = milage;

      if (Gallons >= 1)
      {
         decimal mpg = Miles / Gallons;
      }
      else
      {
         Console.WriteLine("gallons must be greater than 0");
         Console.ReadLine();
      }
   }

   public void PlainMilesPerGallon(decimal milage, decimal galUsed)
   {
      Car.Gallons = galUsed;
      Car.Miles = milage;

      if (Gallons >= 1)
      {
         decimal mpg = Miles / Gallons;
         Console.WriteLine("MPG is {0} \n Hit enter to continue.", mpg);
         Console.ReadLine();
      }
      else 
      {
         Console.WriteLine("gallons must be greater than 0");
         Console.ReadLine();
      }
   }

   public static void Main(string[] args)
   {
      Car Car1 = new Car("Toyota", "Rav4");
      Car Car2 = new Car("Honda", "CRV");
   }
}
