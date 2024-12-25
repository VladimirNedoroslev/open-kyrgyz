using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms.Although;

public class AlthoughPronounFormАлTests
{
    [Theory]
    [InlineData("кыл", "кылганы менен")]
    [InlineData("ташта", "таштаганы менен")]
    [InlineData("айт", "айтканы менен")]
    [InlineData("тап", "тапканы менен")]
    [InlineData("изилде", "изилдегени менен")]
    [InlineData("кет", "кеткени менен")]
    [InlineData("ойло", "ойлогону менен")]
    [InlineData("күй", "күйгөнү менен")]
    [InlineData("түш", "түшкөнү менен")]
    public void AsSoonAsFormPronounForm_Ал_Positive(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл", "кылбаганы менен")]
    [InlineData("ташта", "таштабаганы менен")]
    [InlineData("айт", "айтпаганы менен")]
    [InlineData("тап", "таппаганы менен")]
    [InlineData("изилде", "изилдебегени менен")]
    [InlineData("кет", "кетпегени менен")]
    [InlineData("ойло", "ойлобогону менен")]
    [InlineData("күй", "күйбөгөнү менен")]
    [InlineData("түш", "түшпөгөнү менен")]
    public void AsSoonAsFormPronounForm_Ал_Negative(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Ал, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}