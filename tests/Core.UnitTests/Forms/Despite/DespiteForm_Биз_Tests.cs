using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Despite;

public class DespitePronounFormБизTests
{
    [Theory]
    [InlineData("кыл", "кылганыбызга карабастан")]
    [InlineData("ташта", "таштаганыбызга карабастан")]
    [InlineData("айт", "айтканыбызга карабастан")]
    [InlineData("тап", "тапканыбызга карабастан")]
    [InlineData("изилде", "изилдегенибизге карабастан")]
    [InlineData("кет", "кеткенибизге карабастан")]
    [InlineData("ойло", "ойлогонубузга карабастан")]
    [InlineData("күй", "күйгөнүбүзгө карабастан")]
    [InlineData("түш", "түшкөнүбүзгө карабастан")]
    public void DespiteFormPronounForm_Биз_Positive(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаганыбызга карабастан")]
    [InlineData("ташта", "таштабаганыбызга карабастан")]
    [InlineData("айт", "айтпаганыбызга карабастан")]
    [InlineData("тап", "таппаганыбызга карабастан")]
    [InlineData("изилде", "изилдебегенибизге карабастан")]
    [InlineData("кет", "кетпегенибизге карабастан")]
    [InlineData("ойло", "ойлобогонубузга карабастан")]
    [InlineData("күй", "күйбөгөнүбүзгө карабастан")]
    [InlineData("түш", "түшпөгөнүбүзгө карабастан")]
    public void DespiteFormPronounForm_Биз_Negative(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Биз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}