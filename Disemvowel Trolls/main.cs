using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        string[] vogais = {"a", "A", "e", "E", "i", "I", "o", "O", "u", "U"};
        foreach (string vogal in vogais)
          {
          str = str.Replace(vogal.ToString(), "");
        }
          return str;
    }
}