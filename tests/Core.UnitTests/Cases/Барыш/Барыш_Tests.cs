using FluentAssertions;
using OpenKyrgyz.Core.Cases;

namespace UnitTests.Cases.Барыш;

public class БарышTests
{
    [Theory]
    [InlineData("апа", "апага")]
    [InlineData("ини", "иниге")]
    [InlineData("ой", "ойго")]
    [InlineData("күзгү", "күзгүгө")]
    [InlineData("карындаш", "карындашка")]
    [InlineData("керебет", "керебетке")]
    [InlineData("дос", "доско")]
    [InlineData("сүрөт", "сүрөткө")]
    [InlineData("жомок", "жомокко")]
    [InlineData("күчүк", "күчүккө")]
    public void Барыш_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.Decline(word);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}