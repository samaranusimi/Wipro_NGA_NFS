using CalculatorLibary;
namespace TestProject;

[TestClass]
public sealed class Test1
{
    private Calculator Calc;

    [TestInitialize]
    public void Setup()
    {
        Calc = new Calculator();
    }

    [TestMethod]
    public void TestMethod1()
    {
        double result = Calc.Multiply(7, 2);
        Assert.AreEqual(14, result);
    }
    [TestMethod]
    public void TestMethod2()
    {
        double result = Calc.Add(7, 2);
        Assert.AreEqual(9, result);
    }

    [TestMethod]
    public void TestMethod3()
    {
        double result = Calc.Add(9, 2);
        Assert.AreEqual(11, result);
    }

    [TestMethod]
    public void TestMethod4()
    {
        double result = Calc.Divide(30, 2);
        Assert.AreEqual(15, result);
    }
}
