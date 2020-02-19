using System;
using System.ComponentModel.DataAnnotations;

namespace PineBerry01.Models
{
    public class Calendar
    {
        [Key]
        public int CalendarNo { get; set; }                  


        [Required]
        public string CalendarTitle { get; set; }

        [Required]
        public string CalendarContent { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CalendarDate { get; set; }
    }
}
