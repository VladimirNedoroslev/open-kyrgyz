using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases;

public class БарышСенинTests
{
    [Theory]
    [InlineData("апа", "апаңа")]
    [InlineData("дос", "досуңа")]
    [InlineData("ини", "иниңе")]
    [InlineData("сүрөт", "сүрөтүңө")]
    [InlineData("карындаш", "карындашыңа")]
    [InlineData("жомок", "жомогуңа")]
    [InlineData("күчүк", "күчүгүңө")]
    public void Барыш_Сенин_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.ToБарышCase(word, PronounEnum.Сен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}