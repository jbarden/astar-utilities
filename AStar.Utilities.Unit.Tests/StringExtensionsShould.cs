namespace AStar.Utilities.Unit.Tests;

public class StringExtensionsShould
{
    [Fact]
    public void ReturnTrueForCallToIsNullWhenStringIsNull()
    {
        string nullString = null!;

        nullString.IsNull().Should().BeTrue();
    }

    [Fact]
    public void ReturnFalseForCallToIsNullWhenStringIsNotNull()
    {
        var nullString = string.Empty;

        nullString.IsNull().Should().BeFalse();
    }

    [Fact]
    public void ReturnFalseForCallToIsNotNullWhenStringIsNull()
    {
        string nullString = null!;

        nullString.IsNotNull().Should().BeFalse();
    }

    [Fact]
    public void ReturnTrueForCallToIsNotNullWhenStringIsNotNull()
    {
        var nullString = string.Empty;

        nullString.IsNotNull().Should().BeTrue();
    }
}
