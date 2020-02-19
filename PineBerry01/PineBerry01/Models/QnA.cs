using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PineBerry01.Models
{
    public class QnA
    {
        [Key]
        public int QnANo { get; set; } //질문 번호

        [Required]
        public string QusetionTitle { get; set; } //질문 제목

        [Required]
        public string QuestionContent { get; set; }  //질문 상세 내용

        [Required]
        [DataType(DataType.Date)]
        public DateTime QuestionDate { get; set; }  //질문한 날짜         

        public string AnswerTitle { get; set; }

        public string AnswerContext { get; set; }
    }
}
