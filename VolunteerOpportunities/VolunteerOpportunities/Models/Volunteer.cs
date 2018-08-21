using System;
using System.Data.Entity;

namespace VolunteerOpportunities.Models
{
    public class Volunteer
    {
        public int ID { get; set; }

        public string FName { get; set; }
        public string LName { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public string VolunteerLocation { get; set; }
        public string Skills { get; set; }
        public string Availability { get; set; }

        public string Address { get; set; }
        public string HomeNumber { get; set; }
        public string CellNumber { get; set; }
        public string WorkNumber { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public string Licenses { get; set; }

        public string EmergnecyName { get; set; }
        public string EmergencyNumber { get; set; }
        public string EmergencyEmail { get; set; }
        public string EmergencyAddress { get; set; }

        public bool DLFile { get; set; }
        public bool SSNFile { get; set; }
        public string ApprovalStatus { get; set; }
    }

    public class VolunteerDBContext : DbContext
    {
        public DbSet<Volunteer> Volunteers { get; set; }
    }

}