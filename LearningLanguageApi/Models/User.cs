using System;
using System.Collections.Generic;

namespace LearningLanguageApp.Models
{

    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string JwtToken { get; set; }
        public string Avatar { get; set; }
        public string SubscriptionType { get; set; }
        public DateTime Timestamp { get; set; } //Timestamp for record creation/update

        // Navigation properties
        // public ICollection<Set> Sets { get; set; } // 1:Many relationship with Sets
        // public ICollection<Game> Games { get; set; } // 1:Many relationship with Games
    }

}

