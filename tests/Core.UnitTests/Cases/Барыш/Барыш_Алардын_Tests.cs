using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Барыш;

public class БарышАлардынTests
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
    public void Барыш_Алардын_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.Decline(word, PronounEnum.Алар);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}