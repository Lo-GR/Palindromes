using System;

namespace PalindromeSpace.Models
{
  public class Palindrome
  {
    public static bool isPalindrome(string str)
    {
      string firstHalf, secondHalf;
      
      if(str.Length % 2 == 0){
        firstHalf = str.Substring(0, str.Length/2);
        secondHalf = str.Substring(str.Length/2);
      }
      else
      {
        firstHalf = str.Substring(0, str.Length/2 + 1);
        secondHalf = str.Substring(str.Length/2);
      }
      string reverseHalf = "";
      for (int index = secondHalf.Length - 1; index >= 0; index--)
      {
        reverseHalf += secondHalf[index];
      }
      if (firstHalf.ToLower() == reverseHalf.ToLower())
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}