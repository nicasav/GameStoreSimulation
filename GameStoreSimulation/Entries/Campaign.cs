using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreSimulation.Entries
{
    public class Campaign
    {
        public string Id { get; set; }
        public string CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }
        //public List<string> DiscountedGamesList { get; set; }
    }
}
