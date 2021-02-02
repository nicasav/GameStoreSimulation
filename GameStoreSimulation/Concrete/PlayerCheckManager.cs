using GameStoreSimulation.Abstract;
using GameStoreSimulation.Entries;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreSimulation.Concrete
{
    class PlayerCheckManager : IPlayerCheckService
    {
        public bool PlayerCheck(Player player)
        {
            return true;
        }
    }
}
