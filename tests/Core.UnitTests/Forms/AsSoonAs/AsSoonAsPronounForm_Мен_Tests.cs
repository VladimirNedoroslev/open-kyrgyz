using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms.TimeRelated;

namespace UnitTests.Forms.AsSoonAs;

public class AsSoonAsPronounFormМенTests
{
    [Theory]
    [InlineData("кыл","кыларым менен")]
    [InlineData("ташта","таштарым менен")]
    [InlineData("айт","айтарым менен")]
    [InlineData("тап","табарым менен")]
    [InlineData("изилде","изилдерим менен")]
    [InlineData("кет","кетерим менен")]
    [InlineData("ойло","ойлорум менен")]
    [InlineData("күй","күйөрүм менен")]
    [InlineData("түш","түшөрүм менен")]
    public void AsSoonAsFormPronounForm_Мен(string verb, string expectedResult)
    {
        var actualResult = AsSoonAsForm.GetPronounForm(verb, PronounEnum.Мен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}