using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionSite.Models
{
    [Table("Mission")]
    public class Mission
    {
        [Key]
        public int MissionId { get; set; }
        public string MissionName { get; set; }
        public string MissionPresident { get; set; }
        public string MissionAddress { get; set; }
        public string MissionPrimaryLanguage { get; set; }
        public string MissionClimate { get; set; }
        public string MissionDominantReligion { get; set; }
        public string MissionFlagURL { get; set; }
    }
}