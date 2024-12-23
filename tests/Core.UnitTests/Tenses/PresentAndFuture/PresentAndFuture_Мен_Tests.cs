using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

namespace UnitTests.Tenses.PresentAndFuture;

public class PresentAndFutureМенTests
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
    [InlineData("кой", "коёмун")]
    public void PresentAndFuture_Мен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбоймун")]
    [InlineData("иште", "иштебеймин")]
    [InlineData("бар", "барбаймын")]
    [InlineData("изилде", "изилдебеймин")]
    [InlineData("кел", "келбеймин")]
    [InlineData("ойно", "ойнобоймун")]
    [InlineData("күт", "күтпөймүн")]
    [InlineData("тап", "таппаймын")]
    [InlineData("кир", "кирбеймин")]
    [InlineData("өт", "өтпөймүн")]
    [InlineData("чакыр", "чакырбаймын")]
    [InlineData("текшер", "текшербеймин")]
    [InlineData("отур", "отурбаймын")]
    [InlineData("үйрөт", "үйрөтпөймүн")]
    [InlineData("кой", "койбоймун")]
    public void PresentAndFuture_Мен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "боломунбу")]
    [InlineData("иште", "иштейминби")]
    [InlineData("бар", "барамынбы")]
    [InlineData("изилде", "изилдейминби")]
    [InlineData("кел", "келеминби")]
    [InlineData("ойно", "ойноймунбу")]
    [InlineData("күт", "күтөмүнбү")]
    [InlineData("тап", "табамынбы")]
    [InlineData("кир", "киреминби")]
    [InlineData("өт", "өтөмүнбү")]
    [InlineData("чакыр", "чакырамынбы")]
    [InlineData("текшер", "текшереминби")]
    [InlineData("отур", "отурамынбы")]
    [InlineData("үйрөт", "үйрөтөмүнбү")]
    [InlineData("кой", "коёмунбу")]
    public void PresentAndFuture_Мен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбоймунбу")]
    [InlineData("иште", "иштебейминби")]
    [InlineData("бар", "барбаймынбы")]
    [InlineData("изилде", "изилдебейминби")]
    [InlineData("кел", "келбейминби")]
    [InlineData("ойно", "ойнобоймунбу")]
    [InlineData("күт", "күтпөймүнбү")]
    [InlineData("тап", "таппаймынбы")]
    [InlineData("кир", "кирбейминби")]
    [InlineData("өт", "өтпөймүнбү")]
    [InlineData("чакыр", "чакырбаймынбы")]
    [InlineData("текшер", "текшербейминби")]
    [InlineData("отур", "отурбаймынбы")]
    [InlineData("үйрөт", "үйрөтпөймүнбү")]
    [InlineData("кой", "койбоймунбу")]
    public void PresentAndFuture_Мен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PresentAndFutureSimpleConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}