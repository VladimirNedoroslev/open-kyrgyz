using FluentAssertions;
using OpenKyrgyz.Core.Cases;

namespace UnitTests.Cases.Жатыш;

public class ЖатышTests
{
    [Theory]
    [InlineData("апа", "апада")]
    [InlineData("ини", "иниде")]
    [InlineData("ой", "ойдо")]
    [InlineData("күзгү", "күзгүдө")]
    [InlineData("карындаш", "карындашта")]
    [InlineData("керебет", "керебетте")]
    [InlineData("дос", "досто")]
    [InlineData("сүрөт", "сүрөттө")]
    [InlineData("жомок", "жомокто")]
    [InlineData("күчүк", "күчүктө")]
    public void Жатыш_Tests(string word, string expectedResult)
    {
        var actualResult = ЖатышCase.Decline(word);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}