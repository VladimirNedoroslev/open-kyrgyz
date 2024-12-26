using FluentAssertions;
using OpenKyrgyz.Core.Cases;

namespace UnitTests.Cases.Чыгыш;

public class ЧыгышTests
{
    [Theory]
    [InlineData("апа", "ападан")]
    [InlineData("ини", "иниден")]
    [InlineData("ой", "ойдон")]
    [InlineData("күзгү", "күзгүдөн")]
    [InlineData("карындаш", "карындаштан")]
    [InlineData("керебет", "керебеттен")]
    [InlineData("дос", "достон")]
    [InlineData("сүрөт", "сүрөттөн")]
    [InlineData("жомок", "жомоктон")]
    [InlineData("күчүк", "күчүктөн")]
    public void Чыгыш_Tests(string word, string expectedResult)
    {
        var actualResult = ЧыгышCase.Decline(word);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}