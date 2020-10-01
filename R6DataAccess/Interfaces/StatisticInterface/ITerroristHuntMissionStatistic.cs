namespace R6DataAccess.Models
{
    public interface ITerroristHuntMissionStatistic
    {
        int AllterrohuntcoopHardBestscoreInfinite { get; set; }
        int AllterrohuntcoopNormalBestscoreInfinite { get; set; }
        int AllterrohuntcoopRealisticBestscoreInfinite { get; set; }
        int AllterrohuntsoloHardBestscoreInfinite { get; set; }
        int AllterrohuntsoloNormalBestscoreInfinite { get; set; }
        int MissionsoloNormalBestscoreInfinite { get; set; }
        int TerrohuntclassicpveMatchlostInfinite { get; set; }
        int TerrohuntclassicpveMatchplayedInfinite { get; set; }
        int TerrohuntclassicpveMatchwonInfinite { get; set; }
    }
}