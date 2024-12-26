using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Чыгыш;

public class ЧыгышСенинTests
{
    [Theory]
    [InlineData("апа", "апаңдан")]
    [InlineData("ини", "иниңден")]
    [InlineData("ой", "оюңдан")]
    [InlineData("күзгү", "күзгүңдөн")]
    [InlineData("карындаш", "карындашыңдан")]
    [InlineData("керебет", "керебетиңден")]
    [InlineData("дос", "досуңдан")]
    [InlineData("сүрөт", "сүрөтүңдөн")]
    [InlineData("жомок", "жомогуңдан")]
    [InlineData("күчүк", "күчүгүңдөн")]
    public void Чыгыш_Сенин_Tests(string word, string expectedResult)
    {
        var actualResult = ЧыгышCase.Decline(word, PronounEnum.Сен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}