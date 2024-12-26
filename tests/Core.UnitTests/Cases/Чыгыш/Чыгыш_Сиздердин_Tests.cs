using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Чыгыш;

public class ЧыгышСиздердинTests
{
    [Theory]
    [InlineData("апа", "апаңыздардан")]
    [InlineData("ини", "иниңиздерден")]
    [InlineData("ой", "оюңуздардан")]
    [InlineData("күзгү", "күзгүңүздөрдөн")]
    [InlineData("карындаш", "карындашыңыздардан")]
    [InlineData("керебет", "керебетиңиздерден")]
    [InlineData("дос", "досуңуздардан")]
    [InlineData("сүрөт", "сүрөтүңүздөрдөн")]
    [InlineData("жомок", "жомогуңуздардан")]
    [InlineData("күчүк", "күчүгүңүздөрдөн")]
    public void Чыгыш_Сиздердин_Tests(string word, string expectedResult)
    {
        var actualResult = ЧыгышCase.Decline(word, PronounEnum.Сиздер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}