using System;

namespace R6DataAccess.Models
{
    public interface IBoardInfo
    {
        int Abandons { get; set; }
        string BoardId { get; set; }
        int Deaths { get; set; }
        int Kills { get; set; }
        double LastMatchMMRChange { get; set; }
        int LastMatchResult { get; set; }
        double LastMatchSkillMeanChange { get; set; }
        double LastMatchSkillStdevChange { get; set; }
        int Losses { get; set; }
        double MaxMMR { get; set; }
        int MaxRank { get; set; }
        double MMR { get; set; }
        double NextRankMMR { get; set; }
        double PreviousRankMMR { get; set; }
        Guid ProfileId { get; set; }
        int Rank { get; set; }
        string Region { get; set; }
        int Season { get; set; }
        double SkillMean { get; set; }
        double SkillStdev { get; set; }
        int TopRankPosition { get; set; }
        DateTime UpdateTime { get; set; }
        int Wins { get; set; }
    }
}