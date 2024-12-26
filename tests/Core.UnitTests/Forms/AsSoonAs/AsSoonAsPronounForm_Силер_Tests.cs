using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms.TimeRelated;

namespace UnitTests.Forms.AsSoonAs;

public class AsSoonAsPronounFormСилерTests
{
    [Theory]
    [InlineData("кыл", "кыларыңар менен")]
    [InlineData("ташта", "таштарыңар менен")]
    [InlineData("айт", "айтарыңар менен")]
    [InlineData("тап", "табарыңар менен")]
    [InlineData("изилде", "изилдериңер менен")]
    [InlineData("кет", "кетериңер менен")]
    [InlineData("ойло", "ойлоруңар менен")]
    [InlineData("күй", "күйөрүңөр менен")]
    [InlineData("түш", "түшөрүңөр менен")]
    public void AsSoonAsFormPronounForm_Силер(string verb, string expectedResult)
    {
        var actualResult = AsSoonAsForm.GetPronounForm(verb, PronounEnum.Силер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}