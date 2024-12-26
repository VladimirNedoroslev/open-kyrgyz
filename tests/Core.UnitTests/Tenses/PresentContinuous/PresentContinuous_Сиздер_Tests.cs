using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PresentContinuous;

namespace UnitTests.Tenses.PresentContinuous;

public class PresentContinuousСиздерTests
{
    [Theory]
    [InlineData("бол", "болуп жатасыздар")]
    [InlineData("иште", "иштеп жатасыздар")]
    [InlineData("бар", "бара жатасыздар")]
    [InlineData("изилде", "изилдеп жатасыздар")]
    [InlineData("кел", "келе жатасыздар")]
    [InlineData("ойно", "ойноп жатасыздар")]
    [InlineData("күт", "күтүп жатасыздар")]
    [InlineData("тап", "таап жатасыздар")]
    [InlineData("кир", "кирип жатасыздар")]
    [InlineData("өт", "өтүп жатасыздар")]
    [InlineData("чакыр", "чакырып жатасыздар")]
    [InlineData("текшер", "текшерип жатасыздар")]
    [InlineData("отур", "отуруп жатасыздар")]
    [InlineData("үйрөт", "үйрөтүп жатасыздар")]
    public void PresentContinuous_Сиздер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатасыздар")]
    [InlineData("иште", "иштебей жатасыздар")]
    [InlineData("бар", "барбай жатасыздар")]
    [InlineData("изилде", "изилдебей жатасыздар")]
    [InlineData("кел", "келбей жатасыздар")]
    [InlineData("ойно", "ойнобой жатасыздар")]
    [InlineData("күт", "күтпөй жатасыздар")]
    // [InlineData("тап", "таап жатасыздар")] 
    [InlineData("кир", "кирбей жатасыздар")]
    [InlineData("өт", "өтпөй жатасыздар")]
    [InlineData("чакыр", "чакырбай жатасыздар")]
    [InlineData("текшер", "текшербей жатасыздар")]
    [InlineData("отур", "отурбай жатасыздар")]
    [InlineData("үйрөт", "үйрөтпөй жатасыздар")]
    public void PresentContinuous_Сиздер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болуп жатасыздарбы")]
    [InlineData("иште", "иштеп жатасыздарбы")]
    [InlineData("бар", "бара жатасыздарбы")]
    [InlineData("изилде", "изилдеп жатасыздарбы")]
    [InlineData("кел", "келе жатасыздарбы")]
    [InlineData("ойно", "ойноп жатасыздарбы")]
    [InlineData("күт", "күтүп жатасыздарбы")]
    [InlineData("тап", "таап жатасыздарбы")]
    [InlineData("кир", "кирип жатасыздарбы")]
    [InlineData("өт", "өтүп жатасыздарбы")]
    [InlineData("чакыр", "чакырып жатасыздарбы")]
    [InlineData("текшер", "текшерип жатасыздарбы")]
    [InlineData("отур", "отуруп жатасыздарбы")]
    [InlineData("үйрөт", "үйрөтүп жатасыздарбы")]
    public void PresentContinuous_Сиздер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатасыздарбы")]
    [InlineData("иште", "иштебей жатасыздарбы")]
    [InlineData("бар", "барбай жатасыздарбы")]
    [InlineData("изилде", "изилдебей жатасыздарбы")]
    [InlineData("кел", "келбей жатасыздарбы")]
    [InlineData("ойно", "ойнобой жатасыздарбы")]
    [InlineData("күт", "күтпөй жатасыздарбы")]
    // [InlineData("тап", "таап жатасыздарбы")] 
    [InlineData("кир", "кирбей жатасыздарбы")]
    [InlineData("өт", "өтпөй жатасыздарбы")]
    [InlineData("чакыр", "чакырбай жатасыздарбы")]
    [InlineData("текшер", "текшербей жатасыздарбы")]
    [InlineData("отур", "отурбай жатасыздарбы")]
    [InlineData("үйрөт", "үйрөтпөй жатасыздарбы")]
    public void PresentContinuous_Сиздер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}