using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms.Cause;

public class CausePronounFormСиздерTests
{
    [Theory]
    [InlineData("кыл","кылгандыгыңыздар үчүн")]
    [InlineData("ташта","таштагандыгыңыздар үчүн")]
    [InlineData("айт","айткандыгыңыздар үчүн")]
    [InlineData("тап","тапкандыгыңыздар үчүн")]
    [InlineData("изилде","изилдегендигиңиздер үчүн")]
    [InlineData("кет","кеткендигиңиздер үчүн")]
    [InlineData("ойло","ойлогондугуңуздар үчүн")]
    [InlineData("күй","күйгөндүгүңүздөр үчүн")]
    [InlineData("түш","түшкөндүгүңүздөр үчүн")]
    public void CauseFormPronounForm_Сиздер_Positive(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл","кылбагандыгыңыздар үчүн")]
    [InlineData("ташта","таштабагандыгыңыздар үчүн")]
    [InlineData("айт","айтпагандыгыңыздар үчүн")]
    [InlineData("тап","таппагандыгыңыздар үчүн")]
    [InlineData("изилде","изилдебегендигиңиздер үчүн")]
    [InlineData("кет","кетпегендигиңиздер үчүн")]
    [InlineData("ойло","ойлобогондугуңуздар үчүн")]
    [InlineData("күй","күйбөгөндүгүңүздөр үчүн")]
    [InlineData("түш","түшпөгөндүгүңүздөр үчүн")]
    public void CauseFormPronounForm_Сиздер_Negative(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Сиздер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

}