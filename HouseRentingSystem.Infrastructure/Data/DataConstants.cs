using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.Data
{
    public class DataConstants
    {

        public class CategoryConstants
        {
            public const int MaxCategoryNameLength = 50;
        }

        public class HouseConstants
        {
            public const int MinTitleLength = 10;
            public const int MaxTitleLength = 50;  
            
            public const int MinAddressLength = 30;
            public const int MaxAddressLength = 150;

            public const int MinDescriptionLength = 50;
            public const int MaxDescriptionLength = 500;
        }

        public class AgentConstants
        {
            public const int MinPhoneNumberLength = 7;
            public const int MaxPhoneNumberLength = 15;
        }
    }
}
