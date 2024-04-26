namespace GroupByExample
{
    public class GroupByExample
    {
        public static void Main()
        {
            using (var db = new Context())
            {
                // -------------------------------------------------
                Console.WriteLine("Restaurant Reviews");

                var reviews = db.Reviews;
                foreach (var review in reviews)
                {
                    var restaurant = db.Restaurants.First(x => x.Id == review.RestaurantId);
                    Console.WriteLine($"Restaurant: {restaurant.Name}, Review: {review.Rating}");
                }

                // -------------------------------------------------
                Console.WriteLine();
                Console.WriteLine("Restaurant Average Ratings");

                var averageRatings = reviews
                    .GroupBy(x => x.RestaurantId)
                    .Select(r => new
                    {
                        RestaurantId = r.Key,
                        AverageRating = r.Average(x => x.Rating)
                    });

                foreach (var ratings in averageRatings)
                {
                    var restaurant = db.Restaurants.First(x => x.Id == ratings.RestaurantId);
                    Console.WriteLine($"{restaurant.Name} {ratings.AverageRating}");
                }

                // -------------------------------------------------
                Console.WriteLine();
                Console.WriteLine("Restaurant Number of Ratings");

                var numberRatings = reviews
                    .GroupBy(x => x.RestaurantId)
                    .Select(r => new
                    {
                        RestaurantId = r.Key,
                        RatingCount = r.Count()
                    });

                foreach (var ratings in numberRatings)
                {
                    var restaurant = db.Restaurants.First(x => x.Id == ratings.RestaurantId);
                    Console.WriteLine($"{restaurant.Name} {ratings.RatingCount}");
                }

                // -------------------------------------------------
                Console.WriteLine();
                Console.WriteLine("Restaurant Highest Ratings"); 

                var highestRating = reviews
                    .GroupBy(x => x.RestaurantId)
                    .Select(r => new
                    {
                        RestaurantId = r.Key,
                        HighestRating = r.Max(x=>x.Rating)
                    });

                foreach (var ratings in highestRating)
                {
                    var restaurant = db.Restaurants.First(x => x.Id == ratings.RestaurantId);
                    Console.WriteLine($"{restaurant.Name} {ratings.HighestRating}");
                }

            }
        }
    }
}