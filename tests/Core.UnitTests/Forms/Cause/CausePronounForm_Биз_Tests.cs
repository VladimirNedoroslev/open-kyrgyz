using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms.Cause;

public class CausePronounFormБизTests
{
    [Theory]
    [InlineData("кыл","кылгандыгыбыз үчүн")]
    [InlineData("ташта","таштагандыгыбыз үчүн")]
    [InlineData("айт","айткандыгыбыз үчүн")]
    [InlineData("тап","тапкандыгыбыз үчүн")]
    [InlineData("изилде","изилдегендигибиз үчүн")]
    [InlineData("кет","кеткендигибиз үчүн")]
    [InlineData("ойло","ойлогондугубуз үчүн")]
    [InlineData("күй","күйгөндүгүбүз үчүн")]
    [InlineData("түш","түшкөндүгүбүз үчүн")]
    public void CauseFormPronounForm_Биз_Positive(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл","кылбагандыгыбыз үчүн")]
    [InlineData("ташта","таштабагандыгыбыз үчүн")]
    [InlineData("айт","айтпагандыгыбыз үчүн")]
    [InlineData("тап","таппагандыгыбыз үчүн")]
    [InlineData("изилде","изилдебегендигибиз үчүн")]
    [InlineData("кет","кетпегендигибиз үчүн")]
    [InlineData("ойло","ойлобогондугубуз үчүн")]
    [InlineData("күй","күйбөгөндүгүбүз үчүн")]
    [InlineData("түш","түшпөгөндүгүбүз үчүн")]
    public void CauseFormPronounForm_Биз_Negative(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Биз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

}