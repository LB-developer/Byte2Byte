using Byte2Byte.Data;
using Byte2Byte.Models;

namespace Byte2Byte.Services;

public class LoopsService
{
    private readonly ByteDbContext _dbContext;

    public LoopsService(ByteDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddToDatabase()
    {
        Console.WriteLine("Executing AddToDatabase");
        var item = new ComparisonModel()
        {
            Type = "Loop",
            Snippets =
            [
                new ContentModel()
                {
                    Type = "Loop",
                    Language = "Python",
                    Content = "print(\"Hello\")"
                }
            ]
        };

         _dbContext.Comparisons.Add(item);
         _dbContext.SaveChanges();
    }
}