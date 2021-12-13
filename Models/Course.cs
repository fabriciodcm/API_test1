using System.ComponentModel.DataAnnotations;

namespace API_test1.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        [MaxLength(100)]
        public string CourseName { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        
        [MaxLength(255)]
        public string Syllabus { get; set; }
    }
}
