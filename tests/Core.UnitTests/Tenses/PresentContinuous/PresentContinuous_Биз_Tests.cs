using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentContinuous;

namespace UnitTests.PresentContinuous;

public class PresentContinuousБизTests
{
    [Theory]
    [InlineData("бол", "болуп жатабыз")]
    [InlineData("иште", "иштеп жатабыз")]
    [InlineData("бар", "бара жатабыз")]
    [InlineData("изилде", "изилдеп жатабыз")]
    [InlineData("кел", "келе жатабыз")]
    [InlineData("ойно", "ойноп жатабыз")]
    [InlineData("күт", "күтүп жатабыз")]
    [InlineData("тап", "таап жатабыз")]
    [InlineData("кир", "кирип жатабыз")]
    [InlineData("өт", "өтүп жатабыз")]
    [InlineData("чакыр", "чакырып жатабыз")]
    [InlineData("текшер", "текшерип жатабыз")]
    [InlineData("отур", "отуруп жатабыз")]
    [InlineData("үйрөт", "үйрөтүп жатабыз")]
    public void PresentContinuous_Биз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатабыз")]
    [InlineData("иште", "иштебей жатабыз")]
    [InlineData("бар", "барбай жатабыз")]
    [InlineData("изилде", "изилдебей жатабыз")]
    [InlineData("кел", "келбей жатабыз")]
    [InlineData("ойно", "ойнобой жатабыз")]
    [InlineData("күт", "күтпөй жатабыз")]
    // [InlineData("тап", "таап жатабыз")] 
    [InlineData("кир", "кирбей жатабыз")]
    [InlineData("өт", "өтпөй жатабыз")]
    [InlineData("чакыр", "чакырбай жатабыз")]
    [InlineData("текшер", "текшербей жатабыз")]
    [InlineData("отур", "отурбай жатабыз")]
    [InlineData("үйрөт", "үйрөтпөй жатабыз")]
    public void PresentContinuous_Биз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болуп жатабызбы")]
    [InlineData("иште", "иштеп жатабызбы")]
    [InlineData("бар", "бара жатабызбы")]
    [InlineData("изилде", "изилдеп жатабызбы")]
    [InlineData("кел", "келе жатабызбы")]
    [InlineData("ойно", "ойноп жатабызбы")]
    [InlineData("күт", "күтүп жатабызбы")]
    [InlineData("тап", "таап жатабызбы")]
    [InlineData("кир", "кирип жатабызбы")]
    [InlineData("өт", "өтүп жатабызбы")]
    [InlineData("чакыр", "чакырып жатабызбы")]
    [InlineData("текшер", "текшерип жатабызбы")]
    [InlineData("отур", "отуруп жатабызбы")]
    [InlineData("үйрөт", "үйрөтүп жатабызбы")]
    public void PresentContinuous_Биз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатабызбы")]
    [InlineData("иште", "иштебей жатабызбы")]
    [InlineData("бар", "барбай жатабызбы")]
    [InlineData("изилде", "изилдебей жатабызбы")]
    [InlineData("кел", "келбей жатабызбы")]
    [InlineData("ойно", "ойнобой жатабызбы")]
    [InlineData("күт", "күтпөй жатабызбы")]
    // [InlineData("тап", "таап жатабызбы")] 
    [InlineData("кир", "кирбей жатабызбы")]
    [InlineData("өт", "өтпөй жатабызбы")]
    [InlineData("чакыр", "чакырбай жатабызбы")]
    [InlineData("текшер", "текшербей жатабызбы")]
    [InlineData("отур", "отурбай жатабызбы")]
    [InlineData("үйрөт", "үйрөтпөй жатабызбы")]
    public void PresentContinuous_Биз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}