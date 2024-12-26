using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Despite;

public class DespitePronounFormАлTests
{
    [Theory]
    [InlineData("кыл", "кылганына карабастан")]
    [InlineData("ташта", "таштаганына карабастан")]
    [InlineData("айт", "айтканына карабастан")]
    [InlineData("тап", "тапканына карабастан")]
    [InlineData("изилде", "изилдегенине карабастан")]
    [InlineData("кет", "кеткенине карабастан")]
    [InlineData("ойло", "ойлогонуна карабастан")]
    [InlineData("күй", "күйгөнүнө карабастан")]
    [InlineData("түш", "түшкөнүнө карабастан")]
    public void DespiteFormPronounForm_Ал_Positive(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаганына карабастан")]
    [InlineData("ташта", "таштабаганына карабастан")]
    [InlineData("айт", "айтпаганына карабастан")]
    [InlineData("тап", "таппаганына карабастан")]
    [InlineData("изилде", "изилдебегенине карабастан")]
    [InlineData("кет", "кетпегенине карабастан")]
    [InlineData("ойло", "ойлобогонуна карабастан")]
    [InlineData("күй", "күйбөгөнүнө карабастан")]
    [InlineData("түш", "түшпөгөнүнө карабастан")]
    public void DespiteFormPronounForm_Ал_Negative(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Ал, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}