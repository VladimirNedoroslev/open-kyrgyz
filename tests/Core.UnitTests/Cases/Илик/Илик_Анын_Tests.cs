using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Илик;

public class ИликАнынTests
{
    [Theory]
    [InlineData("апа", "апасынын")]
    [InlineData("ини", "инисинин")]
    [InlineData("ой", "оюнун")]
    [InlineData("күзгү", "күзгүсүнүн")]
    [InlineData("карындаш", "карындашынын")]
    [InlineData("керебет", "керебетинин")]
    [InlineData("дос", "досунун")]
    [InlineData("сүрөт", "сүрөтүнүн")]
    [InlineData("жомок", "жомогунун")]
    [InlineData("күчүк", "күчүгүнүн")]
    [InlineData("шаар", "шаарынын")]
    [InlineData("кийим", "кийиминин")]
    [InlineData("уй", "уюнун")]
    [InlineData("дүкөн", "дүкөнүнүн")]
    public void Илик_Анын_Tests(string word, string expectedResult)
    {
        var actualResult = ИликCase.Decline(word, PronounEnum.Ал, null);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}