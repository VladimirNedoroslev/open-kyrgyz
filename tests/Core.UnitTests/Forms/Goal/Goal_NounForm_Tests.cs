using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Goal;

public class GoalNounFormTests
{
    [Theory]
    [InlineData("кыл", "кылуу үчүн")]
    [InlineData("ташта", "таштоо үчүн")]
    [InlineData("айт", "айтуу үчүн")]
    [InlineData("тап", "табуу үчүн")]
    [InlineData("изилде", "изилдөө үчүн")]
    [InlineData("кет", "кетүү үчүн")]
    [InlineData("ойло", "ойлоо үчүн")]
    [InlineData("күй", "күйүү үчүн")]
    [InlineData("түш", "түшүү үчүн")]
    public void GoalNounForm_Tests_Positive(string verb, string expectedResult)
    {
        var actualResult = GoalForm.GetInNounForm(verb, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбоо үчүн")]
    [InlineData("ташта", "таштабоо үчүн")]
    [InlineData("айт", "айтпоо үчүн")]
    [InlineData("тап", "таппоо үчүн")]
    [InlineData("изилде", "изилдебөө үчүн")]
    [InlineData("кет", "кетпөө үчүн")]
    [InlineData("ойло", "ойлобоо үчүн")]
    [InlineData("күй", "күйбөө үчүн")]
    [InlineData("түш", "түшпөө үчүн")]
    public void GoalNounForm_Tests_Negative(string verb, string expectedResult)
    {
        var actualResult = GoalForm.GetInNounForm(verb, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}