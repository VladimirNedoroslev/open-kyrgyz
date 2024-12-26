using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Despite;

public class DespitePronounFormМенTests
{
    [Theory]
    [InlineData("кыл", "кылганыма карабастан")]
    [InlineData("ташта", "таштаганыма карабастан")]
    [InlineData("айт", "айтканыма карабастан")]
    [InlineData("тап", "тапканыма карабастан")]
    [InlineData("изилде", "изилдегениме карабастан")]
    [InlineData("кет", "кеткениме карабастан")]
    [InlineData("ойло", "ойлогонума карабастан")]
    [InlineData("күй", "күйгөнүмө карабастан")]
    [InlineData("түш", "түшкөнүмө карабастан")]
    public void DespiteFormPronounForm_Мен_Positive(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Мен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаганыма карабастан")]
    [InlineData("ташта", "таштабаганыма карабастан")]
    [InlineData("айт", "айтпаганыма карабастан")]
    [InlineData("тап", "таппаганыма карабастан")]
    [InlineData("изилде", "изилдебегениме карабастан")]
    [InlineData("кет", "кетпегениме карабастан")]
    [InlineData("ойло", "ойлобогонума карабастан")]
    [InlineData("күй", "күйбөгөнүмө карабастан")]
    [InlineData("түш", "түшпөгөнүмө карабастан")]
    public void DespiteFormPronounForm_Мен_Negative(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Мен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}