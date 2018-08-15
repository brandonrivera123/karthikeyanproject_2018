using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcVolunteer.Models
{
    public class Welcome
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Locations { get; set; }
        public string Skill_Int { get; set; }
        public string Availability { get; set; }
        public string Address { get; set; }
        public string HomeNumber { get; set; }
        public string WorkNumber { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public string Licenses { get; set; }
        public string EmergName { get; set; }
        public string EmergNumber { get; set; }
        public string EmergEmail { get; set; }
        public string EmergAddress { get; set; }
        public bool DriversFile { get; set; }
        public bool SSNFile { get; set; }
        public bool Approved { get; set; }
        public bool Active { get; set; }
    }

    public class VolunteerDBContext : DbContext
    {
        public DbSet<Volunteer> Volunteers { get; set; }
    }
}