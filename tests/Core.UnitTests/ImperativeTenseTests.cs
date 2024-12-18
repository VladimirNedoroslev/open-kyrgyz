using FluentAssertions;
using OpenKyrgyz.Core.Tenses.Imperative;

namespace UnitTests;

public class ImperativeTenseTests
{
    
    [Theory]
    [InlineData("бол", "чу")]
    [InlineData("иште", "чи")]
    [InlineData("бар", "чы")]
    [InlineData("изилде", "чи")]
    [InlineData("кел", "чи")]
    [InlineData("ойно", "чу")]
    [InlineData("күт", "чү")]
    [InlineData("тап", "чы")]
    [InlineData("кир", "чи")]
    [InlineData("өт", "чү")]
    [InlineData("чакыр", "чы")]
    [InlineData("текшер", "чи")]
    [InlineData("отур", "чу")]
    [InlineData("үйрөт", "чү")]
    public void GivenVerb_WhenSenPoliteImperativeGenerated_ThenCorrectImperativeEndingReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСенPolite.Generate(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бол", "гун")]
    [InlineData("иште", "гин")]
    [InlineData("бар", "гын")]
    [InlineData("изилде", "гин")]
    [InlineData("кел", "гин")]
    [InlineData("ойно", "гун")]
    [InlineData("күт", "күн")]
    [InlineData("тап", "кын")]
    [InlineData("кир", "гин")]
    [InlineData("өт", "күн")]
    [InlineData("чакыр", "гын")]
    [InlineData("текшер", "гин")]
    [InlineData("отур", "гун")]
    [InlineData("үйрөт", "күн")]
    public void GivenVerb_WhenSenOrderImperativeGenerated_ThenCorrectImperativeEndingReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСенOrder.GetImperativeSenOrderEnding(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бол", "гула")]
    [InlineData("иште", "гиле")]
    [InlineData("бар", "гыла")]
    [InlineData("изилде", "гиле")]
    [InlineData("кел", "гиле")]
    [InlineData("ойно", "гула")]
    [InlineData("күт", "күлө")]
    [InlineData("тап", "кыла")]
    [InlineData("кир", "гиле")]
    [InlineData("өт", "күлө")]
    [InlineData("чакыр", "гыла")]
    [InlineData("текшер", "гиле")]
    [InlineData("отур", "гула")]
    [InlineData("үйрөт", "күлө")]
    public void GivenVerb_WhenSilerPoliteImperativeGenerated_ThenCorrectImperativeEndingReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСилер.GetImperativeSilerEnding(verb);

        // assert
        actualResult.Should().Be(expectedResult,verb);
    }
    
    [Theory]
    [InlineData("бол", "уңуз")]
    [InlineData("иште", "ңиз")]
    [InlineData("бар", "ыңыз")]
    [InlineData("изилде", "ңиз")]
    [InlineData("кел", "иңиз")]
    [InlineData("ойно", "ңуз")]
    [InlineData("күт", "үңүз")]
    [InlineData("тап", "ыңыз")]
    [InlineData("кир", "иңиз")]
    [InlineData("өт", "үңүз")]
    [InlineData("чакыр", "ыңыз")]
    [InlineData("текшер", "иңиз")]
    [InlineData("отур", "уңуз")]
    [InlineData("үйрөт", "үңүз")]
    public void GivenVerb_WhenSizImperativeGenerated_ThenCorrectImperativeEndingReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСиз.Generate(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    
    [Theory]
    [InlineData("бол", "уңуздар")]
    [InlineData("иште", "ңиздер")]
    [InlineData("бар", "ыңыздар")]
    [InlineData("изилде", "ңиздер")]
    [InlineData("кел", "иңиздер")]
    [InlineData("ойно", "ңуздар")]
    [InlineData("күт", "үңүздөр")]
    [InlineData("тап", "ыңыздар")]
    [InlineData("кир", "иңиздер")]
    [InlineData("өт", "үңүздөр")]
    [InlineData("чакыр", "ыңыздар")]
    [InlineData("текшер", "иңиздер")]
    [InlineData("отур", "уңуздар")]
    [InlineData("үйрөт", "үңүздөр")]
    public void GivenVerb_WhenSizderImperativeGenerated_ThenCorrectImperativeEndingReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСиздер.Generate(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бол", "сун")]
    [InlineData("иште", "син")]
    [InlineData("бар", "сын")]
    [InlineData("изилде", "син")]
    [InlineData("кел", "син")]
    [InlineData("ойно", "сун")]
    [InlineData("күт", "сүн")]
    [InlineData("тап", "сын")]
    [InlineData("кир", "син")]
    [InlineData("өт", "сүн")]
    [InlineData("чакыр", "сын")]
    [InlineData("текшер", "син")]
    [InlineData("отур", "сун")]
    [InlineData("үйрөт", "сүн")]
    public void GivenVerb_WhenAlImperativeGenerated_ThenCorrectImperativeEndingReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeАл.GetImperativeAlEnding(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бол", "ушсун")]
    [InlineData("иште", "шсин")]
    [InlineData("бар", "ышсын")]
    [InlineData("изилде", "шсин")]
    [InlineData("кел", "ишсин")]
    [InlineData("ойно", "шсун")]
    [InlineData("күт", "үшсүн")]
    [InlineData("тап", "ышсын")]
    [InlineData("кир", "ишсин")]
    [InlineData("өт", "үшсүн")]
    [InlineData("чакыр", "ышсын")]
    [InlineData("текшер", "ишсин")]
    [InlineData("отур", "ушсун")]
    [InlineData("үйрөт", "үшсүн")]
    public void GivenVerb_WhenAlarImperativeGenerated_ThenCorrectImperativeEndingReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeАлар.Generate(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}