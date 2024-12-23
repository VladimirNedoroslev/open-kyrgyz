using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

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
    [InlineData("бол", "болушатпы")]
    [InlineData("иште", "иштешетпи")]
    [InlineData("бар", "барышатпы")]
    [InlineData("изилде", "изилдешетпи")]
    [InlineData("кел", "келишетпи")]
    [InlineData("ойно", "ойношотпу")]
    [InlineData("күт", "күтүшөтпү")]
    [InlineData("тап", "табышатпы")]
    [InlineData("кир", "киришетпи")]
    [InlineData("өт", "өтүшөтпү")]
    [InlineData("чакыр", "чакырышатпы")]
    [InlineData("текшер", "текшеришетпи")]
    [InlineData("отур", "отурушатпы")]
    [InlineData("үйрөт", "үйрөтүшөтпү")]
    [InlineData("кой", "коюшатпы")]
    public void PresentAndFuture_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болушпайтпы")]
    [InlineData("иште", "иштешпейтпи")]
    [InlineData("бар", "барышпайтпы")]
    [InlineData("изилде", "изилдешпейтпи")]
    [InlineData("кел", "келишпейтпи")]
    [InlineData("ойно", "ойношпойтпу")]
    [InlineData("күт", "күтүшпөйтпү")]
    [InlineData("тап", "табышпайтпы")]
    [InlineData("кир", "киришпейтпи")]
    [InlineData("өт", "өтүшпөйтпү")]
    [InlineData("чакыр", "чакырышпайтпы")]
    [InlineData("текшер", "текшеришпейтпи")]
    [InlineData("отур", "отурушпайтпы")]
    [InlineData("үйрөт", "үйрөтүшпөйтпү")]
    [InlineData("кой", "коюшпайтпы")]
    public void PresentAndFuture_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}