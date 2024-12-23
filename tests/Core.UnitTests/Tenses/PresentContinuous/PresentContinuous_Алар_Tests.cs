using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentContinuous;

namespace UnitTests.PresentContinuous;

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
    [InlineData("бол", "болуп жатышатпы")]
    [InlineData("иште", "иштеп жатышатпы")]
    [InlineData("бар", "бара жатышатпы")]
    [InlineData("изилде", "изилдеп жатышатпы")]
    [InlineData("кел", "келе жатышатпы")]
    [InlineData("ойно", "ойноп жатышатпы")]
    [InlineData("күт", "күтүп жатышатпы")]
    [InlineData("тап", "таап жатышатпы")]
    [InlineData("кир", "кирип жатышатпы")]
    [InlineData("өт", "өтүп жатышатпы")]
    [InlineData("чакыр", "чакырып жатышатпы")]
    [InlineData("текшер", "текшерип жатышатпы")]
    [InlineData("отур", "отуруп жатышатпы")]
    [InlineData("үйрөт", "үйрөтүп жатышатпы")]
    public void PresentContinuous_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатышатпы")]
    [InlineData("иште", "иштебей жатышатпы")]
    [InlineData("бар", "барбай жатышатпы")]
    [InlineData("изилде", "изилдебей жатышатпы")]
    [InlineData("кел", "келбей жатышатпы")]
    [InlineData("ойно", "ойнобой жатышатпы")]
    [InlineData("күт", "күтпөй жатышатпы")]
    // [InlineData("тап", "таап жатышатпы")] 
    [InlineData("кир", "кирбей жатышатпы")]
    [InlineData("өт", "өтпөй жатышатпы")]
    [InlineData("чакыр", "чакырбай жатышатпы")]
    [InlineData("текшер", "текшербей жатышатпы")]
    [InlineData("отур", "отурбай жатышатпы")]
    [InlineData("үйрөт", "үйрөтпөй жатышатпы")]
    public void PresentContinuous_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}