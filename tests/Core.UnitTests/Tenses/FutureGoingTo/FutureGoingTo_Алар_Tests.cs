using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.FutureGoingTo;

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
    [InlineData("бол", "болгону жатышатпы")]
    [InlineData("иште", "иштегени жатышатпы")]
    [InlineData("бар", "барганы жатышатпы")]
    [InlineData("изилде", "изилдегени жатышатпы")]
    [InlineData("кел", "келгени жатышатпы")]
    [InlineData("ойно", "ойногону жатышатпы")]
    [InlineData("күт", "күткөнү жатышатпы")]
    [InlineData("тап", "тапканы жатышатпы")]
    [InlineData("кир", "киргени жатышатпы")]
    [InlineData("өт", "өткөнү жатышатпы")]
    [InlineData("чакыр", "чакырганы жатышатпы")]
    [InlineData("текшер", "текшергени жатышатпы")]
    [InlineData("отур", "отурганы жатышатпы")]
    [InlineData("үйрөт", "үйрөткөнү жатышатпы")]
    [InlineData("күй", "күйгөнү жатышатпы")]
    public void FutureGoingTo_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}