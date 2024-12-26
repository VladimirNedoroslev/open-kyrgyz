using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Чыгыш;

public class ЧыгышСилердинTests
{
    [Theory]
    [InlineData("апа", "апаңардан")]
    [InlineData("ини", "иниңерден")]
    [InlineData("ой", "оюңардан")]
    [InlineData("күзгү", "күзгүңөрдөн")]
    [InlineData("карындаш", "карындашыңардан")]
    [InlineData("керебет", "керебетиңерден")]
    [InlineData("дос", "досуңардан")]
    [InlineData("сүрөт", "сүрөтүңөрдөн")]
    [InlineData("жомок", "жомогуңардан")]
    [InlineData("күчүк", "күчүгүңөрдөн")]
    public void Чыгыш_Силердин_Tests(string word, string expectedResult)
    {
        var actualResult = ЧыгышCase.Decline(word, PronounEnum.Силер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}