using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Despite;

public class DespitePronounFormСенTests
{
    [Theory]
    [InlineData("кыл", "кылганыңа карабастан")]
    [InlineData("ташта", "таштаганыңа карабастан")]
    [InlineData("айт", "айтканыңа карабастан")]
    [InlineData("тап", "тапканыңа карабастан")]
    [InlineData("изилде", "изилдегениңе карабастан")]
    [InlineData("кет", "кеткениңе карабастан")]
    [InlineData("ойло", "ойлогонуңа карабастан")]
    [InlineData("күй", "күйгөнүңө карабастан")]
    [InlineData("түш", "түшкөнүңө карабастан")]
    public void DespiteFormPronounForm_Сен_Positive(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Сен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаганыңа карабастан")]
    [InlineData("ташта", "таштабаганыңа карабастан")]
    [InlineData("айт", "айтпаганыңа карабастан")]
    [InlineData("тап", "таппаганыңа карабастан")]
    [InlineData("изилде", "изилдебегениңе карабастан")]
    [InlineData("кет", "кетпегениңе карабастан")]
    [InlineData("ойло", "ойлобогонуңа карабастан")]
    [InlineData("күй", "күйбөгөнүңө карабастан")]
    [InlineData("түш", "түшпөгөнүңө карабастан")]
    public void DespiteFormPronounForm_Сен_Negative(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Сен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}