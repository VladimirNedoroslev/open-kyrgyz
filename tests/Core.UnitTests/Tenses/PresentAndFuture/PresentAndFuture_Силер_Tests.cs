using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

namespace UnitTests.Tenses.PresentAndFuture;

public class PresentAndFutureСилерTests
{
    [Theory]
    [InlineData("бол", "болосуңар")]
    [InlineData("иште", "иштейсиңер")]
    [InlineData("бар", "барасыңар")]
    [InlineData("изилде", "изилдейсиңер")]
    [InlineData("кел", "келесиңер")]
    [InlineData("ойно", "ойнойсуңар")]
    [InlineData("күт", "күтөсүңөр")]
    [InlineData("тап", "табасыңар")]
    [InlineData("кир", "киресиңер")]
    [InlineData("өт", "өтөсүңөр")]
    [InlineData("чакыр", "чакырасыңар")]
    [InlineData("текшер", "текшересиңер")]
    [InlineData("отур", "отурасыңар")]
    [InlineData("үйрөт", "үйрөтөсүңөр")]
    [InlineData("кой", "коёсуңар")]
    public void PresentAndFuture_Силер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбойсуңар")]
    [InlineData("иште", "иштебейсиңер")]
    [InlineData("бар", "барбайсыңар")]
    [InlineData("изилде", "изилдебейсиңер")]
    [InlineData("кел", "келбейсиңер")]
    [InlineData("ойно", "ойнобойсуңар")]
    [InlineData("күт", "күтпөйсүңөр")]
    [InlineData("тап", "таппайсыңар")]
    [InlineData("кир", "кирбейсиңер")]
    [InlineData("өт", "өтпөйсүңөр")]
    [InlineData("чакыр", "чакырбайсыңар")]
    [InlineData("текшер", "текшербейсиңер")]
    [InlineData("отур", "отурбайсыңар")]
    [InlineData("үйрөт", "үйрөтпөйсүңөр")]
    [InlineData("кой", "койбойсуңар")]
    public void PresentAndFuture_Силер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болосуңарбы")]
    [InlineData("иште", "иштейсиңерби")]
    [InlineData("бар", "барасыңарбы")]
    [InlineData("изилде", "изилдейсиңерби")]
    [InlineData("кел", "келесиңерби")]
    [InlineData("ойно", "ойнойсуңарбы")]
    [InlineData("күт", "күтөсүңөрбү")]
    [InlineData("тап", "табасыңарбы")]
    [InlineData("кир", "киресиңерби")]
    [InlineData("өт", "өтөсүңөрбү")]
    [InlineData("чакыр", "чакырасыңарбы")]
    [InlineData("текшер", "текшересиңерби")]
    [InlineData("отур", "отурасыңарбы")]
    [InlineData("үйрөт", "үйрөтөсүңөрбү")]
    [InlineData("кой", "коёсуңарбы")]
    public void PresentAndFuture_Силер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбойсуңарбы")]
    [InlineData("иште", "иштебейсиңерби")]
    [InlineData("бар", "барбайсыңарбы")]
    [InlineData("изилде", "изилдебейсиңерби")]
    [InlineData("кел", "келбейсиңерби")]
    [InlineData("ойно", "ойнобойсуңарбы")]
    [InlineData("күт", "күтпөйсүңөрбү")]
    [InlineData("тап", "таппайсыңарбы")]
    [InlineData("кир", "кирбейсиңерби")]
    [InlineData("өт", "өтпөйсүңөрбү")]
    [InlineData("чакыр", "чакырбайсыңарбы")]
    [InlineData("текшер", "текшербейсиңерби")]
    [InlineData("отур", "отурбайсыңарбы")]
    [InlineData("үйрөт", "үйрөтпөйсүңөрбү")]
    [InlineData("кой", "койбойсуңарбы")]
    public void PresentAndFuture_Силер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}