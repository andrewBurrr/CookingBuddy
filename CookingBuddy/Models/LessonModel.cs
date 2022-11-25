using System;

namespace CookingBuddy.Models
{
    public class LessonModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public float Rating { get; set; }
        public string Image { get; set; }
        public List<string> Instructions { get; set; }
    }
}

