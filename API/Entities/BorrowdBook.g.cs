using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DemoApp2.Entities
{
    /// <summary> 
    /// Represents a borrowdbook entity with essential details
    /// </summary>
    public class BorrowdBook
    {
        /// <summary>
        /// Primary key for the BorrowdBook 
        /// </summary>
        [Key]
        public int? Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Student to which the BorrowdBook belongs 
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Student
        /// </summary>
        [ForeignKey("UserId")]
        public Student? UserId_Student { get; set; }

        /// <summary>
        /// Foreign key referencing the Books to which the BorrowdBook belongs 
        /// </summary>
        [Required]
        public Guid BookId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Books
        /// </summary>
        [ForeignKey("BookId")]
        public Books? BookId_Books { get; set; }

        /// <summary>
        /// Required field BorrowDate of the BorrowdBook 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime BorrowDate { get; set; }

        /// <summary>
        /// Required field ReturnDate of the BorrowdBook 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ReturnDate { get; set; }

        /// <summary>
        /// Required field Returned of the BorrowdBook 
        /// </summary>
        [Required]
        public Guid Returned { get; set; }
        /// <summary>
        /// FineAmount of the BorrowdBook 
        /// </summary>
        public int? FineAmount { get; set; }
    }
}