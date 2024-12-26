using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Чыгыш;

public class ЧыгышСиздинTests
{
    [Theory]
    [InlineData("апа", "апаңыздан")]
    [InlineData("ини", "иниңизден")]
    [InlineData("ой", "оюңуздан")]
    [InlineData("күзгү", "күзгүңүздөн")]
    [InlineData("карындаш", "карындашыңыздан")]
    [InlineData("керебет", "керебетиңизден")]
    [InlineData("дос", "досуңуздан")]
    [InlineData("сүрөт", "сүрөтүңүздөн")]
    [InlineData("жомок", "жомогуңуздан")]
    [InlineData("күчүк", "күчүгүңүздөн")]
    public void Чыгыш_Сиздин_Tests(string word, string expectedResult)
    {
        var actualResult = ЧыгышCase.Decline(word, PronounEnum.Сиз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}