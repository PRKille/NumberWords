using System;
using Numbers.Models;

namespace Numbers
{
  public class Program
  {
    public static void Main()
    {
     Console.WriteLine("Please enter an number using commas to sepparate by hundreds (e.g. 1,234,567)");
     string userInput = Console.ReadLine();
     Console.WriteLine(Number.CheckFullNum(userInput));
    }
  }

}