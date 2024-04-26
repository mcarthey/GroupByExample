using GroupByExample.Models;

namespace GroupByExample
{
    public class Context : IDisposable
    {
        public List<Restaurant> Restaurants { get; set; }
        public List<Review> Reviews { get; set; }

        public Context()
        {
            Restaurants = new List<Restaurant>()
            {
                new Restaurant() { Id = 1, Name = "Burger Barn", Location = "New York"},
                new Restaurant() { Id = 2, Name = "Pizza Palace", Location = "Chicago"},
                new Restaurant() { Id = 3, Name = "Sushi Haven", Location = "Los Angeles"},
                new Restaurant() { Id = 4, Name = "Taco Truck", Location = "Houston"}
            };

            Reviews = new List<Review>()
            {
                new Review { Id = 1, RestaurantId = 1, Reviewer = "John", Rating = 5, Comment = "Great burgers!" },
                new Review { Id = 2, RestaurantId = 1, Reviewer = "Jane", Rating = 4, Comment = "Good service" },
                new Review { Id = 3, RestaurantId = 2, Reviewer = "Bob", Rating = 3, Comment = "Decent pizza" },
                new Review { Id = 4, RestaurantId = 3, Reviewer = "Alice", Rating = 5, Comment = "Best sushi ever!" },
                new Review { Id = 5, RestaurantId = 1, Reviewer = "Mike", Rating = 4, Comment = "Friendly staff" },
                new Review { Id = 6, RestaurantId = 2, Reviewer = "Emily", Rating = 4, Comment = "Good food" },
                new Review { Id = 7, RestaurantId = 3, Reviewer = "David", Rating = 5, Comment = "Excellent service" },
                new Review { Id = 8, RestaurantId = 4, Reviewer = "Joe", Rating = 5, Comment = "Excellent service" },
                new Review { Id = 9, RestaurantId = 4, Reviewer = "Trevor", Rating = 5, Comment = "Excellent service" },
                new Review { Id = 10, RestaurantId = 4, Reviewer = "Mark", Rating = 5, Comment = "Excellent service" }
            };
        }

        public void Dispose()
        {
            Restaurants = new List<Restaurant>();
            Reviews = new List<Review>();
        }
    }
}
