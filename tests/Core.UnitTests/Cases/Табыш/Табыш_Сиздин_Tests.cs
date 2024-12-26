using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Табыш;

public class ТабышСиздинTests
{
    [Theory]
    [InlineData("апа", "апаңызды")]
    [InlineData("ини", "иниңизди")]
    [InlineData("ой", "оюңузду")]
    [InlineData("күзгү", "күзгүңүздү")]
    [InlineData("карындаш", "карындашыңызды")]
    [InlineData("керебет", "керебетиңизди")]
    [InlineData("дос", "досуңузду")]
    [InlineData("сүрөт", "сүрөтүңүздү")]
    [InlineData("жомок", "жомогуңузду")]
    [InlineData("күчүк", "күчүгүңүздү")]
    public void Табыш_Сиздин_Tests(string word, string expectedResult)
    {
        var actualResult = ТабышCase.Decline(word, PronounEnum.Сиз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}