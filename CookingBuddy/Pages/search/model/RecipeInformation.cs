using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingBuddy.Pages.search.model
{
    public class RecipeInformation
    {
        public string author;
        public string title;
        public string rating;
        public string calories;
        public string time;
        public string difficulty;
        public string price;

        public RecipeInformation(string author, string title, string rating, string calories, string time, string difficulty, string price) 
        {
            this.author = author;
            this.title = title;
            this.rating = rating;
            this.calories = calories;
            this.time = time;
            this.difficulty = difficulty;
            this.price = price;
        }
    }
}
