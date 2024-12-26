using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Илик;

public class ИликСиздердинTests
{
    [Theory]
    [InlineData("апа", "апаңыздардын")]
    [InlineData("ини", "иниңиздердин")]
    [InlineData("ой", "оюңуздардын")]
    [InlineData("күзгү", "күзгүңүздөрдүн")]
    [InlineData("карындаш", "карындашыңыздардын")]
    [InlineData("керебет", "керебетиңиздердин")]
    [InlineData("дос", "досуңуздардын")]
    [InlineData("сүрөт", "сүрөтүңүздөрдүн")]
    [InlineData("жомок", "жомогуңуздардын")]
    [InlineData("күчүк", "күчүгүңүздөрдүн")]
    public void Илик_Сиздердин_Tests(string word, string expectedResult)
    {
        var actualResult = ИликCase.Decline(word, PronounEnum.Сиздер, null);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}