using System.ComponentModel.DataAnnotations;

namespace Basic_crud.Models
{
    public class Student
    {
        // add our properties that correspond to column in table

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = "";

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Format")]
        [StringLength(40)]
        public string Email { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string Course { get; set; } = "";

        [Required]
        [Range(0.01, 1000.0)]
        public double Price { get; set; }

        [Required]
        public DateTime BegDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;



    }
}
