using GameStoreSimulation.Entries;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreSimulation.Abstract
{
    interface IPlayerCheckService
    {
        bool PlayerCheck(Player player);
    }
}
