using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.FutureGoingTo;

namespace UnitTests.FutureGoingTo;

public class FutureGoingToСенTests
{
    [Theory]
    [InlineData("бол", "болгону жатасың")]
    [InlineData("иште", "иштегени жатасың")]
    [InlineData("бар", "барганы жатасың")]
    [InlineData("изилде", "изилдегени жатасың")]
    [InlineData("кел", "келгени жатасың")]
    [InlineData("ойно", "ойногону жатасың")]
    [InlineData("күт", "күткөнү жатасың")]
    [InlineData("тап", "тапканы жатасың")]
    [InlineData("кир", "киргени жатасың")]
    [InlineData("өт", "өткөнү жатасың")]
    [InlineData("чакыр", "чакырганы жатасың")]
    [InlineData("текшер", "текшергени жатасың")]
    [InlineData("отур", "отурганы жатасың")]
    [InlineData("үйрөт", "үйрөткөнү жатасың")]
    [InlineData("күй", "күйгөнү жатасың")]
    public void FutureGoingTo_Сен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
  
    [Theory]
    [InlineData("бол", "болгону жатасыңбы")]
    [InlineData("иште", "иштегени жатасыңбы")]
    [InlineData("бар", "барганы жатасыңбы")]
    [InlineData("изилде", "изилдегени жатасыңбы")]
    [InlineData("кел", "келгени жатасыңбы")]
    [InlineData("ойно", "ойногону жатасыңбы")]
    [InlineData("күт", "күткөнү жатасыңбы")]
    [InlineData("тап", "тапканы жатасыңбы")]
    [InlineData("кир", "киргени жатасыңбы")]
    [InlineData("өт", "өткөнү жатасыңбы")]
    [InlineData("чакыр", "чакырганы жатасыңбы")]
    [InlineData("текшер", "текшергени жатасыңбы")]
    [InlineData("отур", "отурганы жатасыңбы")]
    [InlineData("үйрөт", "үйрөткөнү жатасыңбы")]
    [InlineData("күй", "күйгөнү жатасыңбы")]
    public void FutureGoingTo_Сен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureGoingToConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
}