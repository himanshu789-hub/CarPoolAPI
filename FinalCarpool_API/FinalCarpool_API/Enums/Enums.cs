using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCarpool_API.Enums
{
    public enum Address
    {
        RAIPUR=1,BOMABAY,CHENNAI,MADRAS,DELHI,LUCKNOW,AMRITSAR
    }

    public enum Gender
    {
        MALE,FEMALE
    }

    
    public enum Discount
    {
     DISCOUNT_5P= 5 , DISCOUNT_10P = 10 ,DISCOUNT_20P = 20
    }

    public enum BookingStatus
    {
     NOTREQUESTED,PENDING,ACCEPTED,REJECTED,DESTROYED,BROADCAST,CANCEL
    }
}
