using System;
using System.Linq;
using System.Collections.Generic;

public class Brace {

    public static bool validBraces(String braces) {
       var st = new Stack<char>();
    foreach (var c in braces)
      switch (c)
      {
        case '(':
        case '[':
        case '{':
          st.Push(c);
          continue;
        case ')':
          if (st.Count == 0 || st.Pop() != '(') return false;
          continue;
        case ']':
          if (st.Count == 0 || st.Pop() != '[') return false;
          continue;
        case '}':
          if (st.Count == 0 || st.Pop() != '{') return false;
          continue;
      }
    return st.Count == 0;
    }
}