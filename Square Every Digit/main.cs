using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    string result = "";
    string number = n.ToString();

    foreach (char d in number)
    {
      int digit = int.Parse(d.ToString());
      result += (digit * digit).ToString();
    }

    
    return int.Parse(result);
  }
}

using System;
using NUnit.Framework;

[TestFixture]
public class KataTest
{
  [Test]
  public void SquareDigitsTest()
  {
    Assert.AreEqual(811181, Kata.SquareDigits(9119));
    Assert.AreEqual(0, Kata.SquareDigits(0));
  }
}