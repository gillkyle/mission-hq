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

        [ForeignKey("Mission")]
        public int MissionId { get; set; }
        public virtual Mission Mission { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public String QuestionDescription { get; set; }
        public DateTime QuestionDate{ get; set; }
    }
}