using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRentalStore.DTOs.Enums;

namespace VideoRentalStore.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public GenreTypeDTO Genre { get; set; }
        public LanguageEnumDTO Language { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Length { get; set; }
        public int AgeRestriction { get; set; }
        public int Quantity { get; set; }
    }
}
