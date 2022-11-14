using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingBuddy.Pages.ViewRecipe.model
{

    public class RecipeBodyModel
    {
        public string author;
        public string diffculty;
        public string rating;
        public string time;
        public string nutrition;
        public string description;
        public string tools;
        public string ingredients;
        public string price;
        public string yield;

        public RecipeBodyModel(string author, string diffculty, string rating, string time, string nutrition, string description, string tools, string ingredients, string price, string yield)
        {
            this.author = author;
            this.diffculty = diffculty;
            this.rating = rating;
            this.time = time;
            this.nutrition = nutrition;
            this.description = description;
            this.tools = tools;
            this.ingredients = ingredients;
            this.price = price;
            this.yield = yield;
        }
    }
}
