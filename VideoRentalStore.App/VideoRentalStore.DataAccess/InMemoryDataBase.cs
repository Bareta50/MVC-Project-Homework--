using VideoRentalStore.Domain;
using VideoRentalStore.Domain.Enums;
namespace VideoRentalStore.DataAccess

{
    public static class InMemoryDataBase
    {
       public static List<User> Users { get; set; }
       public static List<Movie> Movies { get; set; }
       public static List<Rental> Rentals { get; set; }
       public static List<Cast> Cast { get; set; }
        public static LanguageEnum Korean { get; private set; }

        static InMemoryDataBase()
        {
            LoadUsers();
            LoadMovies();
            LoadRentals();
            LoadCast();
        }

        private static void LoadUsers()
        {
            Users = new List<User>
            {
                new User{Id = 1, 
                    FullName = "John Doe",
                    Age = 30,
                    CardNumber = "1234567890",
                    CreatedOn = DateTime.Now,
                    IsSubscriptionExpired = false,
                    SubscriptionType = SubscriptionType.Premium,
                    AccountType = AccountType.User
                },
                new User{Id = 2, 
                    FullName = "Jane Smith",
                    Age = 25,
                    CardNumber = "0987654321",
                    CreatedOn = DateTime.Now,
                    IsSubscriptionExpired = false,
                    SubscriptionType = SubscriptionType.Standard,
                    AccountType = AccountType.User
                },
                new User{Id = 3, 
                    FullName = "Alice Johnson",
                    Age = 28,
                    CardNumber = "1122334455",
                    CreatedOn = DateTime.Now,
                    IsSubscriptionExpired = true,
                    SubscriptionType = SubscriptionType.StandardPlus,
                    AccountType = AccountType.Admin
                }

            };
        }

        private static void LoadMovies()
        {
            Movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Title = "Inception",
                    Genre = GenreType.SciFi,
                    Language = LanguageEnum.English,
                    IsAvailable = true,
                    ReleaseDate = new DateTime(2010, 7, 16),
                    Length = new TimeSpan(2, 28, 0),
                    AgeRestriction = 13,
                    Quantity = 5
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Godfather",
                    Genre = GenreType.Drama,
                    Language = LanguageEnum.English,
                    IsAvailable = true,
                    ReleaseDate = new DateTime(1972, 3, 24),
                    Length = new TimeSpan(2, 55, 0),
                    AgeRestriction = 18,
                    Quantity = 3
                },
                new Movie
                {
                    Id = 3,
                    Title = "Parasite",
                    Genre = GenreType.Thriller,
                    Language = LanguageEnum.Korean,
                    IsAvailable = true,
                    ReleaseDate = new DateTime(2019, 5, 30),
                    Length = new TimeSpan(2, 12, 0),
                    AgeRestriction = 15,
                    Quantity = 4
                }

            };
        }

        private static void LoadRentals()
        {
            Rentals = new List<Rental>
            {
                new Rental
                {
                    Id = 1,
                    MovieId = 1,
                    UserId = 1,
                    RentedOn = DateTime.Now.AddDays(-2),
                    ReturnedOn = DateTime.Now
                },
                new Rental
                {
                    Id = 2,
                    MovieId = 2,
                    UserId = 2,
                    RentedOn = DateTime.Now.AddDays(-5),
                    ReturnedOn = DateTime.Now.AddDays(-3)
                },
                new Rental
                {
                    Id = 3,
                    MovieId = 3,
                    UserId = 3,
                    RentedOn = DateTime.Now.AddDays(-1),
                    ReturnedOn = DateTime.Now
                },
                new Rental
                {
                    Id = 4,
                    MovieId = 1,
                    UserId = 2,
                    RentedOn = DateTime.Now.AddDays(-10),
                    ReturnedOn = DateTime.Now.AddDays(-8)
                }

            };
        }

        private static void LoadCast()
        {
            Cast = new List<Cast>
            {
                new Cast
                {
                    Id = 1,
                    MovieId = 1,
                    ActorName = "Leonardo DiCaprio",
                    Role = PartEnum.MainActor
                },
                new Cast
                {
                    Id = 2,
                    MovieId = 2,
                    ActorName = "Marlon Brando",
                    Role = PartEnum.MainActor
                },
                new Cast
                {
                    Id = 3,
                    MovieId = 3,
                    ActorName = "Song Kang-ho",
                    Role = PartEnum.MainActor
                }
            };
        }

    }

    
}
