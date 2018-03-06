using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.Objects.Instore
{

    /// <summary>
    /// A terminal transaction lasts up to 45 seconds. 
    /// The progress indicates how long the terminal is not available/the customer has time to complete the transaction.
    /// </summary>
    public class Progress
    {
        /// <summary>
        /// Progress in percentage 
        /// </summary>
        [JsonProperty("percentage")]
        public decimal Percentage { get; set; }

        /// <summary>
        /// The amount of seconds the transaction is waiting for the customer since starting the transaction.
        /// </summary>
        [JsonProperty("seconds_past")]
        public int SecondsPast { get; set; }

        /// <summary>
        /// Each second corresponds to a percentage the transaction is in progress. 
        /// </summary>
        [JsonProperty("percentage_per_second")]
        public decimal PercentagePerSecond { get; set; }
    }
}
