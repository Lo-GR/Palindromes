using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excercise;

namespace Excercise.Tests
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
  }
}