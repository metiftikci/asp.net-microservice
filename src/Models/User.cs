using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuthMicroservice.Models;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public int Age { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
}
