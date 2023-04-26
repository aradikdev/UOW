using System.ComponentModel.DataAnnotations;

namespace UOW.DAL.Entities;

public class Order : BaseEntity
{
    public string Number { get; set; } = null!;
    public Guid BookId { get; set; }
    public virtual Book? Book { get; set; }
}
