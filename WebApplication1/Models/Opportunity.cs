using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Opportunity
    {
        

        public int OpportunityID { get; set; }
        public string Name { get; set; }
        public string Professor { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Mentor { get; set; }
        public DateTime Begin_date { get; set; }
        public DateTime End_date { get; set; }
        public int Pay { get; set; }
        public bool Filled { get; set; }
        public string Required_skills { get; set; }
        public string Search_tags { get; set; }

    }
}
