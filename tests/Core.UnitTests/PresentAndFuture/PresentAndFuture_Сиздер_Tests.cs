using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

namespace UnitTests.PresentAndFuture;

public class PresentAndFutureСиздерTests
{
    [Theory]
    [InlineData("бол", "болосуздар")]
    [InlineData("иште", "иштейсиздер")]
    [InlineData("бар", "барасыздар")]
    [InlineData("изилде", "изилдейсиздер")]
    [InlineData("кел", "келесиздер")]
    [InlineData("ойно", "ойнойсуздар")]
    [InlineData("күт", "күтөсүздөр")]
    [InlineData("тап", "табасыздар")]
    [InlineData("кир", "киресиздер")]
    [InlineData("өт", "өтөсүздөр")]
    [InlineData("чакыр", "чакырасыздар")]
    [InlineData("текшер", "текшересиздер")]
    [InlineData("отур", "отурасыздар")]
    [InlineData("үйрөт", "үйрөтөсүздөр")]
    public void PresentAndFuture_Сиздер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбойсуздар")]
    [InlineData("иште", "иштебейсиздер")]
    [InlineData("бар", "барбайсыздар")]
    [InlineData("изилде", "изилдебейсиздер")]
    [InlineData("кел", "келбейсиздер")]
    [InlineData("ойно", "ойнобойсуздар")]
    [InlineData("күт", "күтпөйсүздөр")]
    [InlineData("тап", "таппайсыздар")]
    [InlineData("кир", "кирбейсиздер")]
    [InlineData("өт", "өтпөйсүздөр")]
    [InlineData("чакыр", "чакырбайсыздар")]
    [InlineData("текшер", "текшербейсиздер")]
    [InlineData("отур", "отурбайсыздар")]
    [InlineData("үйрөт", "үйрөтпөйсүздөр")]
    public void PresentAndFuture_Сиздер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болосуздарбы")]
    [InlineData("иште", "иштейсиздерби")]
    [InlineData("бар", "барасыздарбы")]
    [InlineData("изилде", "изилдейсиздерби")]
    [InlineData("кел", "келесиздерби")]
    [InlineData("ойно", "ойнойсуздарбы")]
    [InlineData("күт", "күтөсүздөрбү")]
    [InlineData("тап", "табасыздарбы")]
    [InlineData("кир", "киресиздерби")]
    [InlineData("өт", "өтөсүздөрбү")]
    [InlineData("чакыр", "чакырасыздарбы")]
    [InlineData("текшер", "текшересиздерби")]
    [InlineData("отур", "отурасыздарбы")]
    [InlineData("үйрөт", "үйрөтөсүздөрбү")]
    public void PresentAndFuture_Сиздер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбойсуздарбы")]
    [InlineData("иште", "иштебейсиздерби")]
    [InlineData("бар", "барбайсыздарбы")]
    [InlineData("изилде", "изилдебейсиздерби")]
    [InlineData("кел", "келбейсиздерби")]
    [InlineData("ойно", "ойнобойсуздарбы")]
    [InlineData("күт", "күтпөйсүздөрбү")]
    [InlineData("тап", "таппайсыздарбы")]
    [InlineData("кир", "кирбейсиздерби")]
    [InlineData("өт", "өтпөйсүздөрбү")]
    [InlineData("чакыр", "чакырбайсыздарбы")]
    [InlineData("текшер", "текшербейсиздерби")]
    [InlineData("отур", "отурбайсыздарбы")]
    [InlineData("үйрөт", "үйрөтпөйсүздөрбү")]
    public void PresentAndFuture_Сиздер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}