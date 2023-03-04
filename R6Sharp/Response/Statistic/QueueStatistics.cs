using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace R6Sharp.Response.Statistic
{
    public class QueueStatistics
    {
        [JsonPropertyName("results")]
        public Dictionary<string, Dictionary<string, double>> PlayerQueueStatistics { get; set; }
    }
}
