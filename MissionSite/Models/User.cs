using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionSite.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public String UserEmail { get; set; }
        public String UserPassword { get; set; }
        public String UserFirstName { get; set; }
        public String UserLastName { get; set; }
    }
}