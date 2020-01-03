using System;
using System.Collections.Generic;
using System.Text;

namespace R6VAG.Model
{
    public class Ranked
    {
        public int mmr { get; set; }
        public int maxmmr { get; set; }
        public int rank { get; set; }
        public int maxrank { get; set; }
        public int NA_kills { get; set; }
        public int NA_deaths { get; set; }
        public int NA_wins { get; set; }
        public int NA_losses { get; set; }
        public int NA_abandons { get; set; }
        public int NA_mmr { get; set; }
        public int NA_maxmmr { get; set; }
        public int NA_rank { get; set; }
        public int NA_maxrank { get; set; }
        public int NA_champ { get; set; }
        public int NA_mmrchange { get; set; }
        public DateTime NA_updatedon { get; set; }
        public int EU_kills { get; set; }
        public int EU_deaths { get; set; }
        public int EU_wins { get; set; }
        public int EU_losses { get; set; }
        public int EU_abandons { get; set; }
        public int EU_mmr { get; set; }
        public int EU_maxmmr { get; set; }
        public int EU_rank { get; set; }
        public int EU_maxrank { get; set; }
        public int EU_champ { get; set; }
        public int EU_mmrchange { get; set; }
        public DateTime EU_updatedon { get; set; }
        public int AS_kills { get; set; }
        public int AS_deaths { get; set; }
        public int AS_wins { get; set; }
        public int AS_losses { get; set; }
        public int AS_abandons { get; set; }
        public int AS_mmr { get; set; }
        public int AS_maxmmr { get; set; }
        public int AS_rank { get; set; }
        public int AS_maxrank { get; set; }
        public int AS_champ { get; set; }
        public int AS_mmrchange { get; set; }
        public DateTime AS_updatedon { get; set; }
    }
    public class Seasonal
    {
        public int current_NA_mmr { get; set; }
        public int last_NA_mmr { get; set; }
        public int last_NA_mmrchange { get; set; }
        public int current_EU_mmr { get; set; }
        public int last_EU_mmr { get; set; }
        public int last_EU_mmrchange { get; set; }
        public int current_AS_mmr { get; set; }
        public int last_AS_mmr { get; set; }
        public int last_AS_mmrchange { get; set; }
        public int total_casualwins { get; set; }
        public int total_casuallosses { get; set; }
        public int total_casualtotal { get; set; }
        public int total_casualkills { get; set; }
        public int total_casualdeaths { get; set; }
        public int total_rankedwins { get; set; }
        public int total_rankedlosses { get; set; }
        public int total_rankedtotal { get; set; }
        public int total_rankedkills { get; set; }
        public int total_rankeddeaths { get; set; }
        public int total_generalwins { get; set; }
        public int total_generallosses { get; set; }
        public int total_generaltotal { get; set; }
        public int total_generalkills { get; set; }
        public int total_generaldeaths { get; set; }
        public int total_totalbulletshits { get; set; }
        public int total_totalhs { get; set; }
        public int total_totaltimeplayed { get; set; }
        public int bomb_wins { get; set; }
        public int bomb_losses { get; set; }
        public int bomb_total { get; set; }
        public int secure_wins { get; set; }
        public int secure_losses { get; set; }
        public int secure_total { get; set; }
        public int hostage_wins { get; set; }
        public int hostage_losses { get; set; }
        public int hostage_total { get; set; }
        public string favorite_mode { get; set; }
    }

    public class PlayerProfileModel
    {
        public Ranked ranked { get; set; }
        public Seasonal seasonal { get; set; }
        public int kd { get; set; }
        public string p_id { get; set; }
    }
}
