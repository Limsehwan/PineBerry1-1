using System;
using System.ComponentModel.DataAnnotations;

namespace PineBerry01.Models
{
    public class BerrySuggest
    {
        [Key]
        public int BerrySuggestKey { get; set; }

        [Required]
        public string SuggestTitle { get; set; }

        [Required]
        public string SuggestContent { get; set; }

        [Required]
        public DateTime SuggestDate { get; set; }
    }
}
