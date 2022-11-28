using System;
using SQLite;
namespace CookingBuddy.Models
{
    public class Review
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public float Rating { get; set; }
        public string Content { get; set; }
    }
}

