using DocumentFormat.OpenXml.Drawing.Diagrams;
using Learnify.Domain.Common;
using Learnify.Domain.Entities;

public class Course : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; } = null!;

    public long CategoryId { get; set; }         // Category foreign key
    public Category Category { get; set; } = null!; // Category navigation property

    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
