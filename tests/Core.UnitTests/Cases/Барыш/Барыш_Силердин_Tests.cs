using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Барыш;

public class БарышСилердинTests
{
    [Theory]
    [InlineData("апа", "апаңарга")]
    [InlineData("ини", "иниңерге")]
    [InlineData("ой", "оюңарга")]
    [InlineData("күзгү", "күзгүңөргө")]
    [InlineData("карындаш", "карындашыңарга")]
    [InlineData("керебет", "керебетиңерге")]
    [InlineData("дос", "досуңарга")]
    [InlineData("сүрөт", "сүрөтүңөргө")]
    [InlineData("жомок", "жомогуңарга")]
    [InlineData("күчүк", "күчүгүңөргө")]
    public void Барыш_Силердин_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.Decline(word, PronounEnum.Силер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}