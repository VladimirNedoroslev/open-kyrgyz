using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases;

public class БарышМенинTests
{
    [Theory]
    [InlineData("апа", "апама")]
    [InlineData("дос", "досума")]
    [InlineData("ини", "иниме")]
    [InlineData("сүрөт", "сүрөтүмө")]
    [InlineData("карындаш", "карындашыма")]
    [InlineData("жомок", "жомогума")]
    [InlineData("күчүк", "күчүгүмө")]
    public void Барыш_Менин_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.ToБарышCase(word, PronounEnum.Мен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}