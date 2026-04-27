using testDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DemoApp.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        var Calc = new Calculator();
        int result = Calc.Multiply(7, 2);
        Assert.AreEqual(14, result);

    }
}
