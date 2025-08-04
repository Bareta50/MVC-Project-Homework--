using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRentalStore.Domain;
using VideoRentalStore.Domain.Enums;
using VideoRentalStore.DTOs;
using VideoRentalStore.DTOs.Enums;

namespace VideoRentalStore.Mapper
{
    public static class MapperExtension
    {
        public static UserDTO Map(this User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                FullName = user.FullName,
                Age = user.Age,
                CardNumber = user.CardNumber,
                CreatedOn = user.CreatedOn,
                IsSubscriptionExpired = user.IsSubscriptionExpired,
                SubscriptionType = user.SubscriptionType
            };
        }

        public static MovieDTO Map(this Movie movie)
        {
            return new MovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                Genre = movie.Genre,
                Language = movie.Language,
                IsAvailable = movie.IsAvailable,
                ReleaseDate = movie.ReleaseDate,
                Length = movie.Length,
                AgeRestriction = movie.AgeRestriction,
                Quantity = movie.Quantity
            };
        }

        public static RentalDTO Map(this Rental rental)
        {
            return new RentalDTO
            {
                Id = rental.Id,
                MovieId = rental.MovieId,
                UserId = rental.UserId,
                RentedOn = rental.RentedOn,
                ReturnedOn = rental.ReturnedOn
            };
        }
        public static Cast Map(this Cast cast)
        {
            return new Cast
            {
                Id = cast.Id,
                MovieId = cast.MovieId,
                ActorName = cast.ActorName,
                Role = cast.Role
            };
        }

        
    }
}
