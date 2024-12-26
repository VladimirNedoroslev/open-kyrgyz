using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Goal;

public class GoalCooperativeFormTests
{
    [Theory]
    [InlineData("кыл", "кылыш үчүн")]
    [InlineData("ташта", "ташташ үчүн")]
    [InlineData("айт", "айтыш үчүн")]
    [InlineData("тап", "табыш үчүн")]
    [InlineData("изилде", "изилдеш үчүн")]
    [InlineData("кет", "кетиш үчүн")]
    [InlineData("ойло", "ойлош үчүн")]
    [InlineData("күй", "күйүш үчүн")]
    [InlineData("түш", "түшүш үчүн")]
    public void GoalCooperativeForm_Tests_Positive(string verb, string expectedResult)
    {
        var actualResult = GoalForm.GetInCooperativeForm(verb, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаш үчүн")]
    [InlineData("ташта", "таштабаш үчүн")]
    [InlineData("айт", "айтпаш үчүн")]
    [InlineData("тап", "таппаш үчүн")]
    [InlineData("изилде", "изилдебеш үчүн")]
    [InlineData("кет", "кетпеш үчүн")]
    [InlineData("ойло", "ойлобош үчүн")]
    [InlineData("күй", "күйбөш үчүн")]
    [InlineData("түш", "түшпөш үчүн")]
    public void GoalCooperativeForm_Tests_Negative(string verb, string expectedResult)
    {
        var actualResult = GoalForm.GetInCooperativeForm(verb, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}