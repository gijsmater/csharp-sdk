using Newtonsoft.Json;
using PAYNLSDK.Objects.Instore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.API.Instore.status
{
    public class Response : ResponseBase
    {
        /// <summary>
        /// Transaction information.
        /// </summary>
        [JsonProperty("transaction")]
        public TransactionStateInformation Transaction { get; set; }

        /// <summary>
        /// Terminal information.
        /// </summary>
        [JsonProperty("terminal")]
        public TerminalStateInformation Terminal { get; set; }

        /// <summary>
        /// A terminal transaction lasts up to 45 seconds. 
        /// The progress indicates how long the terminal is not available/the customer has time to complete the transaction.
        /// </summary>
        [JsonProperty("progress")]
        public Progress Progress { get; set; }
    }
}
