using System;

namespace R6DataAccess.Models
{
    public interface IPlayerProgression
    {
        int Level { get; set; }
        int LootboxProbability { get; set; }
       
        Guid ProfileId { get; set; }
        int XP { get; set; }
    }
}