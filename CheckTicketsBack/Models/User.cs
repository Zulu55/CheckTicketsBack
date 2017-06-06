using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CheckTicketsBack.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The maximun length for field {0} is {1} characters.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The maximun length for field {0} is {1} characters.")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(100, ErrorMessage = "The maximun length for field {0} is {1} characters.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [JsonIgnore]
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(20, ErrorMessage = "The maximun length for field {0} is {1} characters, and minimun {2} characters.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [JsonIgnore]
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(20, ErrorMessage = "The maximun length for field {0} is {1} characters, and minimun {2} characters.", MinimumLength = 4)]
        [Compare("Password", ErrorMessage = "The password and confirms does not match.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "User")]
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        [JsonIgnore]
        public virtual ICollection<User> Users { get; set; }
    }
}