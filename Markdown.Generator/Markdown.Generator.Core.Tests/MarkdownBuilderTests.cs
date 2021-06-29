using Markdown.Generator.Core.Markdown;
using Markdown.Generator.Core.Markdown.Elements;
using Xunit;
using Enumerable = System.Linq.Enumerable;

public class MarkdownBuilderTests
{
    [Fact]
    public void Given_Builder_When_CallingCodeMethod_Then_ReturnSingleCodeElement()
    {
        MarkdownBuilder builder = new MarkdownBuilder();
        string someCode = "some code";
        string language = "csharp";
        Code code = new Code(someCode, language);
        string expected = code.Create();
        builder.Code(someCode, language);
        Assert.Single(builder.Elements);
        Assert.Equal(expected, builder.ToString());
        // Assert.Contains(code, builder.Elements);
    }
    [Fact]
    public void Given_Builder_When_CallingCodeQuoteMethod_Then_ReturnSingleCodeQuoteElement()
    {
        MarkdownBuilder builder = new MarkdownBuilder();
        string someCode = "some code";
        CodeQuote codeQuote = new CodeQuote(someCode);
        string expected = codeQuote.Create();
        builder.CodeQuote(someCode);
        Assert.Single(builder.Elements);
        Assert.Equal(expected, builder.ToString());
    }
    [Fact]
    public void Given_Builder_When_CallingLinkMethod_Then_ReturnSingleLinkElement()
    {
        MarkdownBuilder builder = new MarkdownBuilder();
        string text = "text";
        string url = "url";
        Link link = new Link(text, url);
        string expected = link.Create();
        builder.Link(text, url);
        Assert.Single(builder.Elements);
        Assert.Equal(expected, builder.ToString());
    }
    [Fact]
    public void Given_Builder_When_CallingHeaderMethod_Then_ReturnSingleHeaderElement()
    {
        MarkdownBuilder builder = new MarkdownBuilder();
        string text = "text";
        Header header = new Header(3, text);
        string expected = header.Create();
        builder.Header(3, text);
        Assert.Single(builder.Elements);
        Assert.Equal(expected, builder.ToString());
    }
}
