using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentContinuous;

namespace UnitTests.PresentContinuous;

public class PresentContinuousСизTests
{
    [Theory]
    [InlineData("бол", "болуп жатасыз")]
    [InlineData("иште", "иштеп жатасыз")]
    [InlineData("бар", "бара жатасыз")]
    [InlineData("изилде", "изилдеп жатасыз")]
    [InlineData("кел", "келе жатасыз")]
    [InlineData("ойно", "ойноп жатасыз")]
    [InlineData("күт", "күтүп жатасыз")]
    [InlineData("тап", "таап жатасыз")]
    [InlineData("кир", "кирип жатасыз")]
    [InlineData("өт", "өтүп жатасыз")]
    [InlineData("чакыр", "чакырып жатасыз")]
    [InlineData("текшер", "текшерип жатасыз")]
    [InlineData("отур", "отуруп жатасыз")]
    [InlineData("үйрөт", "үйрөтүп жатасыз")]
    public void PresentContinuous_Сиз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    [Theory]
    [InlineData("бол", "болбой жатасыз")]
    [InlineData("иште", "иштебей жатасыз")]
    [InlineData("бар", "барбай жатасыз")]
    [InlineData("изилде", "изилдебей жатасыз")]
    [InlineData("кел", "келбей жатасыз")]
    [InlineData("ойно", "ойнобой жатасыз")]
    [InlineData("күт", "күтпөй жатасыз")]
    // [InlineData("тап", "таап жатасыз")] 
    [InlineData("кир", "кирбей жатасыз")]
    [InlineData("өт", "өтпөй жатасыз")]
    [InlineData("чакыр", "чакырбай жатасыз")]
    [InlineData("текшер", "текшербей жатасыз")]
    [InlineData("отур", "отурбай жатасыз")]
    [InlineData("үйрөт", "үйрөтпөй жатасыз")]
    public void PresentContinuous_Сиз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болуп жатасызбы")]
    [InlineData("иште", "иштеп жатасызбы")]
    [InlineData("бар", "бара жатасызбы")]
    [InlineData("изилде", "изилдеп жатасызбы")]
    [InlineData("кел", "келе жатасызбы")]
    [InlineData("ойно", "ойноп жатасызбы")]
    [InlineData("күт", "күтүп жатасызбы")]
    [InlineData("тап", "таап жатасызбы")]
    [InlineData("кир", "кирип жатасызбы")]
    [InlineData("өт", "өтүп жатасызбы")]
    [InlineData("чакыр", "чакырып жатасызбы")]
    [InlineData("текшер", "текшерип жатасызбы")]
    [InlineData("отур", "отуруп жатасызбы")]
    [InlineData("үйрөт", "үйрөтүп жатасызбы")]
    public void PresentContinuous_Сиз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбой жатасызбы")]
    [InlineData("иште", "иштебей жатасызбы")]
    [InlineData("бар", "барбай жатасызбы")]
    [InlineData("изилде", "изилдебей жатасызбы")]
    [InlineData("кел", "келбей жатасызбы")]
    [InlineData("ойно", "ойнобой жатасызбы")]
    [InlineData("күт", "күтпөй жатасызбы")]
    // [InlineData("тап", "таап жатасызбы")] 
    [InlineData("кир", "кирбей жатасызбы")]
    [InlineData("өт", "өтпөй жатасызбы")]
    [InlineData("чакыр", "чакырбай жатасызбы")]
    [InlineData("текшер", "текшербей жатасызбы")]
    [InlineData("отур", "отурбай жатасызбы")]
    [InlineData("үйрөт", "үйрөтпөй жатасызбы")]
    public void PresentContinuous_Сиз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentContinuousConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}