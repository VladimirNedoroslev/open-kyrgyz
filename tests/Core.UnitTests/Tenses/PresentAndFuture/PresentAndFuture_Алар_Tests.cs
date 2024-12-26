using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PresentAndFutureSimple;

namespace UnitTests.Tenses.PresentAndFuture;

public class PresentAndFutureАларTests
{
    [Theory]
    [InlineData("бол", "болушат")]
    [InlineData("иште", "иштешет")]
    [InlineData("бар", "барышат")]
    [InlineData("изилде", "изилдешет")]
    [InlineData("кел", "келишет")]
    [InlineData("ойно", "ойношот")]
    [InlineData("күт", "күтүшөт")]
    [InlineData("тап", "табышат")]
    [InlineData("кир", "киришет")]
    [InlineData("өт", "өтүшөт")]
    [InlineData("чакыр", "чакырышат")]
    [InlineData("текшер", "текшеришет")]
    [InlineData("отур", "отурушат")]
    [InlineData("үйрөт", "үйрөтүшөт")]
    [InlineData("кой", "коюшат")]
    public void PresentAndFuture_Алар_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болушпайт")]
    [InlineData("иште", "иштешпейт")]
    [InlineData("бар", "барышпайт")]
    [InlineData("изилде", "изилдешпейт")]
    [InlineData("кел", "келишпейт")]
    [InlineData("ойно", "ойношпойт")]
    [InlineData("күт", "күтүшпөйт")]
    [InlineData("тап", "табышпайт")]
    [InlineData("кир", "киришпейт")]
    [InlineData("өт", "өтүшпөйт")]
    [InlineData("чакыр", "чакырышпайт")]
    [InlineData("текшер", "текшеришпейт")]
    [InlineData("отур", "отурушпайт")]
    [InlineData("үйрөт", "үйрөтүшпөйт")]
    [InlineData("кой", "коюшпайт")]
    public void PresentAndFuture_Алар_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болушабы")]
    [InlineData("иште", "иштешеби")]
    [InlineData("бар", "барышабы")]
    [InlineData("изилде", "изилдешеби")]
    [InlineData("кел", "келишеби")]
    [InlineData("ойно", "ойношобу")]
    [InlineData("күт", "күтүшөбү")]
    [InlineData("тап", "табышабы")]
    [InlineData("кир", "киришеби")]
    [InlineData("өт", "өтүшөбү")]
    [InlineData("чакыр", "чакырышабы")]
    [InlineData("текшер", "текшеришеби")]
    [InlineData("отур", "отурушабы")]
    [InlineData("үйрөт", "үйрөтүшөбү")]
    [InlineData("кой", "коюшабы")]
    public void PresentAndFuture_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болушпайбы")]
    [InlineData("иште", "иштешпейби")]
    [InlineData("бар", "барышпайбы")]
    [InlineData("изилде", "изилдешпейби")]
    [InlineData("кел", "келишпейби")]
    [InlineData("ойно", "ойношпойбу")]
    [InlineData("күт", "күтүшпөйбү")]
    [InlineData("тап", "табышпайбы")]
    [InlineData("кир", "киришпейби")]
    [InlineData("өт", "өтүшпөйбү")]
    [InlineData("чакыр", "чакырышпайбы")]
    [InlineData("текшер", "текшеришпейби")]
    [InlineData("отур", "отурушпайбы")]
    [InlineData("үйрөт", "үйрөтүшпөйбү")]
    [InlineData("кой", "коюшпайбы")]
    public void PresentAndFuture_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}