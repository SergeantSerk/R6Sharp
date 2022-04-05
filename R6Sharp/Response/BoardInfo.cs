using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace R6Sharp.Response
{
    public class BoardInfoFetch
    {
        [JsonPropertyName("players")]
        public Dictionary<string, BoardInfo> Players { get; set; }
    }

    public class BoardInfo
    {
        [JsonPropertyName("kills")]
        public int Kills { get; set; }

        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }

        [JsonPropertyName("wins")]
        public int Wins { get; set; }

        [JsonPropertyName("losses")]
        public int Losses { get; set; }

        [JsonPropertyName("abandons")]
        public int Abandons { get; set; }

        [JsonPropertyName("skill_stdev")]
        public double SkillStdev { get; set; }

        [JsonPropertyName("skill_mean")]
        public double SkillMean { get; set; }

        [JsonPropertyName("last_match_result")]
        public int LastMatchResult { get; set; }

        [JsonPropertyName("last_match_mmr_change")]
        public double LastMatchMMRChange { get; set; }

        [JsonPropertyName("last_match_skill_stdev_change")]
        public double LastMatchSkillStdevChange { get; set; }

        [JsonPropertyName("last_match_skill_mean_change")]
        public double LastMatchSkillMeanChange { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        public RankInfo RankInfo => new RankInfo(this, RankInfo.RankType.RankMMR);

        [JsonPropertyName("max_rank")]
        public int MaxRank { get; set; }

        public RankInfo MaxRankInfo => new RankInfo(this, RankInfo.RankType.RankMMR);

        [JsonPropertyName("mmr")]
        public double MMR { get; set; }

        [JsonPropertyName("max_mmr")]
        public double MaxMMR { get; set; }

        [JsonPropertyName("next_rank_mmr")]
        public double NextRankMMR { get; set; }

        [JsonPropertyName("previous_rank_mmr")]
        public double PreviousRankMMR { get; set; }

        [JsonPropertyName("top_rank_position")]
        public int TopRankPosition { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("season")]
        public int Season { get; set; }

        [JsonPropertyName("update_time")]
        public DateTime UpdateTime { get; set; }

        [JsonPropertyName("board_id")]
        public string BoardId { get; set; }

        [JsonPropertyName("profile_id")]
        public Guid ProfileId { get; set; }
    }

    /// <summary>
    /// Derives rank data based on current season rank structure.
    /// </summary>
    public class RankInfo
    {
        private static readonly Uri _baseUrl = new Uri("https://staticctf.akamaized.net/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/");
        private static readonly Tuple<string, int, int, Uri>[] _ranks = new Tuple<string, int, int, Uri>[]
        {
                new Tuple<string, int, int, Uri>("Unranked",        -1,     -1,
                    new Uri(_baseUrl, "6HQlEdlInHQ2B2ZbHygp2x/cfa4500a6a30419d862a74736416e5fc/R6S_RANK_None_L.png")),
                new Tuple<string, int, int,  Uri>("Copper V",       0,      1199,
                    new Uri(_baseUrl, "5xXGWX0lPNFRkTCbyxEdpn/43d9f77e44f14a694ce3790d470a59a5/R6S_RANK_500x500_Copper_05.png")),
                new Tuple<string, int, int,  Uri>("Copper IV",      1200,   1299,
                    new Uri(_baseUrl, "4pYeN2wYLmCmSdGLASi91d/53bce6d8e2c764a497a89fb9437de557/R6S_RANK_500x500_Copper_04.png")),
                new Tuple<string, int, int,  Uri>("Copper III",     1300,   1399,
                    new Uri(_baseUrl, "70gNBYSf1kU94v5PoXlHGZ/3ce45f73df5b6b4377dea1452afe70fc/R6S_RANK_500x500_Copper_03.png")),
                new Tuple<string, int, int,  Uri>("Copper II",      1400,   1499,
                    new Uri(_baseUrl, "6b9igyYh2U1t5wqJmUSSVU/7ca8e07be18f2d1990201080582b0272/R6S_RANK_500x500_Copper_02.png")),
                new Tuple<string, int, int,  Uri>("Copper I",       1500,   1599,
                    new Uri(_baseUrl, "3r3jMDq2BCg20rrkHKzJVq/77a16bf4bb2e0dfb939bcec26559b17a/R6S_RANK_500x500_Copper_01.png")),
                new Tuple<string, int, int,  Uri>("Bronze V",       1600,   1699,
                    new Uri(_baseUrl, "5tzRRjiEoyYDY0lUBWvLvP/25503d2ad74339122be6e61c0a5117e0/R6S_RANK_500x500_Bronze_05.png")),
                new Tuple<string, int, int,  Uri>("Bronze IV",      1700,   1799,
                    new Uri(_baseUrl, "3fi46SbCqO8EfoR6Jij27d/c5f44a5e33e7b8091684e08da032d1df/R6S_RANK_500x500_Bronze_04.png")),
                new Tuple<string, int, int,  Uri>("Bronze III",     1800,   1899,
                    new Uri(_baseUrl, "1JwqzCVjMarrUpcHNVF7vT/d5496a9ecdee4f6d85d5d3483e8a0571/R6S_RANK_500x500_Bronze_03.png")),
                new Tuple<string, int, int,  Uri>("Bronze II",      1900,   1999,
                    new Uri(_baseUrl, "77VWoJQx9cwBSg2qFSLGMJ/6af35aafa4aa2bc93f69d43c5a223055/R6S_RANK_500x500_Bronze_02.png")),
                new Tuple<string, int, int,  Uri>("Bronze I",       2000,   2099,
                    new Uri(_baseUrl, "4cEcVmkkoz590Tar0hFgFO/610dd4998bc6ec599310e4e19b6e428a/R6S_RANK_500x500_Bronze_01.png")),
                new Tuple<string, int, int,  Uri>("Silver V",       2100,   2199,
                    new Uri(_baseUrl, "3k0MFneuqkhrr2onZDNl2O/7f75189a087d8f783852175b9bab2654/R6S_RANK_500x500_Silver_05.png")),
                new Tuple<string, int, int,  Uri>("Silver IV",      2200,   2299,
                    new Uri(_baseUrl, "27vGfJ0Gi45d88ggLJnnBN/ea1bdcf32846b049d94bea837319ce90/R6S_RANK_500x500_Silver_04.png")),
                new Tuple<string, int, int,  Uri>("Silver III",     2300,   2399,
                    new Uri(_baseUrl, "6bfRfsBkj3U7C8TZcQf8eT/01188630787ab3e04acb89abd4f60e40/R6S_RANK_500x500_Silver_03.png")),
                new Tuple<string, int, int,  Uri>("Silver II",      2400,   2499,
                    new Uri(_baseUrl, "0PLZUFs3fqKBTLh1gYyY8/7cabc5ba4522f725583faac165ff5130/R6S_RANK_500x500_Silver_02.png")),
                new Tuple<string, int, int,  Uri>("Silver I",       2500,   2599,
                    new Uri(_baseUrl, "4guViAQud6vSRPWoWGUNyU/32b279721dcfb09d0668f7b6a15ae3ea/R6S_RANK_500x500_Silver_01.png")),
                new Tuple<string, int, int,  Uri>("Gold III",       2600,   2799,
                    new Uri(_baseUrl, "5o6FA0tOweqf2RMm6ly9ET/5cf7d4ce0465315dfa4012a6a84c428a/R6S_RANK_500x500_GOLD_03.png")),
                new Tuple<string, int, int,  Uri>("Gold II",        2800,   2999,
                    new Uri(_baseUrl, "HQeTsDatqQRo9qW5KKs1x/4ba25d10cfb681d3347985a1125b69cf/R6S_RANK_500x500_GOLD_02.png")),
                new Tuple<string, int, int,  Uri>("Gold I",         3000,   3199,
                    new Uri(_baseUrl, "8Mpi8OU4AnEh93pVcapyW/2b140e3caae994c8fa2255623cba323e/R6S_RANK_500x500_GOLD_01.png")),
                new Tuple<string, int, int,  Uri>("Platinum III",   3200,   3599,
                    new Uri(_baseUrl, "1NdqJyCZK86i3AnQwEvIlt/68ed7769e4098ec682e8c793f5121722/R6S_RANK_500x500_Platinum_03.png")),
                new Tuple<string, int, int,  Uri>("Platinum II",    3600,   3999,
                    new Uri(_baseUrl, "54T8y7G0Yu6qniIliDAuWz/d7a8d760969db59b1608c255e1674a65/R6S_RANK_500x500_Platinum_02.png")),
                new Tuple<string, int, int,  Uri>("Platinum I",     4000,   4399,
                    new Uri(_baseUrl, "70KhxbY7ZSilFgcMFIFKip/cb5435f1e0e59804f38496868d8e9369/R6S_RANK_500x500_Platinum_01.png")),
                new Tuple<string, int, int,  Uri>("Diamond",        4400,   4999,
                    new Uri(_baseUrl, "3IjRzUddD2cTrx6xdVXFmY/49195f3e71b2d5694b50524bfd8fd30c/R6S_RANK_500x500_Diamond_01.png")),
                new Tuple<string, int, int,  Uri>("Champion",       5000,   int.MaxValue,
                    new Uri(_baseUrl, "74IhNF2m0VsDiurjYt9Q58/deb07d428a4a25acd70c92f6c7fcfca4/R6S_RANK_500x500_Champions_01.png")),
        };

        public enum RankType
        {
            RankIndex,
            RankMMR
        }

        public string Name { get; private set; }
        public Uri URL { get; private set; }

        public RankInfo(BoardInfo boardInfo, RankType type)
        {
            // Check if player has played any games for this queue
            if (boardInfo.MaxMMR == 0 &&
                boardInfo.Kills == 0 &&
                boardInfo.Deaths == 0 &&
                boardInfo.Wins == 0 &&
                boardInfo.Losses == 0 &&
                boardInfo.Abandons == 0 &&
                boardInfo.Rank == 0 &&
                boardInfo.MaxRank == 0)
            {
                // Unranked
                var result = _ranks[0];
                Name = result.Item1;
                URL = result.Item4;
                return;
            }

            if (type == RankType.RankIndex)
            {
                var rank = boardInfo.Rank;
                // Get rank by index
                if (rank < 0 || rank > _ranks.Length - 1)
                {
                    throw new ArgumentOutOfRangeException("Rank index does not exist in the given range.");
                }
                else
                {
                    var result = _ranks[rank];
                    Name = result.Item1;
                    URL = result.Item4;
                }
            }
            else if (type == RankType.RankMMR)
            {
                var rank = boardInfo.MMR;
                // Parse rank by MMR
                if (rank < 0)
                {
                    // MMR cannot be negative
                    throw new ArgumentOutOfRangeException("Rank MMR cannot be negative.");
                }
                else
                {
                    // Get rank tuple where MMR is in range
                    var result = _ranks.Where(r => rank >= r.Item2 &&
                                                   rank <= r.Item3)
                                       .First();
                    Name = result.Item1;
                    URL = result.Item4;
                }
            }
        }
    }
}