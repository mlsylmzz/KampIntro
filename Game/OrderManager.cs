using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class OrderManager:IOrderService
    {
        public void order(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.Id + " no'lu oyuncu " + game.GameName + " oyununu satın aldı.");
        }

        
    }
}
