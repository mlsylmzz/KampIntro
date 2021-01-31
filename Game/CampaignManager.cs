using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class CampaignManager:ICampaignService
    {
      
        public void CampaignSale(Game game,Campaign campaign,Gamer gamer)
        {
            Console.WriteLine(gamer.Id + " no'lu oyuncu " + game.GameName + " oyununu % " + campaign.Discount + " indirim ile " + campaign.CampaignName + " kampanyası ile satın aldı.");
        }

        
    }
}
