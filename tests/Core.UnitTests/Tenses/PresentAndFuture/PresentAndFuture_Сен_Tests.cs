using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PresentAndFutureSimple;

namespace UnitTests.Tenses.PresentAndFuture;

public class PresentAndFutureСенTests
{
    [Theory]
    [InlineData("бол", "болосуң")]
    [InlineData("иште", "иштейсиң")]
    [InlineData("бар", "барасың")]
    [InlineData("изилде", "изилдейсиң")]
    [InlineData("кел", "келесиң")]
    [InlineData("ойно", "ойнойсуң")]
    [InlineData("күт", "күтөсүң")]
    [InlineData("тап", "табасың")]
    [InlineData("кир", "киресиң")]
    [InlineData("өт", "өтөсүң")]
    [InlineData("чакыр", "чакырасың")]
    [InlineData("текшер", "текшересиң")]
    [InlineData("отур", "отурасың")]
    [InlineData("үйрөт", "үйрөтөсүң")]
    [InlineData("кой", "коёсуң")]
    public void PresentAndFuture_Сен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбойсуң")]
    [InlineData("иште", "иштебейсиң")]
    [InlineData("бар", "барбайсың")]
    [InlineData("изилде", "изилдебейсиң")]
    [InlineData("кел", "келбейсиң")]
    [InlineData("ойно", "ойнобойсуң")]
    [InlineData("күт", "күтпөйсүң")]
    [InlineData("тап", "таппайсың")]
    [InlineData("кир", "кирбейсиң")]
    [InlineData("өт", "өтпөйсүң")]
    [InlineData("чакыр", "чакырбайсың")]
    [InlineData("текшер", "текшербейсиң")]
    [InlineData("отур", "отурбайсың")]
    [InlineData("үйрөт", "үйрөтпөйсүң")]
    [InlineData("кой", "койбойсуң")]
    public void PresentAndFuture_Сен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болосуңбу")]
    [InlineData("иште", "иштейсиңби")]
    [InlineData("бар", "барасыңбы")]
    [InlineData("изилде", "изилдейсиңби")]
    [InlineData("кел", "келесиңби")]
    [InlineData("ойно", "ойнойсуңбу")]
    [InlineData("күт", "күтөсүңбү")]
    [InlineData("тап", "табасыңбы")]
    [InlineData("кир", "киресиңби")]
    [InlineData("өт", "өтөсүңбү")]
    [InlineData("чакыр", "чакырасыңбы")]
    [InlineData("текшер", "текшересиңби")]
    [InlineData("отур", "отурасыңбы")]
    [InlineData("үйрөт", "үйрөтөсүңбү")]
    [InlineData("кой", "коёсуңбу")]
    public void PresentAndFuture_Сен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбойсуңбу")]
    [InlineData("иште", "иштебейсиңби")]
    [InlineData("бар", "барбайсыңбы")]
    [InlineData("изилде", "изилдебейсиңби")]
    [InlineData("кел", "келбейсиңби")]
    [InlineData("ойно", "ойнобойсуңбу")]
    [InlineData("күт", "күтпөйсүңбү")]
    [InlineData("тап", "таппайсыңбы")]
    [InlineData("кир", "кирбейсиңби")]
    [InlineData("өт", "өтпөйсүңбү")]
    [InlineData("чакыр", "чакырбайсыңбы")]
    [InlineData("текшер", "текшербейсиңби")]
    [InlineData("отур", "отурбайсыңбы")]
    [InlineData("үйрөт", "үйрөтпөйсүңбү")]
    [InlineData("кой", "койбойсуңбу")]
    public void PresentAndFuture_Сен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}