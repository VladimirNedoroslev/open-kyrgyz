using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases;

public class БарышБиздинTests
{
    [Theory]
    [InlineData("апа", "апабызга")]
    [InlineData("дос", "досубузга")]
    [InlineData("ини", "инибизге")]
    [InlineData("сүрөт", "сүрөтүбүзгө")]
    [InlineData("карындаш", "карындашыбызга")]
    [InlineData("жомок", "жомогубузга")]
    [InlineData("күчүк", "күчүгүбүзгө")]
    public void Барыш_Биздин_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.ToБарышCase(word, PronounEnum.Биз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}