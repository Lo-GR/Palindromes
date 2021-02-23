using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeSpace.Models;

namespace PalindromeSpace.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_Racecar()
    {
      // Palindrome testLeapYear = new Palindrome();
      Assert.AreEqual(true, Palindrome.isPalindrome("racecar"));
    }

    [TestMethod]
    public void isNotPalindrome_Banana()
    {
      Assert.AreEqual(false, Palindrome.isPalindrome("banana"));
    }
    [TestMethod]
    public void isPalindrome_Caps()
    {
      Assert.AreEqual(true, Palindrome.isPalindrome("RacECAr"));
    }
    [TestMethod]
    public void isPalindrome_Singlechar()
    {
      Assert.AreEqual(false, Palindrome.isPalindrome("a"));
    }
  }
}