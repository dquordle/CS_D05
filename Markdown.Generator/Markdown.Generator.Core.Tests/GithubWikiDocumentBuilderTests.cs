using System;
using System.Reflection;
using Markdown.Generator.Core.Documents;
using Markdown.Generator.Core.Markdown;
using Moq;
using Xunit;

public class GithubWikiDocumentBuilderTests
{
    [Fact]
    public void Given_MarkdownGenerator_When_TwoStringsAsLoadParameters_Then_SingleLoadCall()
    {
        string dllPath = "dllPath";
        string namespaceMatch = "namespaceMatch";
        string folder = "folder";
        Mock<IMarkdownGenerator> generator = new Mock<IMarkdownGenerator>();
        generator.Setup(mock => mock.Load(dllPath, namespaceMatch));
        GithubWikiDocumentBuilder<IMarkdownGenerator> gen = new GithubWikiDocumentBuilder<IMarkdownGenerator>(generator.Object);
        gen.Generate(dllPath, namespaceMatch, folder);
        generator.Verify(mock => mock.Load(dllPath, namespaceMatch), Times.Once);
    }
    [Fact]
    public void Given_MarkdownGenerator_When_AssembliesAndStringAsLoadParameters_Then_SingleLoadCall()
    {
        string namespaceMatch = "namespaceMatch";
        string folder = "folder";
        Assembly[] assemblies = new Assembly[0];
        Mock<IMarkdownGenerator> generator = new Mock<IMarkdownGenerator>();
        generator.Setup(mock => mock.Load(assemblies, namespaceMatch));
        GithubWikiDocumentBuilder<IMarkdownGenerator> gen = new GithubWikiDocumentBuilder<IMarkdownGenerator>(generator.Object);
        gen.Generate(assemblies, namespaceMatch, folder);
        generator.Verify(mock => mock.Load(assemblies, namespaceMatch), Times.Once);
    }
    [Fact]
    public void Given_MarkdownGenerator_When_TypesAsLoadParameter_Then_SingleLoadCall()
    {
        string folder = "folder";
        Type[] types = new Type[0];
        Mock<IMarkdownGenerator> generator = new Mock<IMarkdownGenerator>();
        generator.Setup(mock => mock.Load(types));
        GithubWikiDocumentBuilder<IMarkdownGenerator> gen = new GithubWikiDocumentBuilder<IMarkdownGenerator>(generator.Object);
        gen.Generate(types, folder);
        generator.Verify(mock => mock.Load(types), Times.Once);
    }
}