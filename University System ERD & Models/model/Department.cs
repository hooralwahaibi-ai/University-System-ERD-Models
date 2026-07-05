using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversitySystemERDModels.model
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int departmentId { get; set; } // System generated

        [Required]
        [MaxLength(100)]
        public string departmentName { get; set; } = string.Empty; // User input - unique in database

        [MaxLength(50)]
        public string? building { get; set; } // User input - optional

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.0, double.MaxValue, ErrorMessage = "Budget must be greater than or equal to 0")]
        public decimal budget { get; set; } // User input

        [ForeignKey("headInstructor")]
        public int? headInstructorId { get; set; } // Foreign key - nullable

        [InverseProperty("headedDepartment")]
        public Instructor? headInstructor { get; set; } // Navigation property: department head

        [InverseProperty("department")]
        public ICollection<Course> courses { get; set; } = new List<Course>(); // Navigation property
    }
}
