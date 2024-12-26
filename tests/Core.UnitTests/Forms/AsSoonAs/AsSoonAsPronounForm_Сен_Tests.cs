using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms.TimeRelated;

namespace UnitTests.Forms.AsSoonAs;

public class AsSoonAsPronounFormСенTests
{
    [Theory]
    [InlineData("кыл", "кыларың менен")]
    [InlineData("ташта", "таштарың менен")]
    [InlineData("айт", "айтарың менен")]
    [InlineData("тап", "табарың менен")]
    [InlineData("изилде", "изилдериң менен")]
    [InlineData("кет", "кетериң менен")]
    [InlineData("ойло", "ойлоруң менен")]
    [InlineData("күй", "күйөрүң менен")]
    [InlineData("түш", "түшөрүң менен")]
    public void AsSoonAsFormPronounForm_Сен(string verb, string expectedResult)
    {
        var actualResult = AsSoonAsForm.GetPronounForm(verb, PronounEnum.Сен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}