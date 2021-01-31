using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthDate==1997&& gamer.FirstName=="Melis"
                &&gamer.LastName=="Yılmaz"&& gamer.TcNo==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
