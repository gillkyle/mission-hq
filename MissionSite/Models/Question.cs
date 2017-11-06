using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionSite.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public int MissionId { get; set; }
        public String QuestionDescription { get; set; }
        public DateTime QuestionDate{ get; set; }
        public String QuestionAuthor{ get; set; }
    }
}