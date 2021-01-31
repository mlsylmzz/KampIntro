using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
