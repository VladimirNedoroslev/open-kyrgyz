using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms.Cause;

public class CausePronounFormМенTests
{
    [Theory]
    [InlineData("кыл","кылгандыгым үчүн")]
    [InlineData("ташта","таштагандыгым үчүн")]
    [InlineData("айт","айткандыгым үчүн")]
    [InlineData("тап","тапкандыгым үчүн")]
    [InlineData("изилде","изилдегендигим үчүн")]
    [InlineData("кет","кеткендигим үчүн")]
    [InlineData("ойло","ойлогондугум үчүн")]
    [InlineData("күй","күйгөндүгүм үчүн")]
    [InlineData("түш","түшкөндүгүм үчүн")]
    public void CauseFormPronounForm_Мен_Positive(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Мен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл","кылбагандыгым үчүн")]
    [InlineData("ташта","таштабагандыгым үчүн")]
    [InlineData("айт","айтпагандыгым үчүн")]
    [InlineData("тап","таппагандыгым үчүн")]
    [InlineData("изилде","изилдебегендигим үчүн")]
    [InlineData("кет","кетпегендигим үчүн")]
    [InlineData("ойло","ойлобогондугум үчүн")]
    [InlineData("күй","күйбөгөндүгүм үчүн")]
    [InlineData("түш","түшпөгөндүгүм үчүн")]
    public void CauseFormPronounForm_Мен_Negative(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Мен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

}