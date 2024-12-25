using FluentAssertions;
using OpenKyrgyz.Core.Possessive;

namespace UnitTests.Possessive;

public class PossessiveБизTests
{
    [Theory]
    [InlineData("апа", "апабыз")]
    [InlineData("дос", "досубуз")]
    [InlineData("ини", "инибиз")]
    [InlineData("сүрөт", "сүрөтүбүз")]
    [InlineData("карындаш", "карындашыбыз")]
    [InlineData("жомок", "жомогубуз")]
    [InlineData("күчүк", "күчүгүбүз")]
    public void PossessiveБиз_Tests(string word, string expectedResult)
    {
        var actualResult = PossessiveБиз.ToPossessive(word);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}