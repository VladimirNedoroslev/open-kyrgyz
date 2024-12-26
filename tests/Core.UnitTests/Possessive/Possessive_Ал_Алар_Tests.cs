using FluentAssertions;
using OpenKyrgyz.Core.Possessive;

namespace UnitTests.Possessive;

public class PossessiveАлАларTests
{
    [Theory]
    [InlineData("апа", "апасы")]
    [InlineData("ой", "ою")]
    [InlineData("дос", "досу")]
    [InlineData("ини", "иниси")]
    [InlineData("сүрөт", "сүрөтү")]
    [InlineData("карындаш", "карындашы")]
    [InlineData("жомок", "жомогу")]
    [InlineData("күчүк", "күчүгү")]
    public void PossessiveАл_Tests(string word, string expectedResult)
    {
        var actualResult = PossessiveАлАлар.ToPossessive(word);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}