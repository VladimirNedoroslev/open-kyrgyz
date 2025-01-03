using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Cause;

public class CausePronounFormАлTests
{
    [Theory]
    [InlineData("кыл", "кылгандыгы үчүн")]
    [InlineData("ташта", "таштагандыгы үчүн")]
    [InlineData("айт", "айткандыгы үчүн")]
    [InlineData("тап", "тапкандыгы үчүн")]
    [InlineData("изилде", "изилдегендиги үчүн")]
    [InlineData("кет", "кеткендиги үчүн")]
    [InlineData("ойло", "ойлогондугу үчүн")]
    [InlineData("күй", "күйгөндүгү үчүн")]
    [InlineData("түш", "түшкөндүгү үчүн")]
    public void CauseFormPronounForm_Ал_Positive(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбагандыгы үчүн")]
    [InlineData("ташта", "таштабагандыгы үчүн")]
    [InlineData("айт", "айтпагандыгы үчүн")]
    [InlineData("тап", "таппагандыгы үчүн")]
    [InlineData("изилде", "изилдебегендиги үчүн")]
    [InlineData("кет", "кетпегендиги үчүн")]
    [InlineData("ойло", "ойлобогондугу үчүн")]
    [InlineData("күй", "күйбөгөндүгү үчүн")]
    [InlineData("түш", "түшпөгөндүгү үчүн")]
    public void CauseFormPronounForm_Ал_Negative(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Ал, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}