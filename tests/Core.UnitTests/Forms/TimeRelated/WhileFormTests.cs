using FluentAssertions;
using OpenKyrgyz.Core.Verbs.Forms.TimeRelated;

namespace UnitTests.Forms.TimeRelated;

public class WhileFormTests
{
    [Theory]
    [InlineData("кыл", "кылганча")]
    [InlineData("ташта", "таштаганча")]
    [InlineData("айт", "айтканча")]
    [InlineData("тап", "тапканча")]
    [InlineData("изилде", "изилдегенче")]
    [InlineData("кет", "кеткенче")]
    [InlineData("ойло", "ойлогончо")]
    [InlineData("күй", "күйгөнчө")]
    [InlineData("түш", "түшкөнчө")]
    public void WhileForm_Tests(string verb, string expectedResult)
    {
        var actualResult = WhileForm.Get(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}