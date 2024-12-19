using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastIndefinite;

namespace UnitTests;

public class PastIndefiniteTests
{
    [Theory]
    [InlineData("бар", "барганмын")]
    [InlineData("иште", "иштегенмин")]
    [InlineData("бол", "болгонмун")]
    [InlineData("көр", "көргөнмүн")]
    [InlineData("тап", "тапканмын")]
    [InlineData("чеч", "чечкенмин")]
    [InlineData("ук", "укканмын")]
    [InlineData("күт", "күткөнмүн")]
    public void PastIndefinite_Мен(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteTenseConjugator.Conjugate(verb, PronounEnum.Мен);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "баргансың")]
    [InlineData("иште", "иштегенсиң")]
    [InlineData("бол", "болгонсуң")]
    [InlineData("көр", "көргөнсүң")]
    [InlineData("тап", "тапкансың")]
    [InlineData("чеч", "чечкенсиң")]
    [InlineData("ук", "уккансың")]
    [InlineData("күт", "күткөнсүң")]
    public void PastIndefinite_Сен(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сен);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "баргансыз")]
    [InlineData("иште", "иштегенсиз")]
    [InlineData("бол", "болгонсуз")]
    [InlineData("көр", "көргөнсүз")]
    [InlineData("тап", "тапкансыз")]
    [InlineData("чеч", "чечкенсиз")]
    [InlineData("ук", "уккансыз")]
    [InlineData("күт", "күткөнсүз")]
    public void PastIndefinite_Сиз(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сиз);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барган")]
    [InlineData("иште", "иштеген")]
    [InlineData("бол", "болгон")]
    [InlineData("көр", "көргөн")]
    [InlineData("тап", "тапкан")]
    [InlineData("чеч", "чечкен")]
    [InlineData("ук", "уккан")]
    [InlineData("күт", "күткөн")]
    public void PastIndefinite_Ал(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteTenseConjugator.Conjugate(verb, PronounEnum.Ал);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барганбыз")]
    [InlineData("иште", "иштегенбиз")]
    [InlineData("бол", "болгонбуз")]
    [InlineData("көр", "көргөнбүз")]
    [InlineData("тап", "тапканбыз")]
    [InlineData("чеч", "чечкенбиз")]
    [InlineData("ук", "укканбыз")]
    [InlineData("күт", "күткөнбүз")]
    public void PastIndefinite_Биз(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteTenseConjugator.Conjugate(verb, PronounEnum.Биз);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "баргансыңар")]
    [InlineData("иште", "иштегенсиңер")]
    [InlineData("бол", "болгонсуңар")]
    [InlineData("көр", "көргөнсүңөр")]
    [InlineData("тап", "тапкансыңар")]
    [InlineData("чеч", "чечкенсиңер")]
    [InlineData("ук", "уккансыңар")]
    [InlineData("күт", "күткөнсүңөр")]
    public void PastIndefinite_Силер(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteTenseConjugator.Conjugate(verb, PronounEnum.Силер);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "баргансыздар")]
    [InlineData("иште", "иштегенсиздер")]
    [InlineData("бол", "болгонсуздар")]
    [InlineData("көр", "көргөнсүздөр")]
    [InlineData("тап", "тапкансыздар")]
    [InlineData("чеч", "чечкенсиздер")]
    [InlineData("ук", "уккансыздар")]
    [InlineData("күт", "күткөнсүздөр")]
    public void PastIndefinite_Сиздер(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сиздер);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышкан")]
    [InlineData("иште", "иштешкен")]
    [InlineData("бол", "болушкан")]
    [InlineData("көр", "көрүшкөн")]
    [InlineData("тап", "табышкан")]
    [InlineData("чеч", "чечишкен")]
    [InlineData("ук", "угушкан")]
    [InlineData("күт", "күтүшкөн")]
    public void PastIndefinite_Алар(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteTenseConjugator.Conjugate(verb, PronounEnum.Алар);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}