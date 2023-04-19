using System;
namespace MediatRDemo.Data.Entities
{
    public class Movie
    {
        public required Guid Id { get; set; }
        public required string Title { get; set; }
        public string Slung => GenerateSlung();
        public required int YearOfRelease { get; set; }

        public string GenerateSlung()
        {
            return Title.ToLower() + "xxxxxx";
        }
    }
}

