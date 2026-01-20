using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator;

[TestClass]
public class CalculatorTest
{
    private readonly Calculator _calculator = new();

    [TestMethod]
    public void Add_ReturnsSum_WithPositiveAndNegative()
    {
        int result = _calculator.Add(10, -3);

        Assert.AreEqual(7, result);
    }

    [TestMethod]
    public void Add_ReturnsSum_WithZero()
    {
        int result = _calculator.Add(0, 5);

        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void Subtract_ReturnsDifference_WithPositiveAndNegative()
    {
        int result = _calculator.Subtract(8, -2);

        Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void Subtract_ReturnsDifference_WithZero()
    {
        int result = _calculator.Subtract(9, 0);

        Assert.AreEqual(9, result);
    }

    [TestMethod]
    public void Multiply_ReturnsProduct_WithPositiveAndNegative()
    {
        int result = _calculator.Multiply(-3, 4);

        Assert.AreEqual(-12, result);
    }

    [TestMethod]
    public void Multiply_ReturnsProduct_WithZero()
    {
        int result = _calculator.Multiply(7, 0);

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Divide_ReturnsQuotient_WithPositiveAndNegative()
    {
        double result = _calculator.Divide(9, -3);

        Assert.AreEqual(-3, result, 0.0001);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void Divide_ByZero_Throws()
    {
        _calculator.Divide(10, 0);
    }
}
