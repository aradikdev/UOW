namespace UOW.DAL.Entities;

public class Article : BaseEntity
{
    public string Title { get; set; } = null!;
    public string Fulltext { get; set; } = null!;
}
