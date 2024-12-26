using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Илик;

public class ИликБиздинTests
{
    [Theory]
    [InlineData("апа", "апабыздын")]
    [InlineData("ини", "инибиздин")]
    [InlineData("ой", "оюбуздун")]
    [InlineData("күзгү", "күзгүбүздүн")]
    [InlineData("карындаш", "карындашыбыздын")]
    [InlineData("керебет", "керебетибиздин")]
    [InlineData("дос", "досубуздун")]
    [InlineData("сүрөт", "сүрөтүбүздүн")]
    [InlineData("жомок", "жомогубуздун")]
    [InlineData("күчүк", "күчүгүбүздүн")]
    public void Илик_Биздин_Tests(string word, string expectedResult)
    {
        var actualResult = ИликCase.Decline(word, PronounEnum.Биз, null);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}