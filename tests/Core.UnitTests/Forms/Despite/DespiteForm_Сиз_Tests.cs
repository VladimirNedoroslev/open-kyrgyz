using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Despite;

public class DespitePronounFormСизTests
{
    [Theory]
    [InlineData("кыл", "кылганыңызга карабастан")]
    [InlineData("ташта", "таштаганыңызга карабастан")]
    [InlineData("айт", "айтканыңызга карабастан")]
    [InlineData("тап", "тапканыңызга карабастан")]
    [InlineData("изилде", "изилдегениңизге карабастан")]
    [InlineData("кет", "кеткениңизге карабастан")]
    [InlineData("ойло", "ойлогонуңузга карабастан")]
    [InlineData("күй", "күйгөнүңүзгө карабастан")]
    [InlineData("түш", "түшкөнүңүзгө карабастан")]
    public void DespiteFormPronounForm_Сиз_Positive(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаганыңызга карабастан")]
    [InlineData("ташта", "таштабаганыңызга карабастан")]
    [InlineData("айт", "айтпаганыңызга карабастан")]
    [InlineData("тап", "таппаганыңызга карабастан")]
    [InlineData("изилде", "изилдебегениңизге карабастан")]
    [InlineData("кет", "кетпегениңизге карабастан")]
    [InlineData("ойло", "ойлобогонуңузга карабастан")]
    [InlineData("күй", "күйбөгөнүңүзгө карабастан")]
    [InlineData("түш", "түшпөгөнүңүзгө карабастан")]
    public void DespiteFormPronounForm_Сиз_Negative(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Сиз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}