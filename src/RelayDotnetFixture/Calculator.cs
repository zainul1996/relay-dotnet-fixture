namespace RelayDotnetFixture;

public static class Calculator
{
    public static int Add(int left, int right) => left + right;

    public static bool IsLeapYear(int year) => (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
}
