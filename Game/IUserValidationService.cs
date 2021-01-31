using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
