using Newtonsoft.Json;

namespace Blockchain.Models
{
    public class BalanceResponse
    {
        [JsonIgnore]
        public string Address { get; set; }

        [JsonProperty("final_balance")]
        public long FinalBalance { get; set; }

        [JsonProperty("n_tx")]
        public long NumberOfTransactions { get; set; }

        [JsonProperty("total_received")]
        public long TotalReceived { get; set; }
    }
}