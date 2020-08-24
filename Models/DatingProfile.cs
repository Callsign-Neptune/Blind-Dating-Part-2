using System;
using System.Collections.Generic;

namespace BlindDating.Models
{
    public partial class DatingProfile
    {
        public DatingProfile()
        {
            MailMessagesFromProfile = new HashSet<MailMessages>();
            MailMessagesToProfile = new HashSet<MailMessages>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Bio { get; set; }
        public string UserAccountId { get; set; }
        public string DisplayName { get; set; }
        public string PhotoPath { get; set; }

        public ICollection<MailMessages> MailMessagesFromProfile { get; set; }
        public ICollection<MailMessages> MailMessagesToProfile { get; set; }
    }
}
