using System;
using Markdown.Generator.Core.Markdown.Elements;
using Xunit;

public class ElementsTests
{
    [Fact]
    public void Given_Code_When_LanguageAndCodeAsParameter_Then_ReturnMarkdownCodeMarkup()
    {
        string expected = "```csharp\nsome code\n```\n";
        Code code = new Code("csharp", "some code");
        string actual = code.Create();
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Given_CodeQuote_When_LanguageAndCodeAsParameter_Then_ReturnMarkdownCodeMarkup()
    {
        string expected = "```code```";
        CodeQuote codeQuote = new CodeQuote("code");
        string actual = codeQuote.Create();
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Given_Header_When_LanguageAndCodeAsParameter_Then_ReturnMarkdownCodeMarkup()
    {
        string expected = "## header\n";
        Header header = new Header(3, "header");
        string actual = header.Create();
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Given_List_When_LanguageAndCodeAsParameter_Then_ReturnMarkdownCodeMarkup()
    {
        string expected = "- list\n";
        List list = new List("list");
        string actual = list.Create();
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Given_Link_When_LanguageAndCodeAsParameter_Then_ReturnMarkdownCodeMarkup()
    {
        string expected = "[title](url)";
        Link link = new Link("title", "url");
        string actual = link.Create();
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Given_Image_When_LanguageAndCodeAsParameter_Then_ReturnMarkdownCodeMarkup()
    {
        string expected = "![title](url)";
        Image image = new Image("title", "url");
        string actual = image.Create();
        Assert.Equal(expected, actual);
    }
}