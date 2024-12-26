using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Чыгыш;

public class ЧыгышМенинTests
{
    [Theory]
    [InlineData("апа", "апамдан")]
    [InlineData("ини", "инимден")]
    [InlineData("ой", "оюмдан")]
    [InlineData("күзгү", "күзгүмдөн")]
    [InlineData("карындаш", "карындашымдан")]
    [InlineData("керебет", "керебетимден")]
    [InlineData("дос", "досумдан")]
    [InlineData("сүрөт", "сүрөтүмдөн")]
    [InlineData("жомок", "жомогумдан")]
    [InlineData("күчүк", "күчүгүмдөн")]
    public void Чыгыш_Менин_Tests(string word, string expectedResult)
    {
        var actualResult = ЧыгышCase.Decline(word, PronounEnum.Мен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}