using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Although;

public class AlthoughPronounFormМенTests
{
    [Theory]
    [InlineData("кыл", "кылганым менен")]
    [InlineData("ташта", "таштаганым менен")]
    [InlineData("айт", "айтканым менен")]
    [InlineData("тап", "тапканым менен")]
    [InlineData("изилде", "изилдегеним менен")]
    [InlineData("кет", "кеткеним менен")]
    [InlineData("ойло", "ойлогонум менен")]
    [InlineData("күй", "күйгөнүм менен")]
    [InlineData("түш", "түшкөнүм менен")]
    public void AlthoughFormPronounForm_Мен_Positive(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Мен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаганым менен")]
    [InlineData("ташта", "таштабаганым менен")]
    [InlineData("айт", "айтпаганым менен")]
    [InlineData("тап", "таппаганым менен")]
    [InlineData("изилде", "изилдебегеним менен")]
    [InlineData("кет", "кетпегеним менен")]
    [InlineData("ойло", "ойлобогонум менен")]
    [InlineData("күй", "күйбөгөнүм менен")]
    [InlineData("түш", "түшпөгөнүм менен")]
    public void AlthoughFormPronounForm_Мен_Negative(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Мен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}