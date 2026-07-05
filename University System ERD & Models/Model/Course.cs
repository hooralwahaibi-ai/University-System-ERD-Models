using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversitySystemERDModels.model
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; } // System generated

        [Required]
        [MaxLength(10)]
        public string courseCode { get; set; } = string.Empty; // User input - unique in database

        [Required]
        [MaxLength(150)]
        public string courseTitle { get; set; } = string.Empty; // User input

        [Required]
        [Range(1, 6)]
        public int creditHours { get; set; } // User input

        [Required]
        [ForeignKey("department")]
        public int departmentId { get; set; } // Foreign key

        [InverseProperty("courses")]
        public Department department { get; set; } = null!; // Navigation property

        [ForeignKey("instructor")]
        public int? instructorId { get; set; } // Foreign key - nullable

        [InverseProperty("courses")]
        public Instructor? instructor { get; set; } // Navigation property

        [Required]
        [MaxLength(20)]
        public string semesterOffered { get; set; } = string.Empty; // From list

        [InverseProperty("course")]
        public ICollection<Enrollment> enrollments { get; set; } = new List<Enrollment>(); // Navigation property
    }
}
