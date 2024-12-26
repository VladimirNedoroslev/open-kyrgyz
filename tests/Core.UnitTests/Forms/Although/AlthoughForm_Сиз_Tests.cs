using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Although;

public class AlthoughPronounFormСизTests
{
    [Theory]
    [InlineData("кыл", "кылганыңыз менен")]
    [InlineData("ташта", "таштаганыңыз менен")]
    [InlineData("айт", "айтканыңыз менен")]
    [InlineData("тап", "тапканыңыз менен")]
    [InlineData("изилде", "изилдегениңиз менен")]
    [InlineData("кет", "кеткениңиз менен")]
    [InlineData("ойло", "ойлогонуңуз менен")]
    [InlineData("күй", "күйгөнүңүз менен")]
    [InlineData("түш", "түшкөнүңүз менен")]
    public void AlthoughFormPronounForm_Сиз_Positive(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаганыңыз менен")]
    [InlineData("ташта", "таштабаганыңыз менен")]
    [InlineData("айт", "айтпаганыңыз менен")]
    [InlineData("тап", "таппаганыңыз менен")]
    [InlineData("изилде", "изилдебегениңиз менен")]
    [InlineData("кет", "кетпегениңиз менен")]
    [InlineData("ойло", "ойлобогонуңуз менен")]
    [InlineData("күй", "күйбөгөнүңүз менен")]
    [InlineData("түш", "түшпөгөнүңүз менен")]
    public void AlthoughFormPronounForm_Сиз_Negative(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Сиз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}