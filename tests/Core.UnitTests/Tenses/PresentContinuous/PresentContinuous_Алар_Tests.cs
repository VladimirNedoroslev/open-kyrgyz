using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PresentContinuous;

namespace UnitTests.Tenses.PresentContinuous;

public class PresentContinuousАларTests
{
    [Theory]
    [InlineData("бол", "болуп жатышат")]
    [InlineData("иште", "иштеп жатышат")]
    [InlineData("бар", "бара жатышат")]
    [InlineData("изилде", "изилдеп жатышат")]
    [InlineData("кел", "келе жатышат")]
    [InlineData("ойно", "ойноп жатышат")]
    [InlineData("күт", "күтүп жатышат")]
    [InlineData("тап", "таап жатышат")]
    [InlineData("кир", "кирип жатышат")]
    [InlineData("өт", "өтүп жатышат")]
    [InlineData("чакыр", "чакырып жатышат")]
    [InlineData("текшер", "текшерип жатышат")]
    [InlineData("отур", "отуруп жатышат")]
    [InlineData("үйрөт", "үйрөтүп жатышат")]
    public void PresentContinuous_Алар_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатышат")]
    [InlineData("иште", "иштебей жатышат")]
    [InlineData("бар", "барбай жатышат")]
    [InlineData("изилде", "изилдебей жатышат")]
    [InlineData("кел", "келбей жатышат")]
    [InlineData("ойно", "ойнобой жатышат")]
    [InlineData("күт", "күтпөй жатышат")]
    // [InlineData("тап", "таап жатышат")] 
    [InlineData("кир", "кирбей жатышат")]
    [InlineData("өт", "өтпөй жатышат")]
    [InlineData("чакыр", "чакырбай жатышат")]
    [InlineData("текшер", "текшербей жатышат")]
    [InlineData("отур", "отурбай жатышат")]
    [InlineData("үйрөт", "үйрөтпөй жатышат")]
    public void PresentContinuous_Алар_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болуп жатышабы")]
    [InlineData("иште", "иштеп жатышабы")]
    [InlineData("бар", "бара жатышабы")]
    [InlineData("изилде", "изилдеп жатышабы")]
    [InlineData("кел", "келе жатышабы")]
    [InlineData("ойно", "ойноп жатышабы")]
    [InlineData("күт", "күтүп жатышабы")]
    [InlineData("тап", "таап жатышабы")]
    [InlineData("кир", "кирип жатышабы")]
    [InlineData("өт", "өтүп жатышабы")]
    [InlineData("чакыр", "чакырып жатышабы")]
    [InlineData("текшер", "текшерип жатышабы")]
    [InlineData("отур", "отуруп жатышабы")]
    [InlineData("үйрөт", "үйрөтүп жатышабы")]
    public void PresentContinuous_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатышабы")]
    [InlineData("иште", "иштебей жатышабы")]
    [InlineData("бар", "барбай жатышабы")]
    [InlineData("изилде", "изилдебей жатышабы")]
    [InlineData("кел", "келбей жатышабы")]
    [InlineData("ойно", "ойнобой жатышабы")]
    [InlineData("күт", "күтпөй жатышабы")]
    // [InlineData("тап", "таап жатышабы")] 
    [InlineData("кир", "кирбей жатышабы")]
    [InlineData("өт", "өтпөй жатышабы")]
    [InlineData("чакыр", "чакырбай жатышабы")]
    [InlineData("текшер", "текшербей жатышабы")]
    [InlineData("отур", "отурбай жатышабы")]
    [InlineData("үйрөт", "үйрөтпөй жатышабы")]
    public void PresentContinuous_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}