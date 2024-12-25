using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms.Although;

public class AlthoughPronounFormСилерTests
{
    [Theory]
    [InlineData("кыл", "кылганыңар менен")]
    [InlineData("ташта", "таштаганыңар менен")]
    [InlineData("айт", "айтканыңар менен")]
    [InlineData("тап", "тапканыңар менен")]
    [InlineData("изилде", "изилдегениңер менен")]
    [InlineData("кет", "кеткениңер менен")]
    [InlineData("ойло", "ойлогонуңар менен")]
    [InlineData("күй", "күйгөнүңөр менен")]
    [InlineData("түш", "түшкөнүңөр менен")]
    public void AsSoonAsFormPronounForm_Силер_Positive(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Силер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл", "кылбаганыңар менен")]
    [InlineData("ташта", "таштабаганыңар менен")]
    [InlineData("айт", "айтпаганыңар менен")]
    [InlineData("тап", "таппаганыңар менен")]
    [InlineData("изилде", "изилдебегениңер менен")]
    [InlineData("кет", "кетпегениңер менен")]
    [InlineData("ойло", "ойлобогонуңар менен")]
    [InlineData("күй", "күйбөгөнүңөр менен")]
    [InlineData("түш", "түшпөгөнүңөр менен")]
    public void AsSoonAsFormPronounForm_Силер_Negative(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Силер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}