namespace RelayDotnetFixture.Tests;

using RelayDotnetFixture;

public class CalculatorTests
{
    [Fact]
    public void AddAddsTwoNumbers()
    {
        Assert.Equal(5, Calculator.Add(2, 3));
    }

    [Theory]
    [InlineData(2000, true)]
    [InlineData(1900, false)]
    [InlineData(2024, true)]
    [InlineData(2023, false)]
    public void IsLeapYearAppliesGregorianRule(int year, bool expected)
    {
        Assert.Equal(expected, Calculator.IsLeapYear(year));
    }
}
