using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Табыш;

public class ТабышБиздинTests
{
    [Theory]
    [InlineData("апа", "апабызды")]
    [InlineData("ини", "инибизди")]
    [InlineData("ой", "оюбузду")]
    [InlineData("күзгү", "күзгүбүздү")]
    [InlineData("карындаш", "карындашыбызды")]
    [InlineData("керебет", "керебетибизди")]
    [InlineData("дос", "досубузду")]
    [InlineData("сүрөт", "сүрөтүбүздү")]
    [InlineData("жомок", "жомогубузду")]
    [InlineData("күчүк", "күчүгүбүздү")]
    public void Табыш_Биздин_Tests(string word, string expectedResult)
    {
        var actualResult = ТабышCase.Decline(word, PronounEnum.Биз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}