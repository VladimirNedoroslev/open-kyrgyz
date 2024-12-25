using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms.Cause;

public class CausePronounFormСенTests
{
    [Theory]
    [InlineData("кыл","кылгандыгың үчүн")]
    [InlineData("ташта","таштагандыгың үчүн")]
    [InlineData("айт","айткандыгың үчүн")]
    [InlineData("тап","тапкандыгың үчүн")]
    [InlineData("изилде","изилдегендигиң үчүн")]
    [InlineData("кет","кеткендигиң үчүн")]
    [InlineData("ойло","ойлогондугуң үчүн")]
    [InlineData("күй","күйгөндүгүң үчүн")]
    [InlineData("түш","түшкөндүгүң үчүн")]
    public void CauseFormPronounForm_Сен_Positive(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Сен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл","кылбагандыгың үчүн")]
    [InlineData("ташта","таштабагандыгың үчүн")]
    [InlineData("айт","айтпагандыгың үчүн")]
    [InlineData("тап","таппагандыгың үчүн")]
    [InlineData("изилде","изилдебегендигиң үчүн")]
    [InlineData("кет","кетпегендигиң үчүн")]
    [InlineData("ойло","ойлобогондугуң үчүн")]
    [InlineData("күй","күйбөгөндүгүң үчүн")]
    [InlineData("түш","түшпөгөндүгүң үчүн")]
    public void CauseFormPronounForm_Сен_Negative(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Сен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

}