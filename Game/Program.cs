using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { Id = 2, BirthDate = 1997, FirstName = "Melis", LastName = "Yılmaz", TcNo = 12345 };
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1) ;

            Game game1 = new Game { GameName = "cs go", GameCost = 100 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            OrderManager orderManager = new OrderManager();
            orderManager.order(game1, gamer1 );

            Campaign campaign1 = new Campaign { CampaignName = "Black Sale", Discount = 65 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaignSale(game1, campaign1, gamer1);


          
        }
    }
}
