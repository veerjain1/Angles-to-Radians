using System;

class Program {
  public static void Main (string[] args) {
    string radianString;
    double radian;
    Console.Write("Enter an angle in degrees please: ");
    radianString = Console.ReadLine();
    radian = double.Parse(radianString);
    Console.WriteLine("Angle conversion to radians is "+radian*3.14159265359/180);
  }
}