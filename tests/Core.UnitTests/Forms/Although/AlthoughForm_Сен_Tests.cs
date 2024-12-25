using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms.Although;

public class AlthoughPronounFormСенTests
{
    [Theory]
    [InlineData("кыл", "кылганың менен")]
    [InlineData("ташта", "таштаганың менен")]
    [InlineData("айт", "айтканың менен")]
    [InlineData("тап", "тапканың менен")]
    [InlineData("изилде", "изилдегениң менен")]
    [InlineData("кет", "кеткениң менен")]
    [InlineData("ойло", "ойлогонуң менен")]
    [InlineData("күй", "күйгөнүң менен")]
    [InlineData("түш", "түшкөнүң менен")]
    public void AsSoonAsFormPronounForm_Сен_Positive(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Сен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл", "кылбаганың менен")]
    [InlineData("ташта", "таштабаганың менен")]
    [InlineData("айт", "айтпаганың менен")]
    [InlineData("тап", "таппаганың менен")]
    [InlineData("изилде", "изилдебегениң менен")]
    [InlineData("кет", "кетпегениң менен")]
    [InlineData("ойло", "ойлобогонуң менен")]
    [InlineData("күй", "күйбөгөнүң менен")]
    [InlineData("түш", "түшпөгөнүң менен")]
    public void AsSoonAsFormPronounForm_Сен_Negative(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Сен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}