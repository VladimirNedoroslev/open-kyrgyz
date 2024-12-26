using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Барыш;

public class БарышСенинTests
{
    [Theory]
    [InlineData("апа", "апаңа")]
    [InlineData("ини", "иниңе")]
    [InlineData("ой", "оюңа")]
    [InlineData("күзгү", "күзгүңө")]
    [InlineData("карындаш", "карындашыңа")]
    [InlineData("керебет", "керебетиңе")]
    [InlineData("дос", "досуңа")]
    [InlineData("сүрөт", "сүрөтүңө")]
    [InlineData("жомок", "жомогуңа")]
    [InlineData("күчүк", "күчүгүңө")]
    public void Барыш_Сенин_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.Decline(word, PronounEnum.Сен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}