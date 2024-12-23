using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

namespace UnitTests.PresentAndFuture;

public class PresentAndFutureСизTests
{
    [Theory]
    [InlineData("бол", "болосуз")]
    [InlineData("иште", "иштейсиз")]
    [InlineData("бар", "барасыз")]
    [InlineData("изилде", "изилдейсиз")]
    [InlineData("кел", "келесиз")]
    [InlineData("ойно", "ойнойсуз")]
    [InlineData("күт", "күтөсүз")]
    [InlineData("тап", "табасыз")]
    [InlineData("кир", "киресиз")]
    [InlineData("өт", "өтөсүз")]
    [InlineData("чакыр", "чакырасыз")]
    [InlineData("текшер", "текшересиз")]
    [InlineData("отур", "отурасыз")]
    [InlineData("үйрөт", "үйрөтөсүз")]
    [InlineData("кой", "коёсуз")]
    public void PresentAndFuture_Сиз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбойсуз")]
    [InlineData("иште", "иштебейсиз")]
    [InlineData("бар", "барбайсыз")]
    [InlineData("изилде", "изилдебейсиз")]
    [InlineData("кел", "келбейсиз")]
    [InlineData("ойно", "ойнобойсуз")]
    [InlineData("күт", "күтпөйсүз")]
    [InlineData("тап", "таппайсыз")]
    [InlineData("кир", "кирбейсиз")]
    [InlineData("өт", "өтпөйсүз")]
    [InlineData("чакыр", "чакырбайсыз")]
    [InlineData("текшер", "текшербейсиз")]
    [InlineData("отур", "отурбайсыз")]
    [InlineData("үйрөт", "үйрөтпөйсүз")]
    [InlineData("кой", "койбойсуз")]
    public void PresentAndFuture_Сиз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болосузбу")]
    [InlineData("иште", "иштейсизби")]
    [InlineData("бар", "барасызбы")]
    [InlineData("изилде", "изилдейсизби")]
    [InlineData("кел", "келесизби")]
    [InlineData("ойно", "ойнойсузбу")]
    [InlineData("күт", "күтөсүзбү")]
    [InlineData("тап", "табасызбы")]
    [InlineData("кир", "киресизби")]
    [InlineData("өт", "өтөсүзбү")]
    [InlineData("чакыр", "чакырасызбы")]
    [InlineData("текшер", "текшересизби")]
    [InlineData("отур", "отурасызбы")]
    [InlineData("үйрөт", "үйрөтөсүзбү")]
    [InlineData("кой", "коёсузбу")]
    public void PresentAndFuture_Сиз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбойсузбу")]
    [InlineData("иште", "иштебейсизби")]
    [InlineData("бар", "барбайсызбы")]
    [InlineData("изилде", "изилдебейсизби")]
    [InlineData("кел", "келбейсизби")]
    [InlineData("ойно", "ойнобойсузбу")]
    [InlineData("күт", "күтпөйсүзбү")]
    [InlineData("тап", "таппайсызбы")]
    [InlineData("кир", "кирбейсизби")]
    [InlineData("өт", "өтпөйсүзбү")]
    [InlineData("чакыр", "чакырбайсызбы")]
    [InlineData("текшер", "текшербейсизби")]
    [InlineData("отур", "отурбайсызбы")]
    [InlineData("үйрөт", "үйрөтпөйсүзбү")]
    [InlineData("кой", "койбойсузбу")]
    public void PresentAndFuture_Сиз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}