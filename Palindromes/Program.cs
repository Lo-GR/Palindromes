using System;
using PalindromeSpace.Models;

namespace PalindromeSpace {
  public class Program {
    public static void Main() {
      Console.Write("Please Enter in any word, phrase, number, or other sequence of characters: ");
      string userInput = Console.ReadLine();
      bool ans = Palindrome.isPalindrome(userInput);
      if(ans)
      {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine(userInput + " is indeed a Palindrome");
      }
      else
      {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(userInput + " is not a Palindrome, sorry guy.");
      }
      Console.ResetColor();
      Console.WriteLine();
      Console.Write("Would you like to continue? Enter Y for yes or anything else for no: ");
      string userContinue = (Console.ReadLine()).ToLower();
      if ( userContinue == "y")
      {
        Main();
      } else 
      {
        Console.WriteLine("Have a swell day");
      }
    }
  }
}