using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases;

public class БарышАнынTests
{
    [Theory]
    [InlineData("апа", "апасына")]
    [InlineData("дос", "досуна")]
    [InlineData("ини", "инисине")]
    [InlineData("сүрөт", "сүрөтүнө")]
    [InlineData("карындаш", "карындашына")]
    [InlineData("жомок", "жомогуна")]
    [InlineData("күчүк", "күчүгүнө")]
    public void Барыш_Анын_Tests(string word, string expectedResult)
    {
        var actualResult = БарышCase.ToБарышCase(word, PronounEnum.Ал);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}