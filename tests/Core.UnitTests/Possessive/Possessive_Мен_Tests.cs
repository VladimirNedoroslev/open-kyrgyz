using FluentAssertions;
using OpenKyrgyz.Core.Possessive;

namespace UnitTests.Possessive;

public class PossessiveМенTests
{
    [Theory]
    [InlineData("апа", "апам")]
    [InlineData("ой", "оюм")]
    [InlineData("дос", "досум")]
    [InlineData("ини", "иним")]
    [InlineData("сүрөт", "сүрөтүм")]
    [InlineData("карындаш", "карындашым")]
    [InlineData("жомок", "жомогум")]
    [InlineData("күчүк", "күчүгүм")]
    public void PossessiveМен_Tests(string word, string expectedResult)
    {
        var actualResult = PossessiveМен.ToPossessive(word);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}