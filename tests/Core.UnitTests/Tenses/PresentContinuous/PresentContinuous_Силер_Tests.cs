using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentContinuous;

namespace UnitTests.Tenses.PresentContinuous;

public class PresentContinuousСилерTests
{
    [Theory]
    [InlineData("бол", "болуп жатасыңар")]
    [InlineData("иште", "иштеп жатасыңар")]
    [InlineData("бар", "бара жатасыңар")]
    [InlineData("изилде", "изилдеп жатасыңар")]
    [InlineData("кел", "келе жатасыңар")]
    [InlineData("ойно", "ойноп жатасыңар")]
    [InlineData("күт", "күтүп жатасыңар")]
    [InlineData("тап", "таап жатасыңар")]
    [InlineData("кир", "кирип жатасыңар")]
    [InlineData("өт", "өтүп жатасыңар")]
    [InlineData("чакыр", "чакырып жатасыңар")]
    [InlineData("текшер", "текшерип жатасыңар")]
    [InlineData("отур", "отуруп жатасыңар")]
    [InlineData("үйрөт", "үйрөтүп жатасыңар")]
    public void PresentContinuous_Силер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатасыңар")]
    [InlineData("иште", "иштебей жатасыңар")]
    [InlineData("бар", "барбай жатасыңар")]
    [InlineData("изилде", "изилдебей жатасыңар")]
    [InlineData("кел", "келбей жатасыңар")]
    [InlineData("ойно", "ойнобой жатасыңар")]
    [InlineData("күт", "күтпөй жатасыңар")]
    // [InlineData("тап", "таап жатасыңар")] 
    [InlineData("кир", "кирбей жатасыңар")]
    [InlineData("өт", "өтпөй жатасыңар")]
    [InlineData("чакыр", "чакырбай жатасыңар")]
    [InlineData("текшер", "текшербей жатасыңар")]
    [InlineData("отур", "отурбай жатасыңар")]
    [InlineData("үйрөт", "үйрөтпөй жатасыңар")]
    public void PresentContinuous_Силер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болуп жатасыңарбы")]
    [InlineData("иште", "иштеп жатасыңарбы")]
    [InlineData("бар", "бара жатасыңарбы")]
    [InlineData("изилде", "изилдеп жатасыңарбы")]
    [InlineData("кел", "келе жатасыңарбы")]
    [InlineData("ойно", "ойноп жатасыңарбы")]
    [InlineData("күт", "күтүп жатасыңарбы")]
    [InlineData("тап", "таап жатасыңарбы")]
    [InlineData("кир", "кирип жатасыңарбы")]
    [InlineData("өт", "өтүп жатасыңарбы")]
    [InlineData("чакыр", "чакырып жатасыңарбы")]
    [InlineData("текшер", "текшерип жатасыңарбы")]
    [InlineData("отур", "отуруп жатасыңарбы")]
    [InlineData("үйрөт", "үйрөтүп жатасыңарбы")]
    public void PresentContinuous_Силер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатасыңарбы")]
    [InlineData("иште", "иштебей жатасыңарбы")]
    [InlineData("бар", "барбай жатасыңарбы")]
    [InlineData("изилде", "изилдебей жатасыңарбы")]
    [InlineData("кел", "келбей жатасыңарбы")]
    [InlineData("ойно", "ойнобой жатасыңарбы")]
    [InlineData("күт", "күтпөй жатасыңарбы")]
    // [InlineData("тап", "таап жатасыңарбы")] 
    [InlineData("кир", "кирбей жатасыңарбы")]
    [InlineData("өт", "өтпөй жатасыңарбы")]
    [InlineData("чакыр", "чакырбай жатасыңарбы")]
    [InlineData("текшер", "текшербей жатасыңарбы")]
    [InlineData("отур", "отурбай жатасыңарбы")]
    [InlineData("үйрөт", "үйрөтпөй жатасыңарбы")]
    public void PresentContinuous_Силер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}