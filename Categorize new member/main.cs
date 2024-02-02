using System;
using System.Collections.Generic;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        List<string> saida = new List<string>();

        foreach (var d in data)
        {
            int idade = d[0];
            int handicap = d[1];

            if (idade >= 55 && handicap > 7)
            {
                saida.Add("Senior");
            }
            else
            {
                saida.Add("Open");
            }
        }

        return saida;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Solution
{
    [TestFixture]
    public class KataOpenOrSeniorTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
            Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, Kata.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
            Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, Kata.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));
        }
        
    }
}