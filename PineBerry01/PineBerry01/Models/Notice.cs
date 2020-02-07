using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PineBerry01.Models
{
    public class Notice
    {
        [Key]
        public int NoticeNo { get; set; }

        [Required]
        public string NoticeTitle { get; set; }

        [Required]
        public string NoticeContent { get; set; }
    }
}
