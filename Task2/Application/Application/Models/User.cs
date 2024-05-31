using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Full name is required.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Full name should contain only letters.")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }
    }
}