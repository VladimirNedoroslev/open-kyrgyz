using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Илик;

public class ИликМенинTests
{
    [Theory]
    [InlineData("апа", "апамдын")]
    [InlineData("ини", "инимдин")]
    [InlineData("ой", "оюмдун")]
    [InlineData("күзгү", "күзгүмдүн")]
    [InlineData("карындаш", "карындашымдын")]
    [InlineData("керебет", "керебетимдин")]
    [InlineData("дос", "досумдун")]
    [InlineData("сүрөт", "сүрөтүмдүн")]
    [InlineData("жомок", "жомогумдун")]
    [InlineData("күчүк", "күчүгүмдүн")]
    public void Илик_Менин_Tests(string word, string expectedResult)
    {
        var actualResult = ИликCase.Decline(word, PronounEnum.Мен, null);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}