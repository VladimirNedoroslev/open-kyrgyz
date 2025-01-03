using FluentAssertions;
using OpenKyrgyz.Core.Verbs.Forms.TimeRelated;

namespace UnitTests.Forms.TimeRelated;

public class WhenFormTests
{
    [Theory]
    [InlineData("кыл", "кылганда")]
    [InlineData("ташта", "таштаганда")]
    [InlineData("айт", "айтканда")]
    [InlineData("изилде", "изилдегенде")]
    [InlineData("кет", "кеткенде")]
    [InlineData("ойло", "ойлогондо")]
    [InlineData("күй", "күйгөндө")]
    [InlineData("түш", "түшкөндө")]
    public void WhenForm_Tests(string verb, string expectedResult)
    {
        var actualResult = WhenForm.Get(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}