using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Although;

public class AlthoughPronounFormБизTests
{
    [Theory]
    [InlineData("кыл", "кылганыбыз менен")]
    [InlineData("ташта", "таштаганыбыз менен")]
    [InlineData("айт", "айтканыбыз менен")]
    [InlineData("тап", "тапканыбыз менен")]
    [InlineData("изилде", "изилдегенибиз менен")]
    [InlineData("кет", "кеткенибиз менен")]
    [InlineData("ойло", "ойлогонубуз менен")]
    [InlineData("күй", "күйгөнүбүз менен")]
    [InlineData("түш", "түшкөнүбүз менен")]
    public void AlthoughFormPronounForm_Биз_Positive(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаганыбыз менен")]
    [InlineData("ташта", "таштабаганыбыз менен")]
    [InlineData("айт", "айтпаганыбыз менен")]
    [InlineData("тап", "таппаганыбыз менен")]
    [InlineData("изилде", "изилдебегенибиз менен")]
    [InlineData("кет", "кетпегенибиз менен")]
    [InlineData("ойло", "ойлобогонубуз менен")]
    [InlineData("күй", "күйбөгөнүбүз менен")]
    [InlineData("түш", "түшпөгөнүбүз менен")]
    public void AlthoughFormPronounForm_Биз_Negative(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Биз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}