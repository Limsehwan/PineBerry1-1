using System.ComponentModel.DataAnnotations;

namespace PineBerry01.Models
{
    public class User
    {
        [Key]
        public int UserNo { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string UserPw { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
