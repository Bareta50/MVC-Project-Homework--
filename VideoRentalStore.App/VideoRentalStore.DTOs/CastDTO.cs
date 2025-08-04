using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRentalStore.DTOs.Enums;
namespace VideoRentalStore.DTOs
{
    public class CastDTO    
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string ActorName { get; set; }
        public PartEnumDTO Role { get; set; }
    }
}
