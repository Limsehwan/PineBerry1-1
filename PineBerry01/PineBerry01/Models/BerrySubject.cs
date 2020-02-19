using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PineBerry01.Models
{
    public class BerrySubject
    {
        [Key]
        public string BerrySubjectName { get; set; } 
    }
}
