using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [ForeignKey("Questions")]
        public int QuestionId { get; set; }
        public virtual Question Questions { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required, DisplayName("Response"), StringLength(750, MinimumLength = 3, ErrorMessage = "Response must be between 3 and 750 characters long."),
            RegularExpression(@"^[A-Z].*$", ErrorMessage = "Capitalize response")]
        public String ResponseDescription { get; set; }
    }
}