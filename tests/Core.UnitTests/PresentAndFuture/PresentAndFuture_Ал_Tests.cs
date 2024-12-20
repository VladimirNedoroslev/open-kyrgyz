using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

namespace UnitTests.PresentAndFuture;

public class PresentAndFutureАлTests
{
    [Theory]
    [InlineData("бол", "болот")]
    [InlineData("иште", "иштейт")]
    [InlineData("бар", "барат")]
    [InlineData("изилде", "изилдейт")]
    [InlineData("кел", "келет")]
    [InlineData("ойно", "ойнойт")]
    [InlineData("күт", "күтөт")]
    [InlineData("тап", "табат")]
    [InlineData("кир", "кирет")]
    [InlineData("өт", "өтөт")]
    [InlineData("чакыр", "чакырат")]
    [InlineData("текшер", "текшерет")]
    [InlineData("отур", "отурат")]
    [InlineData("үйрөт", "үйрөтөт")]
    public void PresentAndFuture_Ал_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбойт")]
    [InlineData("иште", "иштебейт")]
    [InlineData("бар", "барбайт")]
    [InlineData("изилде", "изилдебейт")]
    [InlineData("кел", "келбейт")]
    [InlineData("ойно", "ойнобойт")]
    [InlineData("күт", "күтпөйт")]
    [InlineData("тап", "таппайт")]
    [InlineData("кир", "кирбейт")]
    [InlineData("өт", "өтпөйт")]
    [InlineData("чакыр", "чакырбайт")]
    [InlineData("текшер", "текшербейт")]
    [InlineData("отур", "отурбайт")]
    [InlineData("үйрөт", "үйрөтпөйт")]
    public void PresentAndFuture_Ал_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болобу")]
    [InlineData("иште", "иштейби")]
    [InlineData("бар", "барабы")]
    [InlineData("изилде", "изилдейби")]
    [InlineData("кел", "келеби")]
    [InlineData("ойно", "ойнойбу")]
    [InlineData("күт", "күтөбү")]
    [InlineData("тап", "табабы")]
    [InlineData("кир", "киреби")]
    [InlineData("өт", "өтөбү")]
    [InlineData("чакыр", "чакырабы")]
    [InlineData("текшер", "текшереби")]
    [InlineData("отур", "отурабы")]
    [InlineData("үйрөт", "үйрөтөбү")]
    public void PresentAndFuture_Ал_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбойбу")]
    [InlineData("иште", "иштебейби")]
    [InlineData("бар", "барбайбы")]
    [InlineData("изилде", "изилдебейби")]
    [InlineData("кел", "келбейби")]
    [InlineData("ойно", "ойнобойбу")]
    [InlineData("күт", "күтпөйбү")]
    [InlineData("тап", "таппайбы")]
    [InlineData("кир", "кирбейби")]
    [InlineData("өт", "өтпөйбү")]
    [InlineData("чакыр", "чакырбайбы")]
    [InlineData("текшер", "текшербейби")]
    [InlineData("отур", "отурбайбы")]
    [InlineData("үйрөт", "үйрөтпөйбү")]
    public void PresentAndFuture_Ал_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}