using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Барыш;

public class БарышМенинTests
{
    [Theory]
    [InlineData("апа", "апама")]
    [InlineData("ини", "иниме")]
    [InlineData("ой", "оюма")]
    [InlineData("күзгү", "күзгүмө")]
    [InlineData("карындаш", "карындашыма")]
    [InlineData("керебет", "керебетиме")]
    [InlineData("дос", "досума")]
    [InlineData("сүрөт", "сүрөтүмө")]
    [InlineData("жомок", "жомогума")]
    [InlineData("күчүк", "күчүгүмө")]
    public void Барыш_Менин_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.Decline(word, PronounEnum.Мен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}