using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Despite;

public class DespitePronounFormСилерTests
{
    [Theory]
    [InlineData("кыл", "кылганыңарга карабастан")]
    [InlineData("ташта", "таштаганыңарга карабастан")]
    [InlineData("айт", "айтканыңарга карабастан")]
    [InlineData("тап", "тапканыңарга карабастан")]
    [InlineData("изилде", "изилдегениңерге карабастан")]
    [InlineData("кет", "кеткениңерге карабастан")]
    [InlineData("ойло", "ойлогонуңарга карабастан")]
    [InlineData("күй", "күйгөнүңөргө карабастан")]
    [InlineData("түш", "түшкөнүңөргө карабастан")]
    public void DespiteFormPronounForm_Силер_Positive(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Силер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаганыңарга карабастан")]
    [InlineData("ташта", "таштабаганыңарга карабастан")]
    [InlineData("айт", "айтпаганыңарга карабастан")]
    [InlineData("тап", "таппаганыңарга карабастан")]
    [InlineData("изилде", "изилдебегениңерге карабастан")]
    [InlineData("кет", "кетпегениңерге карабастан")]
    [InlineData("ойло", "ойлобогонуңарга карабастан")]
    [InlineData("күй", "күйбөгөнүңөргө карабастан")]
    [InlineData("түш", "түшпөгөнүңөргө карабастан")]
    public void DespiteFormPronounForm_Силер_Negative(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Силер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}