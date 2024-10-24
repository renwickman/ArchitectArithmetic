using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Console.WriteLine(Rect(4,5));
      //Console.WriteLine(Cir(4));
      //Console.WriteLine(Tri(10, 9));

      // double total = Rect(2500, 1500) + Tri(750, 500) + 0.5 * Cir(375);
      // double total_pesos = total * 180;
      // Console.WriteLine($"This is the Total Pesos to build the Teotihuacan: {Math.Round(total_pesos, 2)}");

      CalculateTotalCost();
    }
    static double Rect(double length, double width){
      return length * width;
    }
    static double Cir(double radius){
      return Math.PI * Math.Pow(radius, 2);
    }
    static double Tri(double bottom, double height){
      return 0.5 * bottom * height;
    }
    static void CalculateTotalCost(){
      Console.WriteLine("What monument would you like to work with?");
      Console.Write("Choose (1) Taj Mahal, (2) Mecca, (3) Teotihuacan: ");
      string monument = Console.ReadLine();
      double totalArea;
      double totalCost;

      switch(monument){

        case "1":
        Console.WriteLine("Taj Mahal");
        totalArea = Rect(90.5, 90.5) - Tri(24, 24);
        break;

        case "2":
        Console.WriteLine("Great Mosque of Mecca");
        totalArea = Rect(106, 180) + Rect(200, 264) + Tri(264, 84);
        break;

        case "3":
        Console.WriteLine("Taj Mahal");
        totalArea = Rect(2500, 1500) + Tri(750, 500) + 0.5 * Cir(375);
        break;

        default:
        totalArea = 0;
        break;
      }

      Console.WriteLine("Total Area: " + totalArea);
      totalCost = Math.Round((totalArea * 180), 2);
      Console.WriteLine($"The Total Cost is: {totalCost} pesos\n");
    }
  }
}
