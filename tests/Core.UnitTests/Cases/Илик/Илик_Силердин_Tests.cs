using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Илик;

public class ТабшСилердинTests
{
    [Theory]
    [InlineData("апа", "апаңардын")]
    [InlineData("ини", "иниңердин")]
    [InlineData("ой", "оюңардын")]
    [InlineData("күзгү", "күзгүңөрдүн")]
    [InlineData("карындаш", "карындашыңардын")]
    [InlineData("керебет", "керебетиңердин")]
    [InlineData("дос", "досуңардын")]
    [InlineData("сүрөт", "сүрөтүңөрдүн")]
    [InlineData("жомок", "жомогуңардын")]
    [InlineData("күчүк", "күчүгүңөрдүн")]
    public void Илик_Силердин_Tests(string word, string expectedResult)
    {
        var actualResult = ИликCase.Decline(word, PronounEnum.Силер, null);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}