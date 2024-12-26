using FluentAssertions;
using OpenKyrgyz.Core.Possessive;

namespace UnitTests.Possessive;

public class PossessiveСизTests
{
    [Theory]
    [InlineData("апа", "апаңыз")]
    [InlineData("ой", "оюңуз")]
    [InlineData("дос", "досуңуз")]
    [InlineData("ини", "иниңиз")]
    [InlineData("сүрөт", "сүрөтүңүз")]
    [InlineData("карындаш", "карындашыңыз")]
    [InlineData("жомок", "жомогуңуз")]
    [InlineData("күчүк", "күчүгүңүз")]
    public void PossessiveСиз_Tests(string word, string expectedResult)
    {
        var actualResult = PossessiveСиз.ToPossessive(word);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}