using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingBuddy.Pages.ViewRecipe.model
{
    public class RecipeTitleBarModel
    {
        public string imagesrc;
        public string title;

        public RecipeTitleBarModel(string imagesrc, string title)
        {
            this.imagesrc = imagesrc;
            this.title = title;
        }
    }
}
