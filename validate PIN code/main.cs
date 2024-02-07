using System;
using System.Text.RegularExpressions;
public class Kata
{
  public static bool ValidatePin(string pin)
  {
      foreach (char c in pin)
      {
         if (!Char.IsDigit(c))
         {
             return false;        
         }
      }

      if (pin.Length == 4 || pin.Length == 6)
        {
         return true;
      }
       
      return false;
  }
}