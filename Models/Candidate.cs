using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="e-mail gir")]
        public string? Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "isim gir")]
        public string? FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "soyisim gir")]
        public string? LastName { get; set; } = string.Empty;

        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        
        public int? Age { get; set; }

        public string? SelectedCourse { get; set; } = string.Empty;

        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }

    }

}