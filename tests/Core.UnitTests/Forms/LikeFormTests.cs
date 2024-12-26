using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms;

public class LikeFormTests
{
    [Theory]
    [InlineData("кыл", "кылгандай")]
    [InlineData("ташта", "таштагандай")]
    [InlineData("айт", "айткандай")]
    [InlineData("тап", "тапкандай")]
    [InlineData("изилде", "изилдегендей")]
    [InlineData("кет", "кеткендей")]
    [InlineData("ойло", "ойлогондой")]
    [InlineData("күй", "күйгөндөй")]
    [InlineData("түш", "түшкөндөй")]
    public void LikeForm_Tests_Positive(string verb, string expectedResult)
    {
        var actualResult = LikeForm.Get(verb, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбагандай")]
    [InlineData("ташта", "таштабагандай")]
    [InlineData("айт", "айтпагандай")]
    [InlineData("тап", "таппагандай")]
    [InlineData("изилде", "изилдебегендей")]
    [InlineData("кет", "кетпегендей")]
    [InlineData("ойло", "ойлобогондой")]
    [InlineData("күй", "күйбөгөндөй")]
    [InlineData("түш", "түшпөгөндөй")]
    public void LikeForm_Tests_Negative(string verb, string expectedResult)
    {
        var actualResult = LikeForm.Get(verb, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}