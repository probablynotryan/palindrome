using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_IsInputReversedEqualToInput_True()
    {
      Check testIsPalindrome = new Check();
      Assert.AreEqual(false, testIsPalindrome.IsPalindrome("Hello World!"));
      Assert.AreEqual(true, testIsPalindrome.IsPalindrome("12321"));
    }
  }
}