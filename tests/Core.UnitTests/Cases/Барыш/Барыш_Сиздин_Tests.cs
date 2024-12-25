using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases;

public class БарышСиздинTests
{
    [Theory]
    [InlineData("апа", "апаңызга")]
    [InlineData("дос", "досуңузга")]
    [InlineData("ини", "иниңизге")]
    [InlineData("сүрөт", "сүрөтүңүзгө")]
    [InlineData("карындаш", "карындашыңызга")]
    [InlineData("жомок", "жомогуңузга")]
    [InlineData("күчүк", "күчүгүңүзгө")]
    public void Барыш_Сиздин_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.ToБарышCase(word, PronounEnum.Сиз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}