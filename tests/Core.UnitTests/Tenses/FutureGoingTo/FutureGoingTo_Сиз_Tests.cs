using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.FutureGoingTo;

namespace UnitTests.Tenses.FutureGoingTo;

public class FutureGoingToСизTests
{
    [Theory]
    [InlineData("бол", "болгону жатасыз")]
    [InlineData("иште", "иштегени жатасыз")]
    [InlineData("бар", "барганы жатасыз")]
    [InlineData("изилде", "изилдегени жатасыз")]
    [InlineData("кел", "келгени жатасыз")]
    [InlineData("ойно", "ойногону жатасыз")]
    [InlineData("күт", "күткөнү жатасыз")]
    [InlineData("тап", "тапканы жатасыз")]
    [InlineData("кир", "киргени жатасыз")]
    [InlineData("өт", "өткөнү жатасыз")]
    [InlineData("чакыр", "чакырганы жатасыз")]
    [InlineData("текшер", "текшергени жатасыз")]
    [InlineData("отур", "отурганы жатасыз")]
    [InlineData("үйрөт", "үйрөткөнү жатасыз")]
    [InlineData("күй", "күйгөнү жатасыз")]
    public void FutureGoingTo_Сиз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бол", "болгону жатасызбы")]
    [InlineData("иште", "иштегени жатасызбы")]
    [InlineData("бар", "барганы жатасызбы")]
    [InlineData("изилде", "изилдегени жатасызбы")]
    [InlineData("кел", "келгени жатасызбы")]
    [InlineData("ойно", "ойногону жатасызбы")]
    [InlineData("күт", "күткөнү жатасызбы")]
    [InlineData("тап", "тапканы жатасызбы")]
    [InlineData("кир", "киргени жатасызбы")]
    [InlineData("өт", "өткөнү жатасызбы")]
    [InlineData("чакыр", "чакырганы жатасызбы")]
    [InlineData("текшер", "текшергени жатасызбы")]
    [InlineData("отур", "отурганы жатасызбы")]
    [InlineData("үйрөт", "үйрөткөнү жатасызбы")]
    [InlineData("күй", "күйгөнү жатасызбы")]
    public void FutureGoingTo_Сиз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}