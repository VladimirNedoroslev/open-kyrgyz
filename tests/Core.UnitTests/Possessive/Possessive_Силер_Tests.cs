using FluentAssertions;
using OpenKyrgyz.Core.Possessive;

namespace UnitTests.Possessive;

public class PossessiveСилерTests
{
    [Theory]
    [InlineData("апа", "апаңар")]
    [InlineData("ой", "оюңар")]
    [InlineData("дос", "досуңар")]
    [InlineData("ини", "иниңер")]
    [InlineData("сүрөт", "сүрөтүңөр")]
    [InlineData("карындаш", "карындашыңар")]
    [InlineData("жомок", "жомогуңар")]
    [InlineData("күчүк", "күчүгүңөр")]
    public void PossessiveСилер_Tests(string word, string expectedResult)
    {
        var actualResult = PossessiveСилер.ToPossessive(word);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}