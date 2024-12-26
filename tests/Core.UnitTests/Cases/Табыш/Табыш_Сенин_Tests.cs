using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Табыш;

public class ТабышСенинTests
{
    [Theory]
    [InlineData("апа", "апаңды")]
    [InlineData("ини", "иниңди")]
    [InlineData("ой", "оюңду")]
    [InlineData("күзгү", "күзгүңдү")]
    [InlineData("карындаш", "карындашыңды")]
    [InlineData("керебет", "керебетиңди")]
    [InlineData("дос", "досуңду")]
    [InlineData("сүрөт", "сүрөтүңдү")]
    [InlineData("жомок", "жомогуңду")]
    [InlineData("күчүк", "күчүгүңдү")]
    public void Табыш_Сенин_Tests(string word, string expectedResult)
    {
        var actualResult = ТабышCase.Decline(word, PronounEnum.Сен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}