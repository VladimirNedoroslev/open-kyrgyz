using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Илик;

public class ИликСенинTests
{
    [Theory]
    [InlineData("апа", "апаңдын")]
    [InlineData("ини", "иниңдин")]
    [InlineData("ой", "оюңдун")]
    [InlineData("күзгү", "күзгүңдүн")]
    [InlineData("карындаш", "карындашыңдын")]
    [InlineData("керебет", "керебетиңдин")]
    [InlineData("дос", "досуңдун")]
    [InlineData("сүрөт", "сүрөтүңдүн")]
    [InlineData("жомок", "жомогуңдун")]
    [InlineData("күчүк", "күчүгүңдүн")]
    public void Илик_Сенин_Tests(string word, string expectedResult)
    {
        var actualResult = ИликCase.Decline(word, PronounEnum.Сен, null);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}