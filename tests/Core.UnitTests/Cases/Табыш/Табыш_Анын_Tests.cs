using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Табыш;

public class ТабышАнынTests
{
    [Theory]
    [InlineData("апа", "апасын")]
    [InlineData("ини", "инисин")]
    [InlineData("ой", "оюн")]
    [InlineData("күзгү", "күзгүсүн")]
    [InlineData("карындаш", "карындашын")]
    [InlineData("керебет", "керебетин")]
    [InlineData("дос", "досун")]
    [InlineData("сүрөт", "сүрөтүн")]
    [InlineData("жомок", "жомогун")]
    [InlineData("күчүк", "күчүгүн")]
    [InlineData("шаар", "шаарын")]
    [InlineData("кийим", "кийимин")]
    [InlineData("уй", "уюн")]
    [InlineData("дүкөн", "дүкөнүн")]
    public void Табыш_Анын_Tests(string word, string expectedResult)
    {
        var actualResult = ТабышCase.Decline(word, PronounEnum.Ал);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}