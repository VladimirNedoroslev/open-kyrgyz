using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Табыш;

public class ТабышМенинTests
{
    [Theory]
    [InlineData("апа", "апамды")]
    [InlineData("ини", "инимди")]
    [InlineData("ой", "оюмду")]
    [InlineData("күзгү", "күзгүмдү")]
    [InlineData("карындаш", "карындашымды")]
    [InlineData("керебет", "керебетимди")]
    [InlineData("дос", "досумду")]
    [InlineData("сүрөт", "сүрөтүмдү")]
    [InlineData("жомок", "жомогумду")]
    [InlineData("күчүк", "күчүгүмдү")]
    public void Табыш_Менин_Tests(string word, string expectedResult)
    {
        var actualResult = ТабышCase.Decline(word, PronounEnum.Мен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}