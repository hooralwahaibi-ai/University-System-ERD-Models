using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace University_System_ERD___Models.model
{
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instructorId { get; set; } // System generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; } = string.Empty; // User input

        [Required]
        [MaxLength(150)]
        public string email { get; set; } = string.Empty; // User input (unique in database)

        [MaxLength(20)]
        public string? officeNumber { get; set; } // User input (optional)

        [Required]
        public DateTime hireDate { get; set; } // User input

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Salary must be greater than 0")]
        public decimal salary { get; set; } // User input

        [Required]
        [MaxLength(50)]
        public string academicTitle { get; set; } = string.Empty; // From list
    }
}
