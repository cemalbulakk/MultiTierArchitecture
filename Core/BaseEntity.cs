namespace Core;

public abstract class BaseEntity
{
    protected BaseEntity()
    {
        UpdatedDate = DateTime.Now;
        Id = Guid.NewGuid().ToString("N");
    }

    public string Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}