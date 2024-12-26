using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Жатыш;

public class ЖатышСилердинTests
{
    [Theory]
    [InlineData("апа", "апаңарда")]
    [InlineData("ини", "иниңерде")]
    [InlineData("ой", "оюңарда")]
    [InlineData("күзгү", "күзгүңөрдө")]
    [InlineData("карындаш", "карындашыңарда")]
    [InlineData("керебет", "керебетиңерде")]
    [InlineData("дос", "досуңарда")]
    [InlineData("сүрөт", "сүрөтүңөрдө")]
    [InlineData("жомок", "жомогуңарда")]
    [InlineData("күчүк", "күчүгүңөрдө")]
    public void Жатыш_Силердин_Tests(string word, string expectedResult)
    {
        var actualResult = ЖатышCase.Decline(word, PronounEnum.Силер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}