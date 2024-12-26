using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.FutureGoingTo;

namespace UnitTests.Tenses.FutureGoingTo;

public class PresentContinuousСилерTests
{
    [Theory]
    [InlineData("бол", "болгону жатасыңар")]
    [InlineData("иште", "иштегени жатасыңар")]
    [InlineData("бар", "барганы жатасыңар")]
    [InlineData("изилде", "изилдегени жатасыңар")]
    [InlineData("кел", "келгени жатасыңар")]
    [InlineData("ойно", "ойногону жатасыңар")]
    [InlineData("күт", "күткөнү жатасыңар")]
    [InlineData("тап", "тапканы жатасыңар")]
    [InlineData("кир", "киргени жатасыңар")]
    [InlineData("өт", "өткөнү жатасыңар")]
    [InlineData("чакыр", "чакырганы жатасыңар")]
    [InlineData("текшер", "текшергени жатасыңар")]
    [InlineData("отур", "отурганы жатасыңар")]
    [InlineData("үйрөт", "үйрөткөнү жатасыңар")]
    [InlineData("күй", "күйгөнү жатасыңар")]
    public void FutureGoingTo_Силер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болгону жатасыңарбы")]
    [InlineData("иште", "иштегени жатасыңарбы")]
    [InlineData("бар", "барганы жатасыңарбы")]
    [InlineData("изилде", "изилдегени жатасыңарбы")]
    [InlineData("кел", "келгени жатасыңарбы")]
    [InlineData("ойно", "ойногону жатасыңарбы")]
    [InlineData("күт", "күткөнү жатасыңарбы")]
    [InlineData("тап", "тапканы жатасыңарбы")]
    [InlineData("кир", "киргени жатасыңарбы")]
    [InlineData("өт", "өткөнү жатасыңарбы")]
    [InlineData("чакыр", "чакырганы жатасыңарбы")]
    [InlineData("текшер", "текшергени жатасыңарбы")]
    [InlineData("отур", "отурганы жатасыңарбы")]
    [InlineData("үйрөт", "үйрөткөнү жатасыңарбы")]
    [InlineData("күй", "күйгөнү жатасыңарбы")]
    public void FutureGoingTo_Силер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}