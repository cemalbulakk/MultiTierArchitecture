namespace Core.Entities;

public abstract class BaseEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}