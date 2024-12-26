using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms.Despite;

public class DespitePronounFormСиздерTests
{
    [Theory]
    [InlineData("кыл", "кылганыңыздарга карабастан")]
    [InlineData("ташта", "таштаганыңыздарга карабастан")]
    [InlineData("айт", "айтканыңыздарга карабастан")]
    [InlineData("тап", "тапканыңыздарга карабастан")]
    [InlineData("изилде", "изилдегениңиздерге карабастан")]
    [InlineData("кет", "кеткениңиздерге карабастан")]
    [InlineData("ойло", "ойлогонуңуздарга карабастан")]
    [InlineData("күй", "күйгөнүңүздөргө карабастан")]
    [InlineData("түш", "түшкөнүңүздөргө карабастан")]
    public void DespiteFormPronounForm_Сиздер_Positive(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаганыңыздарга карабастан")]
    [InlineData("ташта", "таштабаганыңыздарга карабастан")]
    [InlineData("айт", "айтпаганыңыздарга карабастан")]
    [InlineData("тап", "таппаганыңыздарга карабастан")]
    [InlineData("изилде", "изилдебегениңиздерге карабастан")]
    [InlineData("кет", "кетпегениңиздерге карабастан")]
    [InlineData("ойло", "ойлобогонуңуздарга карабастан")]
    [InlineData("күй", "күйбөгөнүңүздөргө карабастан")]
    [InlineData("түш", "түшпөгөнүңүздөргө карабастан")]
    public void DespiteFormPronounForm_Сиздер_Negative(string verb, string expectedResult)
    {
        var actualResult = DespiteForm.ToDespiteForm(verb, PronounEnum.Сиздер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}