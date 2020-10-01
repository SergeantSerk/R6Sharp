using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess.Models.Static
{
    public static class EquipmentStatisticStatics
    {

        private const string GadgetPve = "gadgetpve_chosen,gadgetpve_gadgetdestroy,gadgetpve_kills,gadgetpve_mostused";
        private const string GadgetPvp = "gadgetpvp_chosen,gadgetpvp_gadgetdestroy,gadgetpvp_kills,gadgetpvp_mostused";
        private const string WeaponPve = "weaponpve_mostkills,weaponpve_mostused";
        private const string WeaponPvp = "weaponpvp_mostkills,weaponpvp_mostused";
        private const string WeaponTypePve = "weapontypepve_accuracy,weapontypepve_bulletfired,weapontypepve_bullethit,weapontypepve_chosen,weapontypepve_dbno,weapontypepve_dbnoassists,weapontypepve_death,weapontypepve_deaths,weapontypepve_efficiency,weapontypepve_headshot,weapontypepve_headshotratio,weapontypepve_kdratio,weapontypepve_killassists,weapontypepve_kills,weapontypepve_mostkills,weapontypepve_power";
        private const string WeaponTypePvp = "weapontypepvp_accuracy,weapontypepvp_bulletfired,weapontypepvp_bullethit,weapontypepvp_chosen,weapontypepvp_dbno,weapontypepvp_dbnoassists,weapontypepvp_death,weapontypepvp_deaths,weapontypepvp_efficiency,weapontypepvp_headshot,weapontypepvp_headshotratio,weapontypepvp_kdratio,weapontypepvp_killassists,weapontypepvp_kills,weapontypepvp_mostkills,weapontypepvp_power";

        public static string GetStatistic()
        {
            return string.Join(",", GadgetPve, GadgetPvp, WeaponPve, WeaponTypePve, WeaponTypePvp);
        }
    }
}
