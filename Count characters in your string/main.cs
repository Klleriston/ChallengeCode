using System.Collections.Generic;
using System;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    if (str == null || str.Length <= 0)
      {
      return new Dictionary<char, int>();
    }
    
    Dictionary<char, int> novoDicionario = new Dictionary<char, int>();
    
    foreach (char c in str)
    {
      if (novoDicionario.ContainsKey(c))
        {
         novoDicionario[c]++;
      }
      else {
         novoDicionario[c] = 1;
      }
    }
    
     return novoDicionario;
    
  }
}