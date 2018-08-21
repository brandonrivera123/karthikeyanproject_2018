using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace VolunteerOpportunities.Models
{
    public class Opportunity
    {
        [Key]
        public int OID { get; set; }
        public string OName { get; set; }
        public string OStreetAddress { get; set; }
        public string OState { get; set; }
        public string OZipCode { get; set; }
        public string OSkill { get; set; }
        public string OTimes { get; set; }
        public bool OCollege { get; set; }
    }

    public class ODBContext : DbContext
    {
        public ODBContext() { }
        public DbSet<Opportunity> Opportunities { get; set; }
    }
}