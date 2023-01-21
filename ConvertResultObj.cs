using System;
using Newtonsoft.Json;

namespace UpCount
{
    public partial class ConvertResult
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("historical")]
        public string Historical { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("query")]
        public Query Query { get; set; }

        [JsonProperty("result")]
        public double Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }

    public partial class Query
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }
    }
}