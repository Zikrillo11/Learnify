using DocumentFormat.OpenXml.Drawing.Diagrams;
using Learnify.Domain.Common;
using Learnify.Domain.Entities;

public class Course : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }

    public long CategoryId { get; set; }       
    public Category Category { get; set; }

    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
