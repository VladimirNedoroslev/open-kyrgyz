using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms.TimeRelated;

namespace UnitTests.Forms.AsSoonAs;

public class AsSoonAsPronounFormСизTests
{
    [Theory]
    [InlineData("кыл", "кыларыңыз менен")]
    [InlineData("ташта", "таштарыңыз менен")]
    [InlineData("айт", "айтарыңыз менен")]
    [InlineData("тап", "табарыңыз менен")]
    [InlineData("изилде", "изилдериңиз менен")]
    [InlineData("кет", "кетериңиз менен")]
    [InlineData("ойло", "ойлоруңуз менен")]
    [InlineData("күй", "күйөрүңүз менен")]
    [InlineData("түш", "түшөрүңүз менен")]
    public void AsSoonAsFormPronounForm_Сиз(string verb, string expectedResult)
    {
        var actualResult = AsSoonAsForm.GetPronounForm(verb, PronounEnum.Сиз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}