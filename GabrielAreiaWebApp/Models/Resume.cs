using System;

namespace GabrielAreiaAPI.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string Language { get; set; }
        public string FullName { get; set; }
        public int YearBirth { get; set; }
        public int DynamicAge
        {
            get
            {
                return DateTime.Now.Year - YearBirth;
            }
        }
        public string PictureAddress { get; set; }
        private string _description;
        public string Description
        {
            get
            {
                return _description.Replace("{age}", DynamicAge.ToString());
            }
            set
            {
                _description = value;
            }
        }
        public ContactInfo Contact { get; set; }
        public string[] Goals { get; set; }
        public Course[] Courses { get; set; }
        public Ability[] Abilities { get; set; }
        public Achievement[] Achievements { get; set; }
        public Experience[] Experiences { get; set; }
    }

}
