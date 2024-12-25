using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases;

public class БарышСилердинTests
{
    [Theory]
    [InlineData("апа", "апаңарга")]
    [InlineData("дос", "досуңарга")]
    [InlineData("ини", "иниңерге")]
    [InlineData("сүрөт", "сүрөтүңөргө")]
    [InlineData("карындаш", "карындашыңарга")]
    [InlineData("жомок", "жомогуңарга")]
    [InlineData("күчүк", "күчүгүңөргө")]
    public void Барыш_Силердин_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.ToБарышCase(word, PronounEnum.Силер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}