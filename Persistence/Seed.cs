using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Events.Any()) return;

            var activities = new List<Event>
            {
                new Event
                {
                    Title = "Past Event 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    Street = "22 Mayfair",
                    City = "London",
                    State = "",
                    Zip = "",
                    Venue = "Pub",
                },
                new Event
                {
                    Title = "Past Event 2",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    Street = "",
                    City = "Paris",
                    State = "",
                    Zip = "",
                    Venue = "Louvre",
                },
                new Event
                {
                    Title = "Future Event 1",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Activity 1 month in future",
                    Category = "culture",
                    Street = "",
                    City = "London",
                    State = "",
                    Zip = "",
                    Venue = "Natural History Museum",
                },
                new Event
                {
                    Title = "Future Event 2",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "music",
                    Street = "",
                    City = "London",
                    State = "",
                    Zip = "",
                    Venue = "O2 Arena",
                },
                new Event
                {
                    Title = "Future Event 3",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Activity 3 months in future",
                    Category = "drinks",
                    Street = "",
                    City = "London",
                    State = "",
                    Zip = "",
                    Venue = "Another pub",
                },
                new Event
                {
                    Title = "Future Event 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Activity 4 months in future",
                    Category = "drinks",
                    Street = "",
                    City = "London",
                    State = "",
                    Zip = "",
                    Venue = "Yet another pub",
                },
                new Event
                {
                    Title = "Future Event 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Activity 5 months in future",
                    Category = "drinks",
                    Street = "",
                    City = "London",
                    State = "",
                    Zip = "",
                    Venue = "Just another pub",
                },
                new Event
                {
                    Title = "Future Event 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Activity 6 months in future",
                    Category = "music",
                    Street = "",
                    City = "London",
                    State = "",
                    Zip = "",
                    Venue = "Roundhouse Camden",
                },
                new Event
                {
                    Title = "Future Event 7",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Activity 2 months ago",
                    Category = "travel",
                    Street = "",
                    City = "London",
                    State = "",
                    Zip = "",
                    Venue = "Somewhere on the Thames",
                },
                new Event
                {
                    Title = "Future Event 8",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Activity 8 months in future",
                    Category = "film",
                    Street = "",
                    City = "London",
                    State = "",
                    Zip = "",
                    Venue = "Cinema",
                }
            };

            await context.Events.AddRangeAsync(activities); // Saves the changes into memory
            await context.SaveChangesAsync(); // Commits the changes to the db
        }
    }
}