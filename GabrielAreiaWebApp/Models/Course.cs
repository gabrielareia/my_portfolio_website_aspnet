using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GabrielAreiaAPI.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public string Institution { get; set; }
        public string Subject { get; set; }
        public int YearStart { get; set; }
        public int YearEnd { get; set; }
        public string Description { get; set; }
        public string CertificateImageAddress { get; set; }
        public string CertificateAddress { get; set; }
        public string LogoAddress { get; set; }
        public string InstitutionWebsite { get; set; }
    }
}
