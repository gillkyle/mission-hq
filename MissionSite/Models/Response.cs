using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionSite.Models
{
    [Table("Response")]
    public class Response
    {
        [Key]
        public int ResponseId { get; set; }
        public int QuestionId { get; set; }
        public String ResponseDescription { get; set; }
        public String ResponseAuthor { get; set; }
        public DateTime ResponseDate { get; set; }
    }
}