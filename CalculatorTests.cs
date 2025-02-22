namespace Review_3;

public class CalculatorTests
{
    private Calculator calc;
    [SetUp]
    public void Setup()
    {
        calc = new Calculator();
    }

    [Test]
    public void AddSumTest()
    {
        int a = 5;
        int b = 5;

        int result = calc.Add(a, b);

        Assert.AreEqual(10, result);
    }

    [Test]
    public void SubtractTest()
    {
        int a = 5;
        int b = 5;

        int result = calc.Subtract(a, b);

        Assert.AreEqual(0, result);
    }

    [Test]
    public void MultiplyTest()
    {
        int a = 5;
        int b = 5;

        int result = calc.Multiply(a, b);

        Assert.AreEqual(25, result);
    }

    [Test]
    public void DivideTest()
    {

        int a = 25;
        int b = 5;

        double result = calc.Divide(a, b); Assert.AreEqual(5.0, result);
    }
}