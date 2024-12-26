using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Барыш;

public class БарышАнынTests
{
    [Theory]
    [InlineData("апа", "апасына")]
    [InlineData("ини", "инисине")]
    [InlineData("ой", "оюна")]
    [InlineData("күзгү", "күзгүсүнө")]
    [InlineData("карындаш", "карындашына")]
    [InlineData("керебет", "керебетине")]
    [InlineData("дос", "досуна")]
    [InlineData("сүрөт", "сүрөтүнө")]
    [InlineData("жомок", "жомогуна")]
    [InlineData("күчүк", "күчүгүнө")]
    public void Барыш_Анын_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.Decline(word, PronounEnum.Ал);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}