using Learnify.Domain.Common;
using System.Text.RegularExpressions;

namespace Learnify.Domain.Entities;

public class Course : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int DurationMonths { get; set; }
    public string Description { get; set; }
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }
}
