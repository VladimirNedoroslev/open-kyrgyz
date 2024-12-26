using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms.TimeRelated;

namespace UnitTests.Forms.AsSoonAs;

public class AsSoonAsPronounFormБизTests
{
    [Theory]
    [InlineData("кыл", "кыларыбыз менен")]
    [InlineData("ташта", "таштарыбыз менен")]
    [InlineData("айт", "айтарыбыз менен")]
    [InlineData("тап", "табарыбыз менен")]
    [InlineData("изилде", "изилдерибиз менен")]
    [InlineData("кет", "кетерибиз менен")]
    [InlineData("ойло", "ойлорубуз менен")]
    [InlineData("күй", "күйөрүбүз менен")]
    [InlineData("түш", "түшөрүбүз менен")]
    public void AsSoonAsFormPronounForm_Биз(string verb, string expectedResult)
    {
        var actualResult = AsSoonAsForm.GetPronounForm(verb, PronounEnum.Биз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}