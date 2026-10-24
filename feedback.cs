using System.ComponentModel.DataAnnotations;

namespace FeedbackManagement.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter valid email")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5, ErrorMessage = "Select rating from 1 to 5")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        [StringLength(200, MinimumLength = 5,
            ErrorMessage = "Comments must be 5 to 200 characters")]
        public string Comments { get; set; } = "";
    }
}