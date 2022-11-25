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
        public Task<LessonModel[]> GetLessonAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new LessonModel
            {
                // create your data
                Title = Titles[Random.Shared.Next(Titles.Length)],
                Author = "",
                Rating = 0.0F,
                Image = "http://",
                Instructions = new List<string> { "do a thing", "do a different thing", "do last thing" }
            }).ToArray());
        }
    }
}

