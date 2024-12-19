using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastSudden;

namespace UnitTests;

public class PastSuddenTests
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
    public void PastSudden_Мен(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenTenseConjugator.Conjugate(verb, PronounEnum.Мен);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барыптырсың")]
    [InlineData("иште", "иштептирсиң")]
    [InlineData("бол", "болуптурсуң")]
    [InlineData("көр", "көрүптүрсүң")]
    [InlineData("тап", "табыптырсың")]
    [InlineData("чеч", "чечиптирсиң")]
    [InlineData("ук", "угуптурсуң")]
    [InlineData("күт", "күтүптүрсүң")]
    public void PastSudden_Сен(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenTenseConjugator.Conjugate(verb, PronounEnum.Сен);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барыптырсыз")]
    [InlineData("иште", "иштептирсиз")]
    [InlineData("бол", "болуптурсуз")]
    [InlineData("көр", "көрүптүрсүз")]
    [InlineData("тап", "табыптырсыз")]
    [InlineData("чеч", "чечиптирсиз")]
    [InlineData("ук", "угуптурсуз")]
    [InlineData("күт", "күтүптүрсүз")]
    public void PastSudden_Сиз(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenTenseConjugator.Conjugate(verb, PronounEnum.Сиз);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барыптыр")]
    [InlineData("иште", "иштептир")]
    [InlineData("бол", "болуптур")]
    [InlineData("көр", "көрүптүр")]
    [InlineData("тап", "табыптыр")]
    [InlineData("чеч", "чечиптир")]
    [InlineData("ук", "угуптур")]
    [InlineData("күт", "күтүптүр")]
    public void PastSudden_Ал(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenTenseConjugator.Conjugate(verb, PronounEnum.Ал);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барыптырбыз")]
    [InlineData("иште", "иштептирбиз")]
    [InlineData("бол", "болуптурбуз")]
    [InlineData("көр", "көрүптүрбүз")]
    [InlineData("тап", "табыптырбыз")]
    [InlineData("чеч", "чечиптирбиз")]
    [InlineData("ук", "угуптурбуз")]
    [InlineData("күт", "күтүптүрбүз")]
    public void PastSudden_Биз(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenTenseConjugator.Conjugate(verb, PronounEnum.Биз);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барыптырсыңар")]
    [InlineData("иште", "иштептирсиңер")]
    [InlineData("бол", "болуптурсуңар")]
    [InlineData("көр", "көрүптүрсүңөр")]
    [InlineData("тап", "табыптырсыңар")]
    [InlineData("чеч", "чечиптирсиңер")]
    [InlineData("ук", "угуптурсуңар")]
    [InlineData("күт", "күтүптүрсүңөр")]
    public void PastSudden_Силер(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenTenseConjugator.Conjugate(verb, PronounEnum.Силер);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барыптырсыздар")]
    [InlineData("иште", "иштептирсиздер")]
    [InlineData("бол", "болуптурсуздар")]
    [InlineData("көр", "көрүптүрсүздөр")]
    [InlineData("тап", "табыптырсыздар")]
    [InlineData("чеч", "чечиптирсиздер")]
    [InlineData("ук", "угуптурсуздар")]
    [InlineData("күт", "күтүптүрсүздөр")]
    public void PastSudden_Сиздер(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenTenseConjugator.Conjugate(verb, PronounEnum.Сиздер);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышыптыр")]
    [InlineData("иште", "иштешиптир")]
    [InlineData("бол", "болушуптур")]
    [InlineData("көр", "көрүшүптүр")]
    [InlineData("тап", "табышыптыр")]
    [InlineData("чеч", "чечишиптир")]
    [InlineData("ук", "угушуптур")]
    [InlineData("күт", "күтүшүптүр")]
    public void PastSudden_Алар(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenTenseConjugator.Conjugate(verb, PronounEnum.Алар);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}