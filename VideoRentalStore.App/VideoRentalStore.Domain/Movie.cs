using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRentalStore.Domain.Enums;

namespace VideoRentalStore.Domain
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public GenreType Genre { get; set; } 
        public LanguageEnum Language { get; set; } 
        public bool IsAvailable { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Length { get; set; }
        public int AgeRestriction { get; set; }
        public int Quantity { get; set; }
    }
}
