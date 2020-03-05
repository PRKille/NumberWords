using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers.Models;
using System;

namespace Numbers.Tests
{
  [TestClass]
  public class NumberTests
  {
    [TestMethod]
    public void CheckValueSingle_ReturnsSingleValueString_ReturnString()
    {
      Assert.AreEqual(" one", Number.CheckValueSingle("1"));
    }
    [TestMethod]
    public void CheckValueTeens_ReturnsTeenValueString_ReturnString()
    {
      Assert.AreEqual(" eleven", Number.CheckValueTeens("11"));
    }
    [TestMethod]
    public void CheckValueTens_ReturnsTenValueString_ReturnString()
    {
      Assert.AreEqual(" thirty", Number.CheckValueTens("30"));
    }
    [TestMethod]
    public void CheckValueTens_ReturnsTenValueStringWithSingle_ReturnString()
    {
      Assert.AreEqual(" thirty three", Number.CheckValueTens("33"));
    }
    [TestMethod]
    public void CheckValueHundred_ReturnsHundredValueStringWithSingle_ReturnString()
    {
      Assert.AreEqual(" one hundred one", Number.CheckValueHundred("101"));
    }
    [TestMethod]
    public void CheckValueHundred_ReturnsHundredValueStringWithTeen_ReturnString()
    {
      Assert.AreEqual(" one hundred thirteen", Number.CheckValueHundred("113"));
    }
    [TestMethod]
    public void CheckFullNum_ReturnsCorrectString_ReturnString()
    {
      Assert.AreEqual("One trillion one hundred million eleven thousand one hundred thirteen", Number.CheckFullNum("1,000,100,011,113"));
    }
  }
}