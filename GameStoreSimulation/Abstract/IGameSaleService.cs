using GameStoreSimulation.Entries;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreSimulation.Abstract
{
    interface IGameSaleService
    {
        string GameSale(Game game, Player player,Campaign campaign);
    }
}
