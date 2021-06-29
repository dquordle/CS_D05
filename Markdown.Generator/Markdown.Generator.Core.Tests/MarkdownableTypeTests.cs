using Markdown.Generator.Core.Markdown;
using Markdown.Generator.Core.Markdown.Elements;
using Xunit;

public class Sut
{
    public void PublicMethod(){ }
    private void PrivateMethod(){ }

    public string PublicField;
    private string PrivateField;
    
    public string PublicProperty { get; set; }
    private string PrivateProperty { get; set; }
}

public class MarkdownableTypeTests
{
    [Fact]
    public void Given_GetMethods_When_SutAsParameter_Then_ReturnSinglePublicMethod()
    {
        MarkdownableType markdownableType = new MarkdownableType(typeof(Sut), null);
        Assert.Single(markdownableType.GetMethods());
        Assert.False(markdownableType.GetMethods()[0].IsPrivate);
    }
    [Fact]
    public void Given_GetFields_When_SutAsParameter_Then_ReturnSinglePublicField()
    {
        MarkdownableType markdownableType = new MarkdownableType(typeof(Sut), null);
        Assert.Single(markdownableType.GetFields());
        Assert.False(markdownableType.GetFields()[0].IsPrivate);
    }
    [Fact]
    public void Given_GetProperties_When_SutAsParameter_Then_ReturnSinglePublicProperty()
    {
        MarkdownableType markdownableType = new MarkdownableType(typeof(Sut), null);
        Assert.Single(markdownableType.GetProperties());
        Assert.Equal("PublicProperty", markdownableType.GetProperties()[0].Name);
    }
}
