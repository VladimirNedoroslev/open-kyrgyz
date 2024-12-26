using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Cause;

public class CausePronounFormСилерTests
{
    [Theory]
    [InlineData("кыл", "кылгандыгыңар үчүн")]
    [InlineData("ташта", "таштагандыгыңар үчүн")]
    [InlineData("айт", "айткандыгыңар үчүн")]
    [InlineData("тап", "тапкандыгыңар үчүн")]
    [InlineData("изилде", "изилдегендигиңер үчүн")]
    [InlineData("кет", "кеткендигиңер үчүн")]
    [InlineData("ойло", "ойлогондугуңар үчүн")]
    [InlineData("күй", "күйгөндүгүңөр үчүн")]
    [InlineData("түш", "түшкөндүгүңөр үчүн")]
    public void CauseFormPronounForm_Силер_Positive(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Силер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбагандыгыңар үчүн")]
    [InlineData("ташта", "таштабагандыгыңар үчүн")]
    [InlineData("айт", "айтпагандыгыңар үчүн")]
    [InlineData("тап", "таппагандыгыңар үчүн")]
    [InlineData("изилде", "изилдебегендигиңер үчүн")]
    [InlineData("кет", "кетпегендигиңер үчүн")]
    [InlineData("ойло", "ойлобогондугуңар үчүн")]
    [InlineData("күй", "күйбөгөндүгүңөр үчүн")]
    [InlineData("түш", "түшпөгөндүгүңөр үчүн")]
    public void CauseFormPronounForm_Силер_Negative(string verb, string expectedResult)
    {
        var actualResult = CauseForm.GetPronounForm(verb, PronounEnum.Силер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}