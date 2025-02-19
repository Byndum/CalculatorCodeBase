using Calculator;

namespace Tests;

public class SimpleCalculatorTest
{
    [Test]
    public void Add()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 2;
        var b = 3;
        
        // Act
        var result = calc.Add(a, b);
        
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void Subtract()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 5;
        var b = 3;

        // Act
        var result = calc.Subtract(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
    [Test]
    public void Multiply()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 5;
        var b = 2;

        // Act
        var result = calc.Multiply(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
    [Test]
    public void Divide()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 10;
        var b = 2;

        // Act
        var result = calc.Divide(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void Factorial_ValidPossitiveInt_FactorialOfNumber()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 11;

        // Act
        var result = calc.Factorial(a);

        // Assert
        Assert.That(result, Is.EqualTo(39916800));
    }
    [Test]
    public void Factorial_Integer0_Returns1()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 0;

        // Act
        var result = calc.Factorial(a);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    [Test]
    public void Factorial_InvalidNegativeInt_ThrowsArgumentException()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var invalidVal = -1;

        // Act + Assert
        Assert.That(Assert.Throws<ArgumentException>(
            () => calc.Factorial(invalidVal)
        ).Message, Is.EqualTo("Factorial is not defined for negative numbers"));
    }
    [Test]
    public void IsPrime_ValidPossitiveInt_IsPrime()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 7;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.True);
    }
    [Test]
    public void IsPrime_ValidPossitiveIntEdgecase_IsPrime()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 2;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.True);
    }
    [Test]
    public void IsPrime_ValidPossitiveInt_IsNotPrime()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 4;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.False);
    }
    [Test]
    public void IsPrime_Integer1_IsNotPrime()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 1;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.False);
    }
}