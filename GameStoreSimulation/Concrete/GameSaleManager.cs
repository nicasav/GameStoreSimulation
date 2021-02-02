using GameStoreSimulation.Abstract;
using GameStoreSimulation.Entries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameStoreSimulation.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        public string GameSale(Game game, Player player, Campaign campaign)
        {
            //double GamePrice;
            //if (campaign.DiscountedGamesList.Contains(game.GameName))
            //{
            //    GamePrice = game.GamePrice * campaign.DiscountRate / 100;

            //}
            //else
            //{
            //    GamePrice = game.GamePrice;
            //}
            //return game.GameName + " sold to " + player.Name + ". Price: " + GamePrice;

            double GamePrice;
            GamePrice = game.GamePrice * (100-campaign.DiscountRate) / 100;
            return game.GameName + " sold to " + player.Name + ". Price: " + GamePrice;
        }
    }
}
