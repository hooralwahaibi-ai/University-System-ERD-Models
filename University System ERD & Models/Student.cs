using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace University_System_ERD___Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; } // System generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; } = string.Empty; // User input

        [Required]
        [MaxLength(150)]
        public string email { get; set; } = string.Empty; // User input - unique in database

        [MaxLength(20)]
        public string? phoneNumber { get; set; } // User input - optional

        [Required]
        public DateTime dateOfBirth { get; set; } // User input

        [Required]
        [Range(2000, 2030)]
        public int enrollmentYear { get; set; } // User input

        [Column(TypeName = "decimal(3,2)")]
        [Range(0.0, 4.0)]
        public decimal gpa { get; set; } = 0.0m; // Default value

        public ICollection<Enrollment> enrollments { get; set; } = new List<Enrollment>(); // Navigation property

    }
}
