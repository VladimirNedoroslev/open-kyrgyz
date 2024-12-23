using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentContinuous;

namespace UnitTests.PresentContinuous;

public class PresentContinuousСенTests
{
    [Theory]
    [InlineData("бол", "болуп жатасың")]
    [InlineData("иште", "иштеп жатасың")]
    [InlineData("бар", "бара жатасың")]
    [InlineData("изилде", "изилдеп жатасың")]
    [InlineData("кел", "келе жатасың")]
    [InlineData("ойно", "ойноп жатасың")]
    [InlineData("күт", "күтүп жатасың")]
    [InlineData("тап", "таап жатасың")]
    [InlineData("кир", "кирип жатасың")]
    [InlineData("өт", "өтүп жатасың")]
    [InlineData("чакыр", "чакырып жатасың")]
    [InlineData("текшер", "текшерип жатасың")]
    [InlineData("отур", "отуруп жатасың")]
    [InlineData("үйрөт", "үйрөтүп жатасың")]
    public void PresentContinuous_Сен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    [Theory]
    [InlineData("бол", "болбой жатасың")]
    [InlineData("иште", "иштебей жатасың")]
    [InlineData("бар", "барбай жатасың")]
    [InlineData("изилде", "изилдебей жатасың")]
    [InlineData("кел", "келбей жатасың")]
    [InlineData("ойно", "ойнобой жатасың")]
    [InlineData("күт", "күтпөй жатасың")]
    // [InlineData("тап", "таап жатасың")] 
    [InlineData("кир", "кирбей жатасың")]
    [InlineData("өт", "өтпөй жатасың")]
    [InlineData("чакыр", "чакырбай жатасың")]
    [InlineData("текшер", "текшербей жатасың")]
    [InlineData("отур", "отурбай жатасың")]
    [InlineData("үйрөт", "үйрөтпөй жатасың")]
    public void PresentContinuous_Сен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болуп жатасыңбы")]
    [InlineData("иште", "иштеп жатасыңбы")]
    [InlineData("бар", "бара жатасыңбы")]
    [InlineData("изилде", "изилдеп жатасыңбы")]
    [InlineData("кел", "келе жатасыңбы")]
    [InlineData("ойно", "ойноп жатасыңбы")]
    [InlineData("күт", "күтүп жатасыңбы")]
    [InlineData("тап", "таап жатасыңбы")]
    [InlineData("кир", "кирип жатасыңбы")]
    [InlineData("өт", "өтүп жатасыңбы")]
    [InlineData("чакыр", "чакырып жатасыңбы")]
    [InlineData("текшер", "текшерип жатасыңбы")]
    [InlineData("отур", "отуруп жатасыңбы")]
    [InlineData("үйрөт", "үйрөтүп жатасыңбы")]
    public void PresentContinuous_Сен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатасыңбы")]
    [InlineData("иште", "иштебей жатасыңбы")]
    [InlineData("бар", "барбай жатасыңбы")]
    [InlineData("изилде", "изилдебей жатасыңбы")]
    [InlineData("кел", "келбей жатасыңбы")]
    [InlineData("ойно", "ойнобой жатасыңбы")]
    [InlineData("күт", "күтпөй жатасыңбы")]
    // [InlineData("тап", "таап жатасыңбы")] 
    [InlineData("кир", "кирбей жатасыңбы")]
    [InlineData("өт", "өтпөй жатасыңбы")]
    [InlineData("чакыр", "чакырбай жатасыңбы")]
    [InlineData("текшер", "текшербей жатасыңбы")]
    [InlineData("отур", "отурбай жатасыңбы")]
    [InlineData("үйрөт", "үйрөтпөй жатасыңбы")]
    public void PresentContinuous_Сен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}