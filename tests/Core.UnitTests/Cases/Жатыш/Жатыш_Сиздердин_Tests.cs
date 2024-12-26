using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Жатыш;

public class ЖатышСиздердинTests
{
    [Theory]
    [InlineData("апа", "апаңыздарда")]
    [InlineData("ини", "иниңиздерде")]
    [InlineData("ой", "оюңуздарда")]
    [InlineData("күзгү", "күзгүңүздөрдө")]
    [InlineData("карындаш", "карындашыңыздарда")]
    [InlineData("керебет", "керебетиңиздерде")]
    [InlineData("дос", "досуңуздарда")]
    [InlineData("сүрөт", "сүрөтүңүздөрдө")]
    [InlineData("жомок", "жомогуңуздарда")]
    [InlineData("күчүк", "күчүгүңүздөрдө")]
    public void Жатыш_Сиздердин_Tests(string word, string expectedResult)
    {
        var actualResult = ЖатышCase.Decline(word, PronounEnum.Сиздер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}