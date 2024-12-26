using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Жатыш;

public class ЖатышСенинTests
{
    [Theory]
    [InlineData("апа", "апаңда")]
    [InlineData("ини", "иниңде")]
    [InlineData("ой", "оюңда")]
    [InlineData("күзгү", "күзгүңдө")]
    [InlineData("карындаш", "карындашыңда")]
    [InlineData("керебет", "керебетиңде")]
    [InlineData("дос", "досуңда")]
    [InlineData("сүрөт", "сүрөтүңдө")]
    [InlineData("жомок", "жомогуңда")]
    [InlineData("күчүк", "күчүгүңдө")]
    public void Жатыш_Сенин_Tests(string word, string expectedResult)
    {
        var actualResult = ЖатышCase.Decline(word, PronounEnum.Сен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}