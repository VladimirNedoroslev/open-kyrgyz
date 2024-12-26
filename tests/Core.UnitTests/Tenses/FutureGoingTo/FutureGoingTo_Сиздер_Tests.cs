using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.FutureGoingTo;

namespace UnitTests.Tenses.FutureGoingTo;

public class FutureGoingToСиздерTests
{
    [Theory]
    [InlineData("бол", "болгону жатасыздар")]
    [InlineData("иште", "иштегени жатасыздар")]
    [InlineData("бар", "барганы жатасыздар")]
    [InlineData("изилде", "изилдегени жатасыздар")]
    [InlineData("кел", "келгени жатасыздар")]
    [InlineData("ойно", "ойногону жатасыздар")]
    [InlineData("күт", "күткөнү жатасыздар")]
    [InlineData("тап", "тапканы жатасыздар")]
    [InlineData("кир", "киргени жатасыздар")]
    [InlineData("өт", "өткөнү жатасыздар")]
    [InlineData("чакыр", "чакырганы жатасыздар")]
    [InlineData("текшер", "текшергени жатасыздар")]
    [InlineData("отур", "отурганы жатасыздар")]
    [InlineData("үйрөт", "үйрөткөнү жатасыздар")]
    [InlineData("күй", "күйгөнү жатасыздар")]
    public void FutureGoingTo_Сиздер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бол", "болгону жатасыздарбы")]
    [InlineData("иште", "иштегени жатасыздарбы")]
    [InlineData("бар", "барганы жатасыздарбы")]
    [InlineData("изилде", "изилдегени жатасыздарбы")]
    [InlineData("кел", "келгени жатасыздарбы")]
    [InlineData("ойно", "ойногону жатасыздарбы")]
    [InlineData("күт", "күткөнү жатасыздарбы")]
    [InlineData("тап", "тапканы жатасыздарбы")]
    [InlineData("кир", "киргени жатасыздарбы")]
    [InlineData("өт", "өткөнү жатасыздарбы")]
    [InlineData("чакыр", "чакырганы жатасыздарбы")]
    [InlineData("текшер", "текшергени жатасыздарбы")]
    [InlineData("отур", "отурганы жатасыздарбы")]
    [InlineData("үйрөт", "үйрөткөнү жатасыздарбы")]
    [InlineData("күй", "күйгөнү жатасыздарбы")]
    public void FutureGoingTo_Сиздер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}