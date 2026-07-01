using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace University_System_ERD___Models.model
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId { get; set; } // System generated

        [Required]
        [ForeignKey("student")]
        public int studentId { get; set; } // Foreign key

        [InverseProperty("enrollments")]
        public Student student { get; set; } = null!; // Navigation property

        [Required]
        [ForeignKey("course")]
        public int courseId { get; set; } // Foreign key

        [Required]
        public DateTime enrollmentDate { get; set; } // System generated

        [MaxLength(2)]
        public string? finalGrade { get; set; } // From list - optional until graded

        [Required]
        [MaxLength(20)]
        public string status { get; set; } = "In Progress"; // Default value
    }
}
