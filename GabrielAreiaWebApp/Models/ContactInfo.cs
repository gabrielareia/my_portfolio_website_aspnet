using System.Collections.Generic;

namespace GabrielAreiaAPI.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string Skype { get; set; }
        public string Discord { get; set; }
        public string[] EmailAddresses { get; set; }
        public string[] Cellphones { get; set; }
        public string[] Websites { get; set; }
    }

}
