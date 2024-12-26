using FluentAssertions;
using OpenKyrgyz.Core.Cases;

namespace UnitTests.Cases.Табыш;

public class ТабышTests
{
    [Theory]
    [InlineData("апа", "апаны")]
    [InlineData("ини", "инини")]
    [InlineData("ой", "ойду")]
    [InlineData("күзгү", "күзгүнү")]
    [InlineData("карындаш", "карындашты")]
    [InlineData("керебет", "керебетти")]
    [InlineData("дос", "досту")]
    [InlineData("сүрөт", "сүрөттү")]
    [InlineData("шаар", "шаарды")]
    [InlineData("кийим", "кийимди")]
    [InlineData("уй", "уйду")]
    [InlineData("дүкөн", "дүкөндү")]
    public void Табыш_Tests(string word, string expectedResult)
    {
        var actualResult = ТабышCase.Decline(word);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}