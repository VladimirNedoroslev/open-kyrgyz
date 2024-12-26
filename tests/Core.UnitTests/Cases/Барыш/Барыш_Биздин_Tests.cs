using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Барыш;

public class БарышБиздинTests
{
    [Theory]
    [InlineData("апа", "апабызга")]
    [InlineData("ини", "инибизге")]
    [InlineData("ой", "оюбузга")]
    [InlineData("күзгү", "күзгүбүзгө")]
    [InlineData("карындаш", "карындашыбызга")]
    [InlineData("керебет", "керебетибизге")]
    [InlineData("дос", "досубузга")]
    [InlineData("сүрөт", "сүрөтүбүзгө")]
    [InlineData("жомок", "жомогубузга")]
    [InlineData("күчүк", "күчүгүбүзгө")]
    public void Барыш_Биздин_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.Decline(word, PronounEnum.Биз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}