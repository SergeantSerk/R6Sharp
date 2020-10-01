using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace R6DataAccess.Models
{
    public class HttpError
    {

        [JsonPropertyName("message")]
        public string Message { get; set; }


        [JsonPropertyName("errorCode")]
        public int ErrorCode { get; set; }

        [JsonPropertyName("httpCode")]
        public int HttpCode { get; set; }
        [JsonPropertyName("errorContext")]
        public string ErrorContext { get; set; }
        [JsonPropertyName("moreInfo")]
        public string MoreInfo { get; set; }
        [JsonPropertyName("transactionTime")]
        public string TransactionTime { get; set; }
    }
}
