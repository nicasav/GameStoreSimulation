using GameStoreSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using GameStoreSimulation.Entries;
using MernisServiceReference;

namespace GameStoreSimulation.Adapters
{
    public class MernisChecker:IPlayerCheckService
    {
        public bool PlayerCheck(Player player)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return kPSPublicSoapClient.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalId), player.Name.ToUpper(), player.Surname.ToUpper(), player.BirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
