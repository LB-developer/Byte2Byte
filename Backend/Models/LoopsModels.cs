using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Byte2Byte.Models;

public class ContentModel
{
   [BsonId]
   public ObjectId Id { get; set; }
   
   [BsonElement("type")]
   public required string Type { get; set; }
   [BsonElement("language")]
   public required string Language { get; set; }
   [BsonElement("content")]
   public required string Content { get; set; }
   [BsonElement("explanation")]
   public string? Explanation { get; set; }
}

public class ComparisonModel
{
   [BsonId]
   public ObjectId Id { get; set; }
   [BsonElement("type")]
   public required string Type { get; set; }
   [BsonElement("snippets")]
   public List<ContentModel> Snippets { get; set; } = new();
}