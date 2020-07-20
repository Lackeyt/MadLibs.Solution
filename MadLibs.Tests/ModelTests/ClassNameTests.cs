using Microsoft.VisualStudio.TestTools.UnitTesting;
using MadLibs.Models;

namespace MadLibs.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void NameOfMethod_DescriptionOfTest_ExpectedResult()
    {
      Assert.AreEqual(ExpectedResult, CodeToTest);
    }
  }
}