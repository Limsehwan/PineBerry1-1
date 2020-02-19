using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PineBerry01.Models
{
    public class Berries
    {
        [Key]
        public int BerryNo { get; set; }

        [Required]
        public string BerryTitle { get; set; }
        
        [Required]
        public string BerryContent { get; set; }

        [Required]
        public string BerrySubjectName { get; set; }

        [ForeignKey("BerrySubjectName")]
        public virtual BerrySubject berrySubject { get; set; }
    }
}
