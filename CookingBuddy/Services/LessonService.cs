using System;
using CookingBuddy.Models;
namespace CookingBuddy.Services
{
    public class LessonService
    {
        private static readonly string[] Titles = new[]
        {
            "sample title", "other sample"
        };
        private static readonly string[] Authors = new[]
        {
            "John Doe", "Jane Doe", "Jack Doe", "John Smith"
        };
        private static readonly string[] Ratings = new[]
        {
            "3.1", "1.2", "4.6", "5.0"
        };
        private static readonly string[] Images = new[]
        {
            "https://res.cloudinary.com/bunch-media-library/image/upload/v1575061943/articles/ro9zhhmrewviaw0ewooo.jpg", "https://i.ytimg.com/vi/ISGbUMaDC7w/hqdefault.jpg"
        };
        private static readonly List<string>[] Instructions = new List<string>[]
        {
            new List<string>{ "prepare the ingredients for step 1", "mix the ingredients for step 2", "finish by doing the final step"},
            new List<string>{ "do a thing", "do a different thing", "do last thing"}
        };
        public Task<Lesson[]> GetLessonAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Lesson
            {
                // create your data
                Title = Titles[Random.Shared.Next(Titles.Length)],
                Author = Authors[Random.Shared.Next(Authors.Length)],
                Rating = Ratings[Random.Shared.Next(Ratings.Length)],
                Image = Images[Random.Shared.Next(Images.Length)],
                Instructions = Instructions[Random.Shared.Next(Instructions.Length)]
            }).ToArray());
        }
    }
}

