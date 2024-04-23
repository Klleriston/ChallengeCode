public class Solution {
    public bool IsPalindrome(int x) {
       string strX = x.ToString();
       string palindromeTest = "";
       for (int i = strX.Length - 1; i>=0; i--)
       {
            palindromeTest += strX[i];
       }
       if (palindromeTest == x.ToString()) 
            return true;
       return false;
    }
}
