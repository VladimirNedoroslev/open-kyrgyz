using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Чыгыш;

public class ЧыгышБиздинTests
{
    [Theory]
    [InlineData("апа", "апабыздан")]
    [InlineData("ини", "инибизден")]
    [InlineData("ой", "оюбуздан")]
    [InlineData("күзгү", "күзгүбүздөн")]
    [InlineData("карындаш", "карындашыбыздан")]
    [InlineData("керебет", "керебетибизден")]
    [InlineData("дос", "досубуздан")]
    [InlineData("сүрөт", "сүрөтүбүздөн")]
    [InlineData("жомок", "жомогубуздан")]
    [InlineData("күчүк", "күчүгүбүздөн")]
    public void Чыгыш_Биздин_Tests(string word, string expectedResult)
    {
        var actualResult = ЧыгышCase.Decline(word, PronounEnum.Биз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}