// using FluentAssertions;
// using OpenKyrgyz.Core.Enums;
// using OpenKyrgyz.Core.Tenses.Conditional;
//
// namespace UnitTests.Conditional;
//
// public class ConditionalTenseTests
// {
//     [Theory]
//     [InlineData("бар", "барсам")]
//     [InlineData("иште", "иштесем")]
//     [InlineData("бол", "болсом")]
//     [InlineData("көр", "көрсөм")]
//     [InlineData("тап", "тапсам")]
//     [InlineData("чеч", "чечсем")]
//     [InlineData("ук", "уксам")]
//     [InlineData("күт", "күтсөм")]
//     public void Conditional_Мен(string verb, string expectedResult)
//     {
//         // act
//         var actualResult = ConditionalTenseConjugator.Conjugate(verb, PronounEnum.Мен);
//
//         // assert
//         actualResult.Should().Be(expectedResult);
//     }
//
//     [Theory]
//     [InlineData("бар", "барсаң")]
//     [InlineData("иште", "иштесең")]
//     [InlineData("бол", "болсоң")]
//     [InlineData("көр", "көрсөң")]
//     [InlineData("тап", "тапсаң")]
//     [InlineData("чеч", "чечсең")]
//     [InlineData("ук", "уксаң")]
//     [InlineData("күт", "күтсөң")]
//     public void Conditional_Сен(string verb, string expectedResult)
//     {
//         // act
//         var actualResult = ConditionalTenseConjugator.Conjugate(verb, PronounEnum.Сен);
//
//         // assert
//         actualResult.Should().Be(expectedResult);
//     }
//
//     [Theory]
//     [InlineData("бар", "барсаңыз")]
//     [InlineData("иште", "иштесеңиз")]
//     [InlineData("бол", "болсоңуз")]
//     [InlineData("көр", "көрсөңүз")]
//     [InlineData("тап", "тапсаңыз")]
//     [InlineData("чеч", "чечсеңиз")]
//     [InlineData("ук", "уксаңуз")]
//     [InlineData("күт", "күтсөңүз")]
//     public void Conditional_Сиз(string verb, string expectedResult)
//     {
//         // act
//         var actualResult = ConditionalTenseConjugator.Conjugate(verb, PronounEnum.Сиз);
//
//         // assert
//         actualResult.Should().Be(expectedResult);
//     }
//
//     [Theory]
//     [InlineData("бар", "барса")]
//     [InlineData("иште", "иштесе")]
//     [InlineData("бол", "болсо")]
//     [InlineData("көр", "көрсө")]
//     [InlineData("тап", "тапса")]
//     [InlineData("чеч", "чечсе")]
//     [InlineData("ук", "укса")]
//     [InlineData("күт", "күтсө")]
//     public void Conditional_Ал(string verb, string expectedResult)
//     {
//         // act
//         var actualResult = ConditionalTenseConjugator.Conjugate(verb, PronounEnum.Ал);
//
//         // assert
//         actualResult.Should().Be(expectedResult);
//     }
//
//     [Theory]
//     [InlineData("бар", "барсак")]
//     [InlineData("иште", "иштесек")]
//     [InlineData("бол", "болсок")]
//     [InlineData("көр", "көрсөк")]
//     [InlineData("тап", "тапсак")]
//     [InlineData("чеч", "чечсек")]
//     [InlineData("ук", "уксак")]
//     [InlineData("күт", "күтсөк")]
//     public void Conditional_Биз(string verb, string expectedResult)
//     {
//         // act
//         var actualResult = ConditionalTenseConjugator.Conjugate(verb, PronounEnum.Биз);
//
//         // assert
//         actualResult.Should().Be(expectedResult);
//     }
//
//     [Theory]
//     [InlineData("бар", "барсаңар")]
//     [InlineData("иште", "иштесеңер")]
//     [InlineData("бол", "болсоңор")]
//     [InlineData("көр", "көрсөңөр")]
//     [InlineData("тап", "тапсаңар")]
//     [InlineData("чеч", "чечсеңер")]
//     [InlineData("ук", "уксаңар")]
//     [InlineData("күт", "күтсөңөр")]
//     public void Conditional_Силер(string verb, string expectedResult)
//     {
//         // act
//         var actualResult = ConditionalTenseConjugator.Conjugate(verb, PronounEnum.Силер);
//
//         // assert
//         actualResult.Should().Be(expectedResult);
//     }
//
//     [Theory]
//     [InlineData("бар", "барсаңыздар")]
//     [InlineData("иште", "иштесеңиздер")]
//     [InlineData("бол", "болсоңуздар")]
//     [InlineData("көр", "көрсөңүздөр")]
//     [InlineData("тап", "тапсаңыздар")]
//     [InlineData("чеч", "чечсеңиздер")]
//     [InlineData("ук", "уксаңыздар")]
//     [InlineData("күт", "күтсөңүздөр")]
//     public void Conditional_Сиздер(string verb, string expectedResult)
//     {
//         // act
//         var actualResult = ConditionalTenseConjugator.Conjugate(verb, PronounEnum.Сиздер);
//
//         // assert
//         actualResult.Should().Be(expectedResult);
//     }
//
//     [Theory]
//     [InlineData("бар", "барышса")]
//     [InlineData("иште", "иштешсе")]
//     [InlineData("бол", "болушса")]
//     [InlineData("көр", "көрүшсө")]
//     [InlineData("тап", "табышса")]
//     [InlineData("чеч", "чечишсе")]
//     [InlineData("ук", "угушса")]
//     [InlineData("күт", "күтүшсө")]
//     public void Conditional_Алар(string verb, string expectedResult)
//     {
//         // act
//         var actualResult = ConditionalTenseConjugator.Conjugate(verb, PronounEnum.Алар);
//
//         // assert
//         actualResult.Should().Be(expectedResult);
//     }
// }