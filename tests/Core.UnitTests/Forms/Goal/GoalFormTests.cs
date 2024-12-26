using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Goal;

public class GoalFormTests
{
    [Theory]
    [InlineData("кыл", "кылганы")]
    [InlineData("ташта", "таштаганы")]
    [InlineData("айт", "айтканы")]
    [InlineData("тап", "тапканы")]
    [InlineData("изилде", "изилдегени")]
    [InlineData("кет", "кеткени")]
    [InlineData("ойло", "ойлогону")]
    [InlineData("күй", "күйгөнү")]
    [InlineData("түш", "түшкөнү")]
    public void GoalForm_Tests_Positive(string verb, string expectedResult)
    {
        var actualResult = GoalForm.Get(verb, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаганы")]
    [InlineData("ташта", "таштабаганы")]
    [InlineData("айт", "айтпаганы")]
    [InlineData("тап", "таппаганы")]
    [InlineData("изилде", "изилдебегени")]
    [InlineData("кет", "кетпегени")]
    [InlineData("ойло", "ойлобогону")]
    [InlineData("күй", "күйбөгөнү")]
    [InlineData("түш", "түшпөгөнү")]
    public void GoalForm_Tests_Negative(string verb, string expectedResult)
    {
        var actualResult = GoalForm.Get(verb, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}