using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DemoApp2.Entities
{
    /// <summary> 
    /// Represents a student entity with essential details
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Primary key for the Student 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the Student 
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}