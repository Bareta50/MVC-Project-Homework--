using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRentalStore.Domain.Enums;

namespace VideoRentalStore.Domain
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string CardNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsSubscriptionExpired { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public AccountType AccountType { get; set; }
    }
}
