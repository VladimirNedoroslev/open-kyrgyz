using FluentAssertions;
using OpenKyrgyz.Core.Cases;

namespace UnitTests.Cases.Илик;

public class ИликTests
{
    [Theory]
    [InlineData("апа", "апанын")]
    [InlineData("ини", "ининин")]
    [InlineData("ой", "ойдун")]
    [InlineData("күзгү", "күзгүнүн")]
    [InlineData("карындаш", "карындаштын")]
    [InlineData("керебет", "керебеттин")]
    [InlineData("дос", "достун")]
    [InlineData("сүрөт", "сүрөттүн")]
    [InlineData("шаар", "шаардын")]
    [InlineData("кийим", "кийимдин")]
    [InlineData("уй", "уйдун")]
    [InlineData("дүкөн", "дүкөндүн")]
    public void Илик_Tests(string word, string expectedResult)
    {
        var actualResult = ИликCase.Decline(word, null, null);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}