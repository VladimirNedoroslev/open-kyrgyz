using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Жатыш;

public class ЖатышМенинTests
{
    [Theory]
    [InlineData("апа", "апамда")]
    [InlineData("ини", "инимде")]
    [InlineData("ой", "оюмда")]
    [InlineData("күзгү", "күзгүмдө")]
    [InlineData("карындаш", "карындашымда")]
    [InlineData("керебет", "керебетимде")]
    [InlineData("дос", "досумда")]
    [InlineData("сүрөт", "сүрөтүмдө")]
    [InlineData("жомок", "жомогумда")]
    [InlineData("күчүк", "күчүгүмдө")]
    public void Жатыш_Менин_Tests(string word, string expectedResult)
    {
        var actualResult = ЖатышCase.Decline(word, PronounEnum.Мен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}