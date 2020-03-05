using System;
using System.Collections.Generic;

namespace Numbers.Models
{
  public class Number
  {
    public static Dictionary<string, string> onesPlace {get;set;}= new Dictionary<string, string>()
    {
      {"0", ""},
      {"1", "one"},
      {"2", "two"},
      {"3", "three"},
      {"4", "four"},
      {"5", "five"},
      {"6", "six"},
      {"7", "seven"},
      {"8", "eight"},
      {"9", "nine"}
    };

      public static Dictionary<string, string> tensPlace {get;set;}= new Dictionary<string, string>()
    {
      {"0", ""},
      {"1", "ten"},
      {"2", "twenty"},
      {"3", "thirty"},
      {"4", "fourty"},
      {"5", "fifty"},
      {"6", "sixty"},
      {"7", "seventy"},
      {"8", "eighty"},
      {"9", "ninety"}
    };

      public static Dictionary<string, string> teensPlace {get;set;}= new Dictionary<string, string>()
    {
      {"11", "eleven"},
      {"12", "twelve"},
      {"13", "thirteen"},
      {"14", "fourteen"},
      {"15", "fifteen"},
      {"16", "sixteen"},
      {"17", "seventeen"},
      {"18", "eighteen"},
      {"19", "nineteen"}
    };

    public static string [] numberArr {get;set;}= { "", "thousand", "million", "billion", "trillion" };

    public static string CheckValueSingle(string num)
    {
      return onesPlace[num[num.Length-1].ToString()];
    }

    public static string CheckValueTeens(string num)
    {
      return teensPlace[num].ToString();
    }

    public static string CheckValueTens(string num)
    {
      string tens = tensPlace[num[num.Length-2].ToString()];
      string ones = CheckValueSingle(num[num.Length-1].ToString());
      return tens + ones;
    }

    public static string CheckValueHundred(string num)
    {
      string hundreds = CheckValueSingle(num[num.Length-3].ToString());
      if(num[num.Length-2] == '1')
      {
        return hundreds +"hundred" + CheckValueTeens(num.Substring(1));
      }
      else
      {
      string tens = tensPlace[num[num.Length-2].ToString()];
      string ones = CheckValueSingle(num[num.Length-1].ToString());
      return hundreds + "hundred" + tens + ones;
      }
    }

    public static string CheckFullNum(string num)
    {
      string[] numArr = num.Split(',');
      Console.WriteLine(numArr[0]);
      Console.WriteLine(numArr[1]);
      string outPut = "";
      int x = numArr.Length-1;
      foreach(string number in numArr)
      {
        if (number.Length == 3)
        {
          outPut += CheckValueHundred(number) + numberArr[x];
          x--;
        }
        else if (number.Length == 2)
        {
          if (number[number.Length-2] == '1')
          {
            outPut += CheckValueTeens(number) + numberArr[x];
            x--;
          }
          else
          {
            outPut += CheckValueTens(number) + numberArr[x];
            x--;
          }
        }
        else
        {
          outPut += CheckValueSingle(number) + numberArr[x];
          x--;
        }
      }
      return outPut;
    }
  }

}