using Calculator;

namespace Tests;

public class CachedCalculatorTest
{
    [Test]
    public void Add()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 3;

        // Act
        var result = calc.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void Add_Cached()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 3;

        // Act
        calc.Add(a, b);
        var result = calc.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void Subtract()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 5;
        var b = 3;

        // Act
        var result = calc.Subtract(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
    [Test]
    public void Subtract_Cached()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 5;
        var b = 3;

        // Act
        calc.Subtract(a, b);
        var result = calc.Subtract(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
    [Test]
    public void Multiply()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 5;
        var b = 2;

        // Act
        var result = calc.Multiply(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
    [Test]
    public void Multiply_Cached()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 5;
        var b = 2;

        // Act
        calc.Multiply(a, b);
        var result = calc.Multiply(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
    [Test]
    public void Divide()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 10;
        var b = 2;

        // Act
        var result = calc.Divide(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void Divide_Cached()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 10;
        var b = 2;

        // Act
        calc.Divide(a, b);
        var result = calc.Divide(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void Factorial_ValidPossitiveInt_FactorialOfNumber()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 11;

        // Act
        var result = calc.Factorial(a);

        // Assert
        Assert.That(result, Is.EqualTo(39916800));
    }
    [Test]
    public void Factorial_ValidPossitiveIntCached_FactorialOfNumber()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 11;

        // Act
        calc.Factorial(a);
        var result = calc.Factorial(a);

        // Assert
        Assert.That(result, Is.EqualTo(39916800));
    }
    [Test]
    public void Factorial_Integer0_Returns1()
    {
        // Arrange
        var calc = new CachedCalculator();
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
        var calc = new CachedCalculator();
        var invalidVal = -1;

        // Act + Assert
        Assert.Throws<ArgumentException>(
            () => calc.Factorial(invalidVal)
        );
    }
    [Test]
    public void IsPrime_ValidPossitiveInt_IsPrime()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 7;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.IsTrue(result);
    }
    [Test]
    public void IsPrime_ValidPossitiveIntCached_IsPrime()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 7;

        // Act
        calc.IsPrime(a);
        var result = calc.IsPrime(a);

        // Assert
        Assert.IsTrue(result);
    }
    [Test]
    public void IsPrime_ValidPossitiveInt_IsNotPrime()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 4;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.IsFalse(result);
    }
    [Test]
    public void IsPrime_Integer1_IsNotPrime()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 1;

        // Act
        var result = calc.IsPrime(a);

        // Assert
        Assert.IsFalse(result);
    }
}