using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PastSudden;

namespace UnitTests.Tenses.Past.Sudden;

public class PastSuddenМенTests
{
    [Theory]
    [InlineData("бар", "барыптырмын")]
    [InlineData("иште", "иштептирмин")]
    [InlineData("бол", "болуптурмун")]
    [InlineData("көр", "көрүптүрмүн")]
    [InlineData("тап", "табыптырмын")]
    [InlineData("чеч", "чечиптирмин")]
    [InlineData("ук", "угуптурмун")]
    [InlineData("күт", "күтүптүрмүн")]
    [InlineData("кой", "коюптурмун")]
    public void PastSudden_Мен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбаптырмын")]
    [InlineData("иште", "иштебептирмин")]
    [InlineData("бол", "болбоптурмун")]
    [InlineData("көр", "көрбөптүрмүн")]
    [InlineData("тап", "таппаптырмын")]
    [InlineData("чеч", "чечпептирмин")]
    [InlineData("ук", "укпаптырмын")]
    [InlineData("күт", "күтпөптүрмүн")]
    public void PastSudden_Мен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барыптырмынбы")]
    [InlineData("иште", "иштептирминби")]
    [InlineData("бол", "болуптурмунбу")]
    [InlineData("көр", "көрүптүрмүнбү")]
    [InlineData("тап", "табыптырмынбы")]
    [InlineData("чеч", "чечиптирминби")]
    [InlineData("ук", "угуптурмунбу")]
    [InlineData("күт", "күтүптүрмүнбү")]
    [InlineData("кой", "коюптурмунбу")]
    public void PastSudden_Мен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барбаптырмынбы")]
    [InlineData("иште", "иштебептирминби")]
    [InlineData("бол", "болбоптурмунбу")]
    [InlineData("көр", "көрбөптүрмүнбү")]
    [InlineData("тап", "таппаптырмынбы")]
    [InlineData("чеч", "чечпептирминби")]
    [InlineData("ук", "укпаптырмынбы")]
    [InlineData("күт", "күтпөптүрмүнбү")]
    public void PastSudden_Мен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}