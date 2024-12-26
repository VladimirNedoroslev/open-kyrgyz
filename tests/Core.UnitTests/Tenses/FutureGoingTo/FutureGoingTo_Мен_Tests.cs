using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.FutureGoingTo;

namespace UnitTests.Tenses.FutureGoingTo;

public class FutureGoingToМенTests
{
    [Theory]
    [InlineData("бол", "болгону жатамын")]
    [InlineData("иште", "иштегени жатамын")]
    [InlineData("бар", "барганы жатамын")]
    [InlineData("изилде", "изилдегени жатамын")]
    [InlineData("кел", "келгени жатамын")]
    [InlineData("ойно", "ойногону жатамын")]
    [InlineData("күт", "күткөнү жатамын")]
    [InlineData("тап", "тапканы жатамын")]
    [InlineData("кир", "киргени жатамын")]
    [InlineData("өт", "өткөнү жатамын")]
    [InlineData("чакыр", "чакырганы жатамын")]
    [InlineData("текшер", "текшергени жатамын")]
    [InlineData("отур", "отурганы жатамын")]
    [InlineData("үйрөт", "үйрөткөнү жатамын")]
    [InlineData("күй", "күйгөнү жатамын")]
    public void FutureGoingTo_Мен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бол", "болгону жатамынбы")]
    [InlineData("иште", "иштегени жатамынбы")]
    [InlineData("бар", "барганы жатамынбы")]
    [InlineData("изилде", "изилдегени жатамынбы")]
    [InlineData("кел", "келгени жатамынбы")]
    [InlineData("ойно", "ойногону жатамынбы")]
    [InlineData("күт", "күткөнү жатамынбы")]
    [InlineData("тап", "тапканы жатамынбы")]
    [InlineData("кир", "киргени жатамынбы")]
    [InlineData("өт", "өткөнү жатамынбы")]
    [InlineData("чакыр", "чакырганы жатамынбы")]
    [InlineData("текшер", "текшергени жатамынбы")]
    [InlineData("отур", "отурганы жатамынбы")]
    [InlineData("үйрөт", "үйрөткөнү жатамынбы")]
    [InlineData("күй", "күйгөнү жатамынбы")]
    public void FutureGoingTo_Мен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}