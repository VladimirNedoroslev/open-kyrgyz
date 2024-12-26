using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PresentContinuous;

namespace UnitTests.Tenses.PresentContinuous;

public class PresentContinuousАлTests
{
    [Theory]
    [InlineData("бол", "болуп жатат")]
    [InlineData("иште", "иштеп жатат")]
    [InlineData("бар", "бара жатат")]
    [InlineData("изилде", "изилдеп жатат")]
    [InlineData("кел", "келе жатат")]
    [InlineData("ойно", "ойноп жатат")]
    [InlineData("күт", "күтүп жатат")]
    [InlineData("тап", "таап жатат")]
    [InlineData("кир", "кирип жатат")]
    [InlineData("өт", "өтүп жатат")]
    [InlineData("чакыр", "чакырып жатат")]
    [InlineData("текшер", "текшерип жатат")]
    [InlineData("отур", "отуруп жатат")]
    [InlineData("үйрөт", "үйрөтүп жатат")]
    public void PresentContinuous_Ал_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатат")]
    [InlineData("иште", "иштебей жатат")]
    [InlineData("бар", "барбай жатат")]
    [InlineData("изилде", "изилдебей жатат")]
    [InlineData("кел", "келбей жатат")]
    [InlineData("ойно", "ойнобой жатат")]
    [InlineData("күт", "күтпөй жатат")]
    // [InlineData("тап", "таап жатат")] 
    [InlineData("кир", "кирбей жатат")]
    [InlineData("өт", "өтпөй жатат")]
    [InlineData("чакыр", "чакырбай жатат")]
    [InlineData("текшер", "текшербей жатат")]
    [InlineData("отур", "отурбай жатат")]
    [InlineData("үйрөт", "үйрөтпөй жатат")]
    public void PresentContinuous_Ал_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болуп жатабы")]
    [InlineData("иште", "иштеп жатабы")]
    [InlineData("бар", "бара жатабы")]
    [InlineData("изилде", "изилдеп жатабы")]
    [InlineData("кел", "келе жатабы")]
    [InlineData("ойно", "ойноп жатабы")]
    [InlineData("күт", "күтүп жатабы")]
    [InlineData("тап", "таап жатабы")]
    [InlineData("кир", "кирип жатабы")]
    [InlineData("өт", "өтүп жатабы")]
    [InlineData("чакыр", "чакырып жатабы")]
    [InlineData("текшер", "текшерип жатабы")]
    [InlineData("отур", "отуруп жатабы")]
    [InlineData("үйрөт", "үйрөтүп жатабы")]
    public void PresentContinuous_Ал_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатабы")]
    [InlineData("иште", "иштебей жатабы")]
    [InlineData("бар", "барбай жатабы")]
    [InlineData("изилде", "изилдебей жатабы")]
    [InlineData("кел", "келбей жатабы")]
    [InlineData("ойно", "ойнобой жатабы")]
    [InlineData("күт", "күтпөй жатабы")]
    // [InlineData("тап", "таап жатабы")] 
    [InlineData("кир", "кирбей жатабы")]
    [InlineData("өт", "өтпөй жатабы")]
    [InlineData("чакыр", "чакырбай жатабы")]
    [InlineData("текшер", "текшербей жатабы")]
    [InlineData("отур", "отурбай жатабы")]
    [InlineData("үйрөт", "үйрөтпөй жатабы")]
    public void PresentContinuous_Ал_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}