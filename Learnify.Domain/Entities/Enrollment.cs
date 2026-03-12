using System.ComponentModel.DataAnnotations.Schema;

namespace Learnify.Domain.Entities
{
    public class Enrollment
    {
        public long Id { get; set; }

        // Student
        public long StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public User Student { get; set; }

        // Course
        public long CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; }

        public DateTime EnrolledAt { get; set; } = DateTime.UtcNow;
    }
}