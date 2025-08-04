using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRentalStore.Domain.Enums;

namespace VideoRentalStore.Domain
{
    public class Cast : BaseEntity
    {
        public int MovieId { get; set; }
        public string ActorName { get; set; }
        public PartEnum Role { get; set; }
    }
}
