using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms.TimeRelated;

namespace UnitTests.Forms.AsSoonAs;

public class AsSoonAsPronounFormСиздерTests
{
    [Theory]
    [InlineData("кыл", "кыларыңыздар менен")]
    [InlineData("ташта", "таштарыңыздар менен")]
    [InlineData("айт", "айтарыңыздар менен")]
    [InlineData("тап", "табарыңыздар менен")]
    [InlineData("изилде", "изилдериңиздер менен")]
    [InlineData("кет", "кетериңиздер менен")]
    [InlineData("ойло", "ойлоруңуздар менен")]
    [InlineData("күй", "күйөрүңүздөр менен")]
    [InlineData("түш", "түшөрүңүздөр менен")]
    public void AsSoonAsFormPronounForm_Сиздер(string verb, string expectedResult)
    {
        var actualResult = AsSoonAsForm.GetPronounForm(verb, PronounEnum.Сиздер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}