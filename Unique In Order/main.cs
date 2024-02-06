using System.Collections.Generic;

public static class Kata
{
  public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
  {
    List<T> Unique = new List<T>(); //T significa que a res pode ser qualquer dado sendo string, num, bool
    T prevElement = default(T); //valor inicial do array é T, logo, pode ser qualquer um enviado.
    foreach (T element in iterable)
      {
      if(!EqualityComparer<T>.Default.Equals(element,prevElement))
        {
        Unique.Add(element);
        prevElement = element;
      }
    }
    return Unique;
  }
}

namespace Solution
{
  using NUnit.Framework;
  using System;
  
  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void EmptyTest()
    {
      Assert.AreEqual("", Kata.UniqueInOrder(""));
    }
    [Test]
    public void Test1()
    {
      Assert.AreEqual("ABCDAB", Kata.UniqueInOrder("AAAABBBCCDAABBB"));
    }
  }
}