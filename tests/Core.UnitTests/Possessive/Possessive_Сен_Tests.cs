using FluentAssertions;
using OpenKyrgyz.Core.Possessive;

namespace UnitTests.Possessive;

public class PossessiveСенTests
{
    [Theory]
    [InlineData("апа", "апаң")]
    [InlineData("дос", "досуң")]
    [InlineData("ини", "иниң")]
    [InlineData("сүрөт", "сүрөтүң")]
    [InlineData("карындаш", "карындашың")]
    [InlineData("жомок", "жомогуң")]
    [InlineData("күчүк", "күчүгүң")]
    public void PossessiveСен_Tests(string word, string expectedResult)
    {
        var actualResult = PossessiveСен.ToPossessive(word);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}