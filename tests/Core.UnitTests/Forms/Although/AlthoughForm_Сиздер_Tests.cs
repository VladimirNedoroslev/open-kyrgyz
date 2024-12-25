using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms.Although;

public class AlthoughPronounFormСиздерTests
{
    [Theory]
    [InlineData("кыл", "кылганыңыздар менен")]
    [InlineData("ташта", "таштаганыңыздар менен")]
    [InlineData("айт", "айтканыңыздар менен")]
    [InlineData("тап", "тапканыңыздар менен")]
    [InlineData("изилде", "изилдегениңиздер менен")]
    [InlineData("кет", "кеткениңиздер менен")]
    [InlineData("ойло", "ойлогонуңуздар менен")]
    [InlineData("күй", "күйгөнүңүздөр менен")]
    [InlineData("түш", "түшкөнүңүздөр менен")]
    public void AsSoonAsFormPronounForm_Сиздер_Positive(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл", "кылбаганыңыздар менен")]
    [InlineData("ташта", "таштабаганыңыздар менен")]
    [InlineData("айт", "айтпаганыңыздар менен")]
    [InlineData("тап", "таппаганыңыздар менен")]
    [InlineData("изилде", "изилдебегениңиздер менен")]
    [InlineData("кет", "кетпегениңиздер менен")]
    [InlineData("ойло", "ойлобогонуңуздар менен")]
    [InlineData("күй", "күйбөгөнүңүздөр менен")]
    [InlineData("түш", "түшпөгөнүңүздөр менен")]
    public void AsSoonAsFormPronounForm_Сиздер_Negative(string verb, string expectedResult)
    {
        var actualResult = AlthoughForm.ToAlthoughForm(verb, PronounEnum.Сиздер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}