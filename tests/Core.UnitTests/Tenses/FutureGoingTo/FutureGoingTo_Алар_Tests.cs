using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.FutureGoingTo;

namespace UnitTests.Tenses.FutureGoingTo;

public class FutureGoingToАларTests
{
    [Theory]
    [InlineData("бол", "болгону жатышат")]
    [InlineData("иште", "иштегени жатышат")]
    [InlineData("бар", "барганы жатышат")]
    [InlineData("изилде", "изилдегени жатышат")]
    [InlineData("кел", "келгени жатышат")]
    [InlineData("ойно", "ойногону жатышат")]
    [InlineData("күт", "күткөнү жатышат")]
    [InlineData("тап", "тапканы жатышат")]
    [InlineData("кир", "киргени жатышат")]
    [InlineData("өт", "өткөнү жатышат")]
    [InlineData("чакыр", "чакырганы жатышат")]
    [InlineData("текшер", "текшергени жатышат")]
    [InlineData("отур", "отурганы жатышат")]
    [InlineData("үйрөт", "үйрөткөнү жатышат")]
    [InlineData("күй", "күйгөнү жатышат")]
    public void FutureGoingTo_Алар_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болгону жатышабы")]
    [InlineData("иште", "иштегени жатышабы")]
    [InlineData("бар", "барганы жатышабы")]
    [InlineData("изилде", "изилдегени жатышабы")]
    [InlineData("кел", "келгени жатышабы")]
    [InlineData("ойно", "ойногону жатышабы")]
    [InlineData("күт", "күткөнү жатышабы")]
    [InlineData("тап", "тапканы жатышабы")]
    [InlineData("кир", "киргени жатышабы")]
    [InlineData("өт", "өткөнү жатышабы")]
    [InlineData("чакыр", "чакырганы жатышабы")]
    [InlineData("текшер", "текшергени жатышабы")]
    [InlineData("отур", "отурганы жатышабы")]
    [InlineData("үйрөт", "үйрөткөнү жатышабы")]
    [InlineData("күй", "күйгөнү жатышабы")]
    public void FutureGoingTo_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}