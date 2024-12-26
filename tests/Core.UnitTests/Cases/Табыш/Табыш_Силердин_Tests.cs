using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Табыш;

public class ТабшСилердинTests
{
    [Theory]
    [InlineData("апа", "апаңарды")]
    [InlineData("ини", "иниңерди")]
    [InlineData("ой", "оюңарды")]
    [InlineData("күзгү", "күзгүңөрдү")]
    [InlineData("карындаш", "карындашыңарды")]
    [InlineData("керебет", "керебетиңерди")]
    [InlineData("дос", "досуңарды")]
    [InlineData("сүрөт", "сүрөтүңөрдү")]
    [InlineData("жомок", "жомогуңарды")]
    [InlineData("күчүк", "күчүгүңөрдү")]
    public void Табыш_Силердин_Tests(string word, string expectedResult)
    {
        var actualResult = ТабышCase.Decline(word, PronounEnum.Силер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}