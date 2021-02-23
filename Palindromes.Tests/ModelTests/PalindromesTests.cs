using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excercise;

namespace Excercise.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_HelloWorld()
    {
      // Palindrome testLeapYear = new Palindrome();
      Assert.AreEqual(true, Palindrome.isPalindrome("2012"));
    }
  }
}