using System;
using System.Collections.Generic;

namespace LearningLanguageApp.Models

{
    public class Set {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Visibility { get; set; }
        public string Language1 { get; set; }
        public string Language2 { get; set; }
        public string Difficulty { get; set; }
        public List <string> Questions { get; set; }
        public string DateCreated { get; set; }
        public List<string> Tags { get; set; }
        public List<string> Games { get; set; }
    }
}





// Name

	// Visibility (public, private)

	// Language1

	// Language2

	// Difficulty

	// Questions

	// Date Created

	// Tags (theme, for example)

	// 1:many games



