using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

namespace UnitTests.PresentAndFuture;

public class PresentAndFutureБизTests
{
    [Theory]
    [InlineData("бол", "болобуз")]
    [InlineData("иште", "иштейбиз")]
    [InlineData("бар", "барабыз")]
    [InlineData("изилде", "изилдейбиз")]
    [InlineData("кел", "келебиз")]
    [InlineData("ойно", "ойнойбуз")]
    [InlineData("күт", "күтөбүз")]
    [InlineData("тап", "табабыз")]
    [InlineData("кир", "киребиз")]
    [InlineData("өт", "өтөбүз")]
    [InlineData("чакыр", "чакырабыз")]
    [InlineData("текшер", "текшеребиз")]
    [InlineData("отур", "отурабыз")]
    [InlineData("үйрөт", "үйрөтөбүз")]
    [InlineData("кой", "коёбуз")]
    public void PresentAndFuture_Биз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбойбуз")]
    [InlineData("иште", "иштебейбиз")]
    [InlineData("бар", "барбайбыз")]
    [InlineData("изилде", "изилдебейбиз")]
    [InlineData("кел", "келбейбиз")]
    [InlineData("ойно", "ойнобойбуз")]
    [InlineData("күт", "күтпөйбүз")]
    [InlineData("тап", "таппайбыз")]
    [InlineData("кир", "кирбейбиз")]
    [InlineData("өт", "өтпөйбүз")]
    [InlineData("чакыр", "чакырбайбыз")]
    [InlineData("текшер", "текшербейбиз")]
    [InlineData("отур", "отурбайбыз")]
    [InlineData("үйрөт", "үйрөтпөйбүз")]
    [InlineData("кой", "койбойбуз")]
    public void PresentAndFuture_Биз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болобузбу")]
    [InlineData("иште", "иштейбизби")]
    [InlineData("бар", "барабызбы")]
    [InlineData("изилде", "изилдейбизби")]
    [InlineData("кел", "келебизби")]
    [InlineData("ойно", "ойнойбузбу")]
    [InlineData("күт", "күтөбүзбү")]
    [InlineData("тап", "табабызбы")]
    [InlineData("кир", "киребизби")]
    [InlineData("өт", "өтөбүзбү")]
    [InlineData("чакыр", "чакырабызбы")]
    [InlineData("текшер", "текшеребизби")]
    [InlineData("отур", "отурабызбы")]
    [InlineData("үйрөт", "үйрөтөбүзбү")]
    [InlineData("кой", "коёбузбу")]
    public void PresentAndFuture_Биз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбойбузбу")]
    [InlineData("иште", "иштебейбизби")]
    [InlineData("бар", "барбайбызбы")]
    [InlineData("изилде", "изилдебейбизби")]
    [InlineData("кел", "келбейбизби")]
    [InlineData("ойно", "ойнобойбузбу")]
    [InlineData("күт", "күтпөйбүзбү")]
    [InlineData("тап", "таппайбызбы")]
    [InlineData("кир", "кирбейбизби")]
    [InlineData("өт", "өтпөйбүзбү")]
    [InlineData("чакыр", "чакырбайбызбы")]
    [InlineData("текшер", "текшербейбизби")]
    [InlineData("отур", "отурбайбызбы")]
    [InlineData("үйрөт", "үйрөтпөйбүзбү")]
    [InlineData("кой", "койбойбузбу")]
    public void PresentAndFuture_Биз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}