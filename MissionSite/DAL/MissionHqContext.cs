using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MissionSite.Models;
using System.Data.Entity;

namespace MissionSite.DAL
{
    public class MissionHqContext : DbContext
    {
        public MissionHqContext() : base("MissionHqContext")
        {

        }

        public DbSet<Mission> Missions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Response> Responses { get; set; }
    }
}