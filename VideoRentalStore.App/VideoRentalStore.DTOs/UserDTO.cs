using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRentalStore.DTOs.Enums;

namespace VideoRentalStore.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string CardNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsSubscriptionExpired { get; set; }
        public SubscriptionTypeDTO SubscriptionType { get; set; }
        public AccountTyperDTO AccountType { get; set; }
        }
}
