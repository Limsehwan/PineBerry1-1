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
        public int NoticeNo { get; set; }  //게시글 번호 

        [Required]
        public string NoticeTitle { get; set; }  //게시글 제목

        [Required]
        public string NoticeContent { get; set; }  //게시글 상세 내용
    }
}
