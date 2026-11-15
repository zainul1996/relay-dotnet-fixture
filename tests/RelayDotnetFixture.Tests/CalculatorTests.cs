namespace RelayDotnetFixture.Tests;

using RelayDotnetFixture;

public class CalculatorTests
{
    [Fact]
    public void AddAddsTwoNumbers()
    {
        Assert.Equal(5, Calculator.Add(2, 3));
    }
}
