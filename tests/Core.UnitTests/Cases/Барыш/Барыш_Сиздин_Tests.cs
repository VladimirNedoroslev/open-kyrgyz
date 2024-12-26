using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Барыш;

public class БарышСиздинTests
{
    [Theory]
    [InlineData("апа", "апаңызга")]
    [InlineData("ини", "иниңизге")]
    [InlineData("ой", "оюңузга")]
    [InlineData("күзгү", "күзгүңүзгө")]
    [InlineData("карындаш", "карындашыңызга")]
    [InlineData("керебет", "керебетиңизге")]
    [InlineData("дос", "досуңузга")]
    [InlineData("сүрөт", "сүрөтүңүзгө")]
    [InlineData("жомок", "жомогуңузга")]
    [InlineData("күчүк", "күчүгүңүзгө")]
    public void Барыш_Сиздин_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.Decline(word, PronounEnum.Сиз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}