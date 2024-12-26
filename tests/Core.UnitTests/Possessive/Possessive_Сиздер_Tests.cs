using FluentAssertions;
using OpenKyrgyz.Core.Possessive;

namespace UnitTests.Possessive;

public class PossessiveСиздерTests
{
    [Theory]
    [InlineData("апа", "апаңыздар")]
    [InlineData("ой", "оюңуздар")]
    [InlineData("дос", "досуңуздар")]
    [InlineData("ини", "иниңиздер")]
    [InlineData("сүрөт", "сүрөтүңүздөр")]
    [InlineData("карындаш", "карындашыңыздар")]
    [InlineData("жомок", "жомогуңуздар")]
    [InlineData("күчүк", "күчүгүңүздөр")]
    public void PossessiveСиздер_Tests(string word, string expectedResult)
    {
        var actualResult = PossessiveСиздер.ToPossessive(word);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}