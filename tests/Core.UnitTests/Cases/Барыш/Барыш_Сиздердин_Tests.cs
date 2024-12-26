using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Барыш;

public class БарышСиздердинTests
{
    [Theory]
    [InlineData("апа", "апаңыздарга")]
    [InlineData("ини", "иниңиздерге")]
    [InlineData("ой", "оюңуздарга")]
    [InlineData("күзгү", "күзгүңүздөргө")]
    [InlineData("карындаш", "карындашыңыздарга")]
    [InlineData("керебет", "керебетиңиздерге")]
    [InlineData("дос", "досуңуздарга")]
    [InlineData("сүрөт", "сүрөтүңүздөргө")]
    [InlineData("жомок", "жомогуңуздарга")]
    [InlineData("күчүк", "күчүгүңүздөргө")]
    public void Барыш_Сиздердин_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.Decline(word, PronounEnum.Сиздер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}