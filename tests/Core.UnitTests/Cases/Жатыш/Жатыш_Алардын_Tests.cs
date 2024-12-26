using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Жатыш;

public class ЖатышАлардынTests
{
    [Theory]
    [InlineData("апа", "апасында")]
    [InlineData("ини", "инисинде")]
    [InlineData("ой", "оюнда")]
    [InlineData("күзгү", "күзгүсүндө")]
    [InlineData("карындаш", "карындашында")]
    [InlineData("керебет", "керебетинде")]
    [InlineData("дос", "досунда")]
    [InlineData("сүрөт", "сүрөтүндө")]
    [InlineData("жомок", "жомогунда")]
    [InlineData("күчүк", "күчүгүндө")]
    public void Жатыш_Алардын_Tests(string word, string expectedResult)
    {
        var actualResult = ЖатышCase.Decline(word, PronounEnum.Алар);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}