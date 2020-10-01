using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace R6DataAccess.Models
{
    public  class EquipmentStatisticsFetch
    {
        [JsonPropertyName("results")]
        public Dictionary<string, EquipmentStatistic> EquipmentStatistics { get; set; }
    }
    public class EquipmentStatistic : IEquipmentStatistic

    {


        [JsonPropertyName("weapontypepvp_headshot:B:infinite")]
        public int WeapontypepvpHeadshotBInfinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:143D8A7F46:infinite")]
        public int GadgetpveChosen143D8A7F46Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310B7:infinite")]
        public int GadgetpveChosenB79310B7Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310A7:infinite")]
        public int GadgetpveChosenB79310A7Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_death:6:infinite")]
        public int WeapontypepvpDeath6Infinite { get; set; }

        [JsonPropertyName("weapontypepve_kills:3:infinite")]
        public int WeapontypepveKills3Infinite { get; set; }

        [JsonPropertyName("weapontypepve_death:5:infinite")]
        public int WeapontypepveDeath5Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310B4:infinite")]
        public int GadgetpveChosenB79310B4Infinite { get; set; }

        [JsonPropertyName("weapontypepve_kills:6:infinite")]
        public int WeapontypepveKills6Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbnoassists:C:infinite")]
        public int WeapontypepvpDbnoassistsCInfinite { get; set; }

        [JsonPropertyName("weapontypepve_death:1:infinite")]
        public int WeapontypepveDeath1Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:2305F2E8CF:infinite")]
        public int GadgetpveChosen2305F2E8CFInfinite { get; set; }

        [JsonPropertyName("weapontypepvp_chosen:2:infinite")]
        public int WeapontypepvpChosen2Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310AA:infinite")]
        public int GadgetpveChosenB79310AAInfinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbno:4:infinite")]
        public int WeapontypepvpDbno4Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310AD:infinite")]
        public int GadgetpveChosenB79310ADInfinite { get; set; }

        [JsonPropertyName("weapontypepve_kills:5:infinite")]
        public int WeapontypepveKills5Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_kills:B:infinite")]
        public int WeapontypepvpKillsBInfinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:E3707E47F:infinite")]
        public int GadgetpveChosenE3707E47FInfinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:ADC64DD49:infinite")]
        public int GadgetpveChosenADC64DD49Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:3A39663A6F:infinite")]
        public int GadgetpveChosen3A39663A6FInfinite { get; set; }

        [JsonPropertyName("gadgetpvp_kills:38B9A14617:infinite")]
        public int GadgetpvpKills38B9A14617Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_kills:6:infinite")]
        public int WeapontypepvpKills6Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_headshot:7:infinite")]
        public int WeapontypepvpHeadshot7Infinite { get; set; }

        [JsonPropertyName("gadgetpvp_kills:A44721360:infinite")]
        public int GadgetpvpKillsA44721360Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:1F7D4C789A:infinite")]
        public int GadgetpveChosen1F7D4C789AInfinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:2A4CEB729C:infinite")]
        public int GadgetpveChosen2A4CEB729CInfinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B793109F:infinite")]
        public int GadgetpveChosenB793109FInfinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:38FA6AE7CE:infinite")]
        public int GadgetpveChosen38FA6AE7CEInfinite { get; set; }

        [JsonPropertyName("weapontypepvp_death:7:infinite")]
        public int WeapontypepvpDeath7Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_death:4:infinite")]
        public int WeapontypepvpDeath4Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:883555882:infinite")]
        public int GadgetpveChosen883555882Infinite { get; set; }

        [JsonPropertyName("gadgetpve_kills:B79310CB:infinite")]
        public int GadgetpveKillsB79310CBInfinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:251D51968C:infinite")]
        public int GadgetpveChosen251D51968CInfinite { get; set; }

        [JsonPropertyName("weapontypepve_headshot:4:infinite")]
        public int WeapontypepveHeadshot4Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_headshot:1:infinite")]
        public int WeapontypepvpHeadshot1Infinite { get; set; }

        [JsonPropertyName("weapontypepve_bullethit:5:infinite")]
        public int WeapontypepveBullethit5Infinite { get; set; }

        [JsonPropertyName("weapontypepve_headshot:3:infinite")]
        public int WeapontypepveHeadshot3Infinite { get; set; }

        [JsonPropertyName("weapontypepve_kills:1:infinite")]
        public int WeapontypepveKills1Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbno:5:infinite")]
        public int WeapontypepvpDbno5Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:37E0A74DD2:infinite")]
        public int GadgetpveChosen37E0A74DD2Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_kills:3:infinite")]
        public int WeapontypepvpKills3Infinite { get; set; }

        [JsonPropertyName("weapontypepve_kills:7:infinite")]
        public int WeapontypepveKills7Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_bullethit:C:infinite")]
        public int WeapontypepvpBullethitCInfinite { get; set; }

        [JsonPropertyName("weapontypepvp_headshot:5:infinite")]
        public int WeapontypepvpHeadshot5Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310A1:infinite")]
        public int GadgetpveChosenB79310A1Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310AB:infinite")]
        public int GadgetpveChosenB79310ABInfinite { get; set; }

        [JsonPropertyName("weapontypepve_bullethit:3:infinite")]
        public int WeapontypepveBullethit3Infinite { get; set; }

        [JsonPropertyName("gadgetpve_kills:38B9A2CB16:infinite")]
        public int GadgetpveKills38B9A2CB16Infinite { get; set; }

        [JsonPropertyName("weapontypepve_headshot:7:infinite")]
        public int WeapontypepveHeadshot7Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_death:2:infinite")]
        public int WeapontypepvpDeath2Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310BB:infinite")]
        public int GadgetpveChosenB79310BBInfinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbno:3:infinite")]
        public int WeapontypepvpDbno3Infinite { get; set; }

        [JsonPropertyName("weapontypepve_bulletfired:3:infinite")]
        public int WeapontypepveBulletfired3Infinite { get; set; }

        [JsonPropertyName("gadgetpvp_kills:36232BA67D:infinite")]
        public int GadgetpvpKills36232BA67DInfinite { get; set; }

        [JsonPropertyName("weapontypepvp_headshot:4:infinite")]
        public int WeapontypepvpHeadshot4Infinite { get; set; }

        [JsonPropertyName("weapontypepve_kills:4:infinite")]
        public int WeapontypepveKills4Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310AC:infinite")]
        public int GadgetpveChosenB79310ACInfinite { get; set; }

        [JsonPropertyName("weapontypepve_bullethit:4:infinite")]
        public int WeapontypepveBullethit4Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_bullethit:4:infinite")]
        public int WeapontypepvpBullethit4Infinite { get; set; }

        [JsonPropertyName("weapontypepve_bulletfired:1:infinite")]
        public int WeapontypepveBulletfired1Infinite { get; set; }

        [JsonPropertyName("weapontypepve_headshot:6:infinite")]
        public int WeapontypepveHeadshot6Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:1FC75DB98:infinite")]
        public int GadgetpveChosen1FC75DB98Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_kills:1:infinite")]
        public int WeapontypepvpKills1Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbno:7:infinite")]
        public int WeapontypepvpDbno7Infinite { get; set; }

        [JsonPropertyName("weapontypepve_bulletfired:4:infinite")]
        public int WeapontypepveBulletfired4Infinite { get; set; }

        [JsonPropertyName("weapontypepve_chosen:4:infinite")]
        public int WeapontypepveChosen4Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_chosen:7:infinite")]
        public int WeapontypepvpChosen7Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_bullethit:6:infinite")]
        public int WeapontypepvpBullethit6Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_bullethit:7:infinite")]
        public int WeapontypepvpBullethit7Infinite { get; set; }

        [JsonPropertyName("weapontypepve_chosen:7:infinite")]
        public int WeapontypepveChosen7Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_headshot:3:infinite")]
        public int WeapontypepvpHeadshot3Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:9B2CAEBA:infinite")]
        public int GadgetpveChosen9B2CAEBAInfinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:395EBC0A4E:infinite")]
        public int GadgetpveChosen395EBC0A4EInfinite { get; set; }

        [JsonPropertyName("weapontypepvp_headshot:6:infinite")]
        public int WeapontypepvpHeadshot6Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_chosen:1:infinite")]
        public int WeapontypepvpChosen1Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310AF:infinite")]
        public int GadgetpveChosenB79310AFInfinite { get; set; }

        [JsonPropertyName("weapontypepvp_bullethit:5:infinite")]
        public int WeapontypepvpBullethit5Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_death:B:infinite")]
        public int WeapontypepvpDeathBInfinite { get; set; }

        [JsonPropertyName("weapontypepvp_chosen:9:infinite")]
        public int WeapontypepvpChosen9Infinite { get; set; }

        [JsonPropertyName("gadgetpvp_kills:1CBF13F5FB:infinite")]
        public int GadgetpvpKills1CBF13F5FBInfinite { get; set; }

        [JsonPropertyName("weapontypepve_bullethit:2:infinite")]
        public int WeapontypepveBullethit2Infinite { get; set; }

        [JsonPropertyName("weapontypepve_bulletfired:6:infinite")]
        public int WeapontypepveBulletfired6Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_death:1:infinite")]
        public int WeapontypepvpDeath1Infinite { get; set; }

        [JsonPropertyName("weapontypepve_chosen:5:infinite")]
        public int WeapontypepveChosen5Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310B5:infinite")]
        public int GadgetpveChosenB79310B5Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:108F856206:infinite")]
        public int GadgetpveChosen108F856206Infinite { get; set; }

        [JsonPropertyName("weapontypepve_bullethit:1:infinite")]
        public int WeapontypepveBullethit1Infinite { get; set; }

        [JsonPropertyName("weapontypepve_headshot:5:infinite")]
        public int WeapontypepveHeadshot5Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310B9:infinite")]
        public int GadgetpveChosenB79310B9Infinite { get; set; }

        [JsonPropertyName("gadgetpvp_kills:9A9F55EF9:infinite")]
        public int GadgetpvpKills9A9F55EF9Infinite { get; set; }

        [JsonPropertyName("weapontypepve_chosen:2:infinite")]
        public int WeapontypepveChosen2Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310BC:infinite")]
        public int GadgetpveChosenB79310BCInfinite { get; set; }

        [JsonPropertyName("weapontypepve_chosen:9:infinite")]
        public int WeapontypepveChosen9Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:24F9498269:infinite")]
        public int GadgetpveChosen24F9498269Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbnoassists:6:infinite")]
        public int WeapontypepvpDbnoassists6Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:37E0A74DD4:infinite")]
        public int GadgetpveChosen37E0A74DD4Infinite { get; set; }

        [JsonPropertyName("weapontypepve_bulletfired:2:infinite")]
        public int WeapontypepveBulletfired2Infinite { get; set; }

        [JsonPropertyName("weapontypepve_headshot:1:infinite")]
        public int WeapontypepveHeadshot1Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_bullethit:3:infinite")]
        public int WeapontypepvpBullethit3Infinite { get; set; }

        [JsonPropertyName("weapontypepve_chosen:6:infinite")]
        public int WeapontypepveChosen6Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_death:3:infinite")]
        public int WeapontypepvpDeath3Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbnoassists:2:infinite")]
        public int WeapontypepvpDbnoassists2Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_bullethit:1:infinite")]
        public int WeapontypepvpBullethit1Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:96ED81DE6:infinite")]
        public int GadgetpveChosen96ED81DE6Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_kills:2:infinite")]
        public int WeapontypepvpKills2Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbnoassists:5:infinite")]
        public int WeapontypepvpDbnoassists5Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbnoassists:4:infinite")]
        public int WeapontypepvpDbnoassists4Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_chosen:5:infinite")]
        public int WeapontypepvpChosen5Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310BD:infinite")]
        public int GadgetpveChosenB79310BDInfinite { get; set; }

        [JsonPropertyName("weapontypepve_headshot:2:infinite")]
        public int WeapontypepveHeadshot2Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_bullethit:B:infinite")]
        public int WeapontypepvpBullethitBInfinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:731005332:infinite")]
        public int GadgetpveChosen731005332Infinite { get; set; }

        [JsonPropertyName("weapontypepve_bulletfired:5:infinite")]
        public int WeapontypepveBulletfired5Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_death:5:infinite")]
        public int WeapontypepvpDeath5Infinite { get; set; }

        [JsonPropertyName("weapontypepve_bulletfired:7:infinite")]
        public int WeapontypepveBulletfired7Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_chosen:6:infinite")]
        public int WeapontypepvpChosen6Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbnoassists:7:infinite")]
        public int WeapontypepvpDbnoassists7Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310A5:infinite")]
        public int GadgetpveChosenB79310A5Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310BA:infinite")]
        public int GadgetpveChosenB79310BAInfinite { get; set; }

        [JsonPropertyName("weapontypepve_chosen:3:infinite")]
        public int WeapontypepveChosen3Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:38FA6B0D49:infinite")]
        public int GadgetpveChosen38FA6B0D49Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_chosen:B:infinite")]
        public int WeapontypepvpChosenBInfinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:2C06F6BBC5:infinite")]
        public int GadgetpveChosen2C06F6BBC5Infinite { get; set; }

        [JsonPropertyName("gadgetpvp_kills:80CA9890C:infinite")]
        public int GadgetpvpKills80CA9890CInfinite { get; set; }

        [JsonPropertyName("weapontypepve_bullethit:7:infinite")]
        public int WeapontypepveBullethit7Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:232803C7B3:infinite")]
        public int GadgetpveChosen232803C7B3Infinite { get; set; }

        [JsonPropertyName("weapontypepve_bullethit:6:infinite")]
        public int WeapontypepveBullethit6Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbno:B:infinite")]
        public int WeapontypepvpDbnoBInfinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:38B9A2CB16:infinite")]
        public int GadgetpveChosen38B9A2CB16Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:24F9498268:infinite")]
        public int GadgetpveChosen24F9498268Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:24F948E748:infinite")]
        public int GadgetpveChosen24F948E748Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310A0:infinite")]
        public int GadgetpveChosenB79310A0Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_headshot:2:infinite")]
        public int WeapontypepvpHeadshot2Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_kills:5:infinite")]
        public int WeapontypepvpKills5Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_chosen:4:infinite")]
        public int WeapontypepvpChosen4Infinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:FF436317B:infinite")]
        public int GadgetpveChosenFF436317BInfinite { get; set; }

        [JsonPropertyName("gadgetpve_kills:36232BA67D:infinite")]
        public int GadgetpveKills36232BA67DInfinite { get; set; }

        [JsonPropertyName("gadgetpve_chosen:B79310A3:infinite")]
        public int GadgetpveChosenB79310A3Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbnoassists:1:infinite")]
        public int WeapontypepvpDbnoassists1Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_chosen:3:infinite")]
        public int WeapontypepvpChosen3Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbnoassists:3:infinite")]
        public int WeapontypepvpDbnoassists3Infinite { get; set; }

        [JsonPropertyName("weapontypepve_chosen:1:infinite")]
        public int WeapontypepveChosen1Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbnoassists:9:infinite")]
        public int WeapontypepvpDbnoassists9Infinite { get; set; }

        [JsonPropertyName("weapontypepve_death:6:infinite")]
        public int WeapontypepveDeath6Infinite { get; set; }

        [JsonPropertyName("gadgetpve_kills:38B9A14617:infinite")]
        public int GadgetpveKills38B9A14617Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbno:2:infinite")]
        public int WeapontypepvpDbno2Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_kills:4:infinite")]
        public int WeapontypepvpKills4Infinite { get; set; }

        [JsonPropertyName("gadgetpvp_kills:B79310CB:infinite")]
        public int GadgetpvpKillsB79310CBInfinite { get; set; }

        [JsonPropertyName("weapontypepvp_bullethit:2:infinite")]
        public int WeapontypepvpBullethit2Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbno:1:infinite")]
        public int WeapontypepvpDbno1Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_kills:7:infinite")]
        public int WeapontypepvpKills7Infinite { get; set; }

        [JsonPropertyName("gadgetpvp_kills:38B9A2CB16:infinite")]
        public int GadgetpvpKills38B9A2CB16Infinite { get; set; }

        [JsonPropertyName("weapontypepvp_dbno:6:infinite")]
        public int WeapontypepvpDbno6Infinite { get; set; }

        [JsonPropertyName("gadgetpve_kills:A44721360:infinite")]
        public int GadgetpveKillsA44721360Infinite { get; set; }

        [JsonPropertyName("weapontypepve_kills:2:infinite")]
        public int WeapontypepveKills2Infinite { get; set; }
    }
}
