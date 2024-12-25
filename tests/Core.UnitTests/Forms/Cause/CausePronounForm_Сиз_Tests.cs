using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms.Cause;

public class CausePronounFormСизTests
{
    [Theory]
    [InlineData("кыл","кылгандыгыңыз үчүн")]
    [InlineData("ташта","таштагандыгыңыз үчүн")]
    [InlineData("айт","айткандыгыңыз үчүн")]
    [InlineData("тап","тапкандыгыңыз үчүн")]
    [InlineData("изилде","изилдегендигиңиз үчүн")]
    [InlineData("кет","кеткендигиңиз үчүн")]
    [InlineData("ойло","ойлогондугуңуз үчүн")]
    [InlineData("күй","күйгөндүгүңүз үчүн")]
    [InlineData("түш","түшкөндүгүңүз үчүн")]
    public void CauseFormPronounForm_Сиз_Positive(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл","кылбагандыгыңыз үчүн")]
    [InlineData("ташта","таштабагандыгыңыз үчүн")]
    [InlineData("айт","айтпагандыгыңыз үчүн")]
    [InlineData("тап","таппагандыгыңыз үчүн")]
    [InlineData("изилде","изилдебегендигиңиз үчүн")]
    [InlineData("кет","кетпегендигиңиз үчүн")]
    [InlineData("ойло","ойлобогондугуңуз үчүн")]
    [InlineData("күй","күйбөгөндүгүңүз үчүн")]
    [InlineData("түш","түшпөгөндүгүңүз үчүн")]
    public void CauseFormPronounForm_Сиз_Negative(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Сиз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

}