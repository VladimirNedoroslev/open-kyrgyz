using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms.TimeRelated;

namespace UnitTests.Forms.AsSoonAs;

public class AsSoonAsPronounFormАлTests
{
    [Theory]
    [InlineData("кыл","кылары менен")]
    [InlineData("ташта","таштары менен")]
    [InlineData("айт","айтары менен")]
    [InlineData("тап","табары менен")]
    [InlineData("изилде","изилдери менен")]
    [InlineData("кет","кетери менен")]
    [InlineData("ойло","ойлору менен")]
    [InlineData("күй","күйөрү менен")]
    [InlineData("түш","түшөрү менен")]
    public void AsSoonAsFormPronounForm_Ал(string verb, string expectedResult)
    {
        var actualResult = AsSoonAsForm.GetPronounForm(verb, PronounEnum.Ал);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}