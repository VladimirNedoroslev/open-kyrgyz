using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.FutureGoingTo;

namespace UnitTests.Tenses.FutureGoingTo;

public class FutureGoingToБизTests
{
    [Theory]
    [InlineData("бол", "болгону жатабыз")]
    [InlineData("иште", "иштегени жатабыз")]
    [InlineData("бар", "барганы жатабыз")]
    [InlineData("изилде", "изилдегени жатабыз")]
    [InlineData("кел", "келгени жатабыз")]
    [InlineData("ойно", "ойногону жатабыз")]
    [InlineData("күт", "күткөнү жатабыз")]
    [InlineData("тап", "тапканы жатабыз")]
    [InlineData("кир", "киргени жатабыз")]
    [InlineData("өт", "өткөнү жатабыз")]
    [InlineData("чакыр", "чакырганы жатабыз")]
    [InlineData("текшер", "текшергени жатабыз")]
    [InlineData("отур", "отурганы жатабыз")]
    [InlineData("үйрөт", "үйрөткөнү жатабыз")]
    [InlineData("күй", "күйгөнү жатабыз")]
    public void FutureGoingTo_Биз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бол", "болгону жатабызбы")]
    [InlineData("иште", "иштегени жатабызбы")]
    [InlineData("бар", "барганы жатабызбы")]
    [InlineData("изилде", "изилдегени жатабызбы")]
    [InlineData("кел", "келгени жатабызбы")]
    [InlineData("ойно", "ойногону жатабызбы")]
    [InlineData("күт", "күткөнү жатабызбы")]
    [InlineData("тап", "тапканы жатабызбы")]
    [InlineData("кир", "киргени жатабызбы")]
    [InlineData("өт", "өткөнү жатабызбы")]
    [InlineData("чакыр", "чакырганы жатабызбы")]
    [InlineData("текшер", "текшергени жатабызбы")]
    [InlineData("отур", "отурганы жатабызбы")]
    [InlineData("үйрөт", "үйрөткөнү жатабызбы")]
    [InlineData("күй", "күйгөнү жатабызбы")]
    public void FutureGoingTo_Биз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}