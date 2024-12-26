using FluentAssertions;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms;

public class DirectObjectFormTests
{
    [Theory]
    [InlineData("кыл", "кылганды")]
    [InlineData("ташта", "таштаганды")]
    [InlineData("айт", "айтканды")]
    [InlineData("изилде", "изилдегенди")]
    [InlineData("кет", "кеткенди")]
    [InlineData("ойло", "ойлогонду")]
    [InlineData("күй", "күйгөндү")]
    [InlineData("түш", "түшкөндү")]
    public void DirectObjectForm_Tests(string verb, string expectedResult)
    {
        var actualResult = DirectObjectForm.Get(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}