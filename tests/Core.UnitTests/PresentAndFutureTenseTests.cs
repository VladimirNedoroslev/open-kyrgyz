using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

namespace UnitTests;

public class PresentAndFutureTenseTests
{
    [Theory]
    [InlineData("бол", "боломун")]
    [InlineData("иште", "иштеймин")]
    [InlineData("бар", "барамын")]
    [InlineData("изилде", "изилдеймин")]
    [InlineData("кел", "келемин")]
    [InlineData("ойно", "ойноймун")]
    [InlineData("күт", "күтөмүн")]
    [InlineData("тап", "табамын")]
    [InlineData("кир", "киремин")]
    [InlineData("өт", "өтөмүн")]
    [InlineData("чакыр", "чакырамын")]
    [InlineData("текшер", "текшеремин")]
    [InlineData("отур", "отурамын")]
    [InlineData("үйрөт", "үйрөтөмүн")]
    public void PresentAndFuture_Мен(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleTenseConjugator.Conjugate(verb, PronounEnum.Мен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
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
    public void PresentAndFuture_Сен(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleTenseConjugator.Conjugate(verb, PronounEnum.Сен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
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
    public void PresentAndFuture_Сиз(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleTenseConjugator.Conjugate(verb, PronounEnum.Сиз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
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
    public void PresentAndFuture_Ал(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleTenseConjugator.Conjugate(verb, PronounEnum.Ал);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
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
    public void PresentAndFuture_Биз(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleTenseConjugator.Conjugate(verb, PronounEnum.Биз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
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
    public void PresentAndFuture_Силер(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleTenseConjugator.Conjugate(verb, PronounEnum.Силер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
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
    public void PresentAndFuture_Сиздер(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleTenseConjugator.Conjugate(verb, PronounEnum.Сиздер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
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
    public void PresentAndFuture_Алар(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleTenseConjugator.Conjugate(verb, PronounEnum.Алар);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}