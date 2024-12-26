using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Илик;

public class ИликСиздинTests
{
    [Theory]
    [InlineData("апа", "апаңыздын")]
    [InlineData("ини", "иниңиздин")]
    [InlineData("ой", "оюңуздун")]
    [InlineData("күзгү", "күзгүңүздүн")]
    [InlineData("карындаш", "карындашыңыздын")]
    [InlineData("керебет", "керебетиңиздин")]
    [InlineData("дос", "досуңуздун")]
    [InlineData("сүрөт", "сүрөтүңүздүн")]
    [InlineData("жомок", "жомогуңуздун")]
    [InlineData("күчүк", "күчүгүңүздүн")]
    public void Илик_Сиздин_Tests(string word, string expectedResult)
    {
        var actualResult = ИликCase.Decline(word, PronounEnum.Сиз, null);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}