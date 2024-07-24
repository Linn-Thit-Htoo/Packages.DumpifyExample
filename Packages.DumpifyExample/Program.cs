using Dumpify;
using Packages.DumpifyExample;
using System.Reflection.Metadata;

new { Name = "Dumpify", Description = "Dump any object to Console" }.Dump();

var blog = new BlogModel()
{
    BlogId = Guid.NewGuid().ToString(),
    BlogTitle = "Dumpify",
    BlogAuthor = "Dumpify",
    BlogContent = "Dumpify"
};

blog.Dump();

var lst = Enumerable.Range(1, 3).Select(x =>
{
    BlogModel blog = new BlogModel()
    {
        BlogId = Guid.NewGuid().ToString(),
        BlogTitle = "Test Title",
        BlogAuthor = "Test Author",
        BlogContent = "Test Content"
    };

    return blog;
});
lst.Dump();

Console.ReadKey();