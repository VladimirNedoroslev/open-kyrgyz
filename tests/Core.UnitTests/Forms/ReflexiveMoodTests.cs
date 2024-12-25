using FluentAssertions;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms;

public class ReflexiveMoodTests
{
    [Theory]
    [InlineData("ташта", "таштан")]
    [InlineData("айт", "айтын")]
    [InlineData("тап", "табын")]
    [InlineData("изилде", "изилден")]
    [InlineData("кий", "кийин")]
    [InlineData("ойло", "ойлон")]
    [InlineData("күй", "күйүн")]
    [InlineData("түш", "түшүн")]
    [InlineData("жаса", "жасан")]
    [InlineData("ал", "алын")]
    public void ReflexiveMood_Tests(string verb, string expectedResult)
    {
        var actualResult = ReflexiveMood.Get(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}