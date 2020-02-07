using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PineBerry01.Models
{
    public class QnA
    {
        [Key]
        public int QnANo { get; set; }

        [Required]
        public string QusetionTitle { get; set; }

        [Required]
        public string QuestionContent { get; set; }

        [Required]
        public DateTime QuestionDate { get; set; }

        [Required]
        public int QnASubbjectName { get; set; }

        [ForeignKey("QnASubbjectName")]
        public virtual QnASubject QnASubject { get; set; }

        public string AnswerContent { get; set; }
    }
}
