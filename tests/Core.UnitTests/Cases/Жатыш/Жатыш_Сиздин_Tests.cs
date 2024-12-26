using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Жатыш;

public class ЖатышСиздинTests
{
    [Theory]
    [InlineData("апа", "апаңызда")]
    [InlineData("ини", "иниңизде")]
    [InlineData("ой", "оюңузда")]
    [InlineData("күзгү", "күзгүңүздө")]
    [InlineData("карындаш", "карындашыңызда")]
    [InlineData("керебет", "керебетиңизде")]
    [InlineData("дос", "досуңузда")]
    [InlineData("сүрөт", "сүрөтүңүздө")]
    [InlineData("жомок", "жомогуңузда")]
    [InlineData("күчүк", "күчүгүңүздө")]
    public void Жатыш_Сиздин_Tests(string word, string expectedResult)
    {
        var actualResult = ЖатышCase.Decline(word, PronounEnum.Сиз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}