using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace CheckTicketsBack.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(4, ErrorMessage = "The maximun length for field {0} is {1} characters, and minimun {2} characters.", MinimumLength = 4)]
        [Display(Name = "Ticket Code")]
        public string TicketCode { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Display(Name = "Date")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Display(Name = "User")]
        public int UserId { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }
    }
}