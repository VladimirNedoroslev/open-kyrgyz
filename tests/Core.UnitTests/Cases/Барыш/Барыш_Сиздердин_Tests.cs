using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases;

public class БарышСиздердинTests
{
    [Theory]
    [InlineData("апа", "апаңыздарга")]
    [InlineData("дос", "досуңуздарга")]
    [InlineData("ини", "иниңиздерге")]
    [InlineData("сүрөт", "сүрөтүңүздөргө")]
    [InlineData("карындаш", "карындашыңыздарга")]
    [InlineData("жомок", "жомогуңуздарга")]
    [InlineData("күчүк", "күчүгүңүздөргө")]
    public void Барыш_Сиздердин_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.ToБарышCase(word, PronounEnum.Сиздер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}