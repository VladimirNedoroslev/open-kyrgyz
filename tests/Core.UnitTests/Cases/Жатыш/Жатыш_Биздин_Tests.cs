using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Жатыш;

public class ЖатышБиздинTests
{
    [Theory]
    [InlineData("апа", "апабызда")]
    [InlineData("ини", "инибизде")]
    [InlineData("ой", "оюбузда")]
    [InlineData("күзгү", "күзгүбүздө")]
    [InlineData("карындаш", "карындашыбызда")]
    [InlineData("керебет", "керебетибизде")]
    [InlineData("дос", "досубузда")]
    [InlineData("сүрөт", "сүрөтүбүздө")]
    [InlineData("жомок", "жомогубузда")]
    [InlineData("күчүк", "күчүгүбүздө")]
    public void Жатыш_Биздин_Tests(string word, string expectedResult)
    {
        var actualResult = ЖатышCase.Decline(word, PronounEnum.Биз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}