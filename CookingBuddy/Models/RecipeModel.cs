using System;
using SQLite;

namespace CookingBuddy.Models
{
    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Author { get; set; }
        public string Rating { get; set; }
        public string Calories { get; set; }
        public string Title { get; set; }
        public string Media { get; set; }
        public string Difficulty { get; set; }
        public float Price { get; set; }
        public int Yield { get; set; }
        public int Time { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }

    public class Ingredient
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public int Quantity { get; set; }
    }

    public class Stage
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Order { get; set; }
        public int RecipeId { get; set; }
    }

    public class Step
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int StageId { get; set; }
        public int Order { get; set; }
        public string Content { get; set; }
    }
}

