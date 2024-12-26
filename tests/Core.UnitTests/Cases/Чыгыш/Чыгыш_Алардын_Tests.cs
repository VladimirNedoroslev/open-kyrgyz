using FluentAssertions;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace UnitTests.Cases.Чыгыш;

public class ЧыгышАлардынTests
{
    [Theory]
    [InlineData("апа", "апасынан")]
    [InlineData("ини", "инисинен")]
    [InlineData("ой", "оюнан")]
    [InlineData("күзгү", "күзгүсүнөн")]
    [InlineData("карындаш", "карындашынан")]
    [InlineData("керебет", "керебетинен")]
    [InlineData("дос", "досунан")]
    [InlineData("сүрөт", "сүрөтүнөн")]
    [InlineData("жомок", "жомогунан")]
    [InlineData("күчүк", "күчүгүнөн")]
    public void Чыгыш_Алардын_Tests(string word, string expectedResult)
    {
        var actualResult = ЧыгышCase.Decline(word, PronounEnum.Алар);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}