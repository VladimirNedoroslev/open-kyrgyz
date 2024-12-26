using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Табыш;

public class ТабышСиздердинTests
{
    [Theory]
    [InlineData("апа", "апаңыздарды")]
    [InlineData("ини", "иниңиздерди")]
    [InlineData("ой", "оюңуздарды")]
    [InlineData("күзгү", "күзгүңүздөрдү")]
    [InlineData("карындаш", "карындашыңыздарды")]
    [InlineData("керебет", "керебетиңиздерди")]
    [InlineData("дос", "досуңуздарды")]
    [InlineData("сүрөт", "сүрөтүңүздөрдү")]
    [InlineData("жомок", "жомогуңуздарды")]
    [InlineData("күчүк", "күчүгүңүздөрдү")]
    public void Табыш_Сиздердин_Tests(string word, string expectedResult)
    {
        var actualResult = ТабышCase.Decline(word, PronounEnum.Сиздер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}