using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.FutureGoingTo;

namespace UnitTests.Tenses.FutureGoingTo;

public class FutureGoingToАлTests
{
    [Theory]
    [InlineData("бол", "болгону жатат")]
    [InlineData("иште", "иштегени жатат")]
    [InlineData("бар", "барганы жатат")]
    [InlineData("изилде", "изилдегени жатат")]
    [InlineData("кел", "келгени жатат")]
    [InlineData("ойно", "ойногону жатат")]
    [InlineData("күт", "күткөнү жатат")]
    [InlineData("тап", "тапканы жатат")]
    [InlineData("кир", "киргени жатат")]
    [InlineData("өт", "өткөнү жатат")]
    [InlineData("чакыр", "чакырганы жатат")]
    [InlineData("текшер", "текшергени жатат")]
    [InlineData("отур", "отурганы жатат")]
    [InlineData("үйрөт", "үйрөткөнү жатат")]
    [InlineData("күй", "күйгөнү жатат")]
    public void FutureGoingTo_Ал_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болгону жатабы")]
    [InlineData("иште", "иштегени жатабы")]
    [InlineData("бар", "барганы жатабы")]
    [InlineData("изилде", "изилдегени жатабы")]
    [InlineData("кел", "келгени жатабы")]
    [InlineData("ойно", "ойногону жатабы")]
    [InlineData("күт", "күткөнү жатабы")]
    [InlineData("тап", "тапканы жатабы")]
    [InlineData("кир", "киргени жатабы")]
    [InlineData("өт", "өткөнү жатабы")]
    [InlineData("чакыр", "чакырганы жатабы")]
    [InlineData("текшер", "текшергени жатабы")]
    [InlineData("отур", "отурганы жатабы")]
    [InlineData("үйрөт", "үйрөткөнү жатабы")]
    [InlineData("күй", "күйгөнү жатабы")]
    public void FutureGoingTo_Ал_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}