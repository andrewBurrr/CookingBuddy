using System;
using System.Reflection;
using CookingBuddy.Models;
namespace CookingBuddy.Services
{
    public class LessonService
    {
        private static readonly string[] Titles = new[]
        {
            "Braising", "Boiling and simmering", "Sauteing", "Cooking with steam", "Grilling", "Marinating", "Intro to Curing and Pickling", "Pan-Frying",
            "How to chop an onion", "Mastering basic knife skills", "How to knead dough", "Crushing garlic", "Staying safe in the kitchen", "How to rub flour and butter"
        };

        private static readonly string[] Authors = new[]
        {
           "Chef Alvin Chow", "Food Insider", "BBC Food", "Epicurious", "Joshua Wiseman", "BonApettit", "Babish Culinary Universe"
        };

        private static readonly string[] Ratings = new[]
        {
           "3.4","5.0","2.45" ,"1.9", "4.0", "3.8", "4.6"
        };

        private static readonly string[] Images = new[]
        {
          "https://assets.bonappetit.com/photos/57ae333553e63daf11a4e386/master/pass/vinegar-braised-chicken-and-onions.jpg",
          "https://i.pinimg.com/736x/02/71/32/027132444d7ea684141a1485b7e0ae8f--cooking-school-cooking-.jpg",
          "https://www.drweil.com/wp-content/uploads/2016/11/diet-nutrition_cooking-cookware_sauteing-for-our-health_1440x1080_000023128876.jpg",
          "https://www.tastingtable.com/img/gallery/mistakes-everyone-makes-when-steaming-food/intro-1642534914.jpg",
          "https://www.eehealth.org/-/media/images/modules/blog/posts/hdcancergrilling.jpg",
          "https://www.thespruceeats.com/thmb/FIOp3oOWgVeqvx7fFkJyFAj9ybs=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/GettyImages-936987836-5c8e89e646e0fb000146ad51.jpg",
          "https://static.cms.yp.ca/ecms/media/1/13927529_xxl-1444244987-600x360.jpg",
          "https://gbc-cdn-public-media.azureedge.net/img62533.jpg",
          "https://ichef.bbci.co.uk/images/ic/832xn/p075zb20.jpg",
          "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2015/12/17/0/FNM_010116-Cooking-School-Dice-04.jpg.rend.hgtvcom.616.462.suffix/1450382214160.jpeg",
          "https://images.immediate.co.uk/production/volatile/sites/30/2020/02/Kneading-bread-5b2c1df-scaled.jpg",
          "https://assets.epicurious.com/photos/5519aa9a6ec924e9311ce0c1/master/w_2106,h_1404,c_limit/EP-20150330-garlic-6x4-hires.jpg",
          "https://theruntime.com/wp-content/uploads/2022/05/kitchen-safety.jpg",
          "https://whatsarahbakes.com/wp-content/uploads/2018/01/2-rubbing-in-method-a.jpg"
        };

        private static readonly List<string>[] Instructions = new List<string>[]
        {
            new List<string>{ "prepare the ingredients for step 1", "mix the ingredients for step 2", "finish by doing the final step"},
            new List<string>{ "do a thing", "do a different thing", "do last thing"}
        };




        public Task<Lesson[]> GetLessonAsync()
        {
            return Task.FromResult(Enumerable.Range(0, Titles.Length).Select(index => new Lesson
            {
                // create your data
                Title = Titles[index],
                Author = Authors[Random.Shared.Next(Authors.Length)],
                Rating = Ratings[Random.Shared.Next(Ratings.Length)],
                Image = Images[index],
                Instructions = Instructions[Random.Shared.Next(Instructions.Length)]
            }).ToArray());
        }

        public Lesson GetSpecificLessonAsync(int index)
        {
            return new Lesson
            {
                Title = Titles[index],
                Author = Authors[Random.Shared.Next(Authors.Length)],
                Rating = Ratings[Random.Shared.Next(Ratings.Length)],
                Image = Images[index],
                Instructions = Instructions[Random.Shared.Next(Instructions.Length)]

            };
        

        }
    }
}

