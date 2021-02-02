using GameStoreSimulation.Abstract;
using GameStoreSimulation.Adapters;
using GameStoreSimulation.Concrete;
using GameStoreSimulation.Entries;
using System;
using System.Linq;


namespace GameStoreSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayerCheckService checker = new MernisChecker();
            IGameSaleService salesman = new GameSaleManager();


            Game game1 = new Game
            {
                GameId = "1",
                GameName = "Valorant",
                GamePrice = 100,
                GameType = "FPS",
            };

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = "1";
            campaign1.CampaignName = "ValoGelYiyorsa";
            //campaign1.DiscountedGamesList = { "Valorant", "Cs:Go", "League Of Legends" };
            campaign1.Id = "12";
            campaign1.DiscountRate = 75;
            
            Player player1 = new Player 
            { 
                NationalId = "42571300608",
                BirthYear = 2001,
                Name = "Ali",
                Surname = "Oktay" };
            Player player2 = new Player
            {
                NationalId = "14821686770",
                BirthYear = 2001,
                Name = "Şeydanur",
                Surname = "Günaydın"
            };
            Player player3 = new Player
            {
                NationalId = "29245197740",
                BirthYear = 2001,
                Name = "Nidai Çağrı",
                Surname = "Savran"
            };
            
            Console.WriteLine(checker.PlayerCheck(player1));
            Console.WriteLine(salesman.GameSale(game1,player1,campaign1));
            Console.WriteLine(checker.PlayerCheck(player3));
        }
    }
}
