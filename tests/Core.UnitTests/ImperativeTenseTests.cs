using FluentAssertions;
using OpenKyrgyz.Core.Tenses.Imperative;

namespace UnitTests;

public class ImperativeTenseTests
{
    
    [Theory]
    [InlineData("бол", "болчу")]
    [InlineData("иште", "иштечи")]
    [InlineData("бар", "барчы")]
    [InlineData("изилде", "изилдечи")]
    [InlineData("кел", "келчи")]
    [InlineData("ойно", "ойночу")]
    [InlineData("күт", "күтчү")]
    [InlineData("тап", "тапчы")]
    [InlineData("кир", "кирчи")]
    [InlineData("өт", "өтчү")]
    [InlineData("чакыр", "чакырчы")]
    [InlineData("текшер", "текшерчи")]
    [InlineData("отур", "отурчу")]
    [InlineData("үйрөт", "үйрөтчү")]
    public void GivenVerb_WhenSenPoliteImperativeGenerated_ThenCorrectImperativeFormReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСенPolite.Generate(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бол", "болгун")]
    [InlineData("иште", "иштегин")]
    [InlineData("бар", "баргын")]
    [InlineData("изилде", "изилдегин")]
    [InlineData("кел", "келгин")]
    [InlineData("ойно", "ойногун")]
    [InlineData("күт", "күткүн")]
    [InlineData("тап", "тапкын")]
    [InlineData("кир", "киргин")]
    [InlineData("өт", "өткүн")]
    [InlineData("чакыр", "чакыргын")]
    [InlineData("текшер", "текшергин")]
    [InlineData("отур", "отургун")]
    [InlineData("үйрөт", "үйрөткүн")]
    public void GivenVerb_WhenSenOrderImperativeGenerated_ThenCorrectImperativeFormReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСенOrder.Generate(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бол", "болгула")]
    [InlineData("иште", "иштегиле")]
    [InlineData("бар", "баргыла")]
    [InlineData("изилде", "изилдегиле")]
    [InlineData("кел", "келгиле")]
    [InlineData("ойно", "ойногула")]
    [InlineData("күт", "күткүлө")]
    [InlineData("тап", "тапкыла")]
    [InlineData("кир", "киргиле")]
    [InlineData("өт", "өткүлө")]
    [InlineData("чакыр", "чакыргыла")]
    [InlineData("текшер", "текшергиле")]
    [InlineData("отур", "отургула")]
    [InlineData("үйрөт", "үйрөткүлө")]
    public void GivenVerb_WhenSilerPoliteImperativeGenerated_ThenCorrectImperativeFormReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСилер.Generate(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бол", "болуңуз")]
    [InlineData("иште", "иштеңиз")]
    [InlineData("бар", "барыңыз")]
    [InlineData("изилде", "изилдеңиз")]
    [InlineData("кел", "келиңиз")]
    [InlineData("ойно", "ойноңуз")]
    [InlineData("күт", "күтүңүз")]
    [InlineData("тап", "табыңыз")]
    [InlineData("кир", "кириңиз")]
    [InlineData("өт", "өтүңүз")]
    [InlineData("чакыр", "чакырыңыз")]
    [InlineData("текшер", "текшериңиз")]
    [InlineData("отур", "отуруңуз")]
    [InlineData("үйрөт", "үйрөтүңүз")]
    public void GivenVerb_WhenSizImperativeGenerated_ThenCorrectImperativeFormReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСиз.Generate(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    
    [Theory]
    [InlineData("бол", "болуңуздар")]
    [InlineData("иште", "иштеңиздер")]
    [InlineData("бар", "барыңыздар")]
    [InlineData("изилде", "изилдеңиздер")]
    [InlineData("кел", "келиңиздер")]
    [InlineData("ойно", "ойноңуздар")]
    [InlineData("күт", "күтүңүздөр")]
    [InlineData("тап", "табыңыздар")]
    [InlineData("кир", "кириңиздер")]
    [InlineData("өт", "өтүңүздөр")]
    [InlineData("чакыр", "чакырыңыздар")]
    [InlineData("текшер", "текшериңиздер")]
    [InlineData("отур", "отуруңуздар")]
    [InlineData("үйрөт", "үйрөтүңүздөр")]
    public void GivenVerb_WhenSizderImperativeGenerated_ThenCorrectImperativeFormReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСиздер.Generate(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бол", "болсун")]
    [InlineData("иште", "иштесин")]
    [InlineData("бар", "барсын")]
    [InlineData("изилде", "изилдесин")]
    [InlineData("кел", "келсин")]
    [InlineData("ойно", "ойносун")]
    [InlineData("күт", "күтсүн")]
    [InlineData("тап", "тапсын")]
    [InlineData("кир", "кирсин")]
    [InlineData("өт", "өтсүн")]
    [InlineData("чакыр", "чакырсын")]
    [InlineData("текшер", "текшерсин")]
    [InlineData("отур", "отурсун")]
    [InlineData("үйрөт", "үйрөтсүн")]
    public void GivenVerb_WhenAlImperativeGenerated_ThenCorrectImperativeFormReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeАл.Generate(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бол", "болушсун")]
    [InlineData("иште", "иштешсин")]
    [InlineData("бар", "барышсын")]
    [InlineData("изилде", "изилдешсин")]
    [InlineData("кел", "келишсин")]
    [InlineData("ойно", "ойношсун")]
    [InlineData("күт", "күтүшсүн")]
    [InlineData("тап", "табышсын")]
    [InlineData("кир", "киришсин")]
    [InlineData("өт", "өтүшсүн")]
    [InlineData("чакыр", "чакырышсын")]
    [InlineData("текшер", "текшеришсин")]
    [InlineData("отур", "отурушсун")]
    [InlineData("үйрөт", "үйрөтүшсүн")]
    public void GivenVerb_WhenAlarImperativeGenerated_ThenCorrectImperativeFormReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeАлар.Generate(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}