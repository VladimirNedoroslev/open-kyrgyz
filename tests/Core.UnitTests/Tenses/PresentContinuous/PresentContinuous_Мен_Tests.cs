using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentContinuous;

namespace UnitTests.PresentContinuous;

public class PresentContinuousМенTests
{
    [Theory]
    [InlineData("бол", "болуп жатамын")]
    [InlineData("иште", "иштеп жатамын")]
    [InlineData("бар", "бара жатамын")]
    [InlineData("изилде", "изилдеп жатамын")]
    [InlineData("кел", "келе жатамын")]
    [InlineData("ойно", "ойноп жатамын")]
    [InlineData("күт", "күтүп жатамын")]
    [InlineData("тап", "таап жатамын")]
    [InlineData("кир", "кирип жатамын")]
    [InlineData("өт", "өтүп жатамын")]
    [InlineData("чакыр", "чакырып жатамын")]
    [InlineData("текшер", "текшерип жатамын")]
    [InlineData("отур", "отуруп жатамын")]
    [InlineData("үйрөт", "үйрөтүп жатамын")]
    public void PresentContinuous_Мен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатамын")]
    [InlineData("иште", "иштебей жатамын")]
    [InlineData("бар", "барбай жатамын")]
    [InlineData("изилде", "изилдебей жатамын")]
    [InlineData("кел", "келбей жатамын")]
    [InlineData("ойно", "ойнобой жатамын")]
    [InlineData("күт", "күтпөй жатамын")]
    // [InlineData("тап", "таап жатамын")] 
    [InlineData("кир", "кирбей жатамын")]
    [InlineData("өт", "өтпөй жатамын")]
    [InlineData("чакыр", "чакырбай жатамын")]
    [InlineData("текшер", "текшербей жатамын")]
    [InlineData("отур", "отурбай жатамын")]
    [InlineData("үйрөт", "үйрөтпөй жатамын")]
    public void PresentContinuous_Мен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болуп жатамынбы")]
    [InlineData("иште", "иштеп жатамынбы")]
    [InlineData("бар", "бара жатамынбы")]
    [InlineData("изилде", "изилдеп жатамынбы")]
    [InlineData("кел", "келе жатамынбы")]
    [InlineData("ойно", "ойноп жатамынбы")]
    [InlineData("күт", "күтүп жатамынбы")]
    [InlineData("тап", "таап жатамынбы")]
    [InlineData("кир", "кирип жатамынбы")]
    [InlineData("өт", "өтүп жатамынбы")]
    [InlineData("чакыр", "чакырып жатамынбы")]
    [InlineData("текшер", "текшерип жатамынбы")]
    [InlineData("отур", "отуруп жатамынбы")]
    [InlineData("үйрөт", "үйрөтүп жатамынбы")]
    public void PresentContinuous_Мен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатамынбы")]
    [InlineData("иште", "иштебей жатамынбы")]
    [InlineData("бар", "барбай жатамынбы")]
    [InlineData("изилде", "изилдебей жатамынбы")]
    [InlineData("кел", "келбей жатамынбы")]
    [InlineData("ойно", "ойнобой жатамынбы")]
    [InlineData("күт", "күтпөй жатамынбы")]
    // [InlineData("тап", "таап жатамынбы")] 
    [InlineData("кир", "кирбей жатамынбы")]
    [InlineData("өт", "өтпөй жатамынбы")]
    [InlineData("чакыр", "чакырбай жатамынбы")]
    [InlineData("текшер", "текшербей жатамынбы")]
    [InlineData("отур", "отурбай жатамынбы")]
    [InlineData("үйрөт", "үйрөтпөй жатамынбы")]
    public void PresentContinuous_Мен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}