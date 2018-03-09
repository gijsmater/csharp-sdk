using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.Objects.Instore
{
    public class Transaction : TransactionStateInformation
    {
        /// <summary>
        /// ID for the PIN transaction.
        /// </summary>
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Unique key for the transaction, that can be used to for the get the status of the transaction. See: API_Terminal_v1::status(); 
        /// </summary>
        [JsonProperty("terminalHash")]
        public string TerminalHash { get; set; }

        /// <summary>
        /// URL of the webpage the status of the transaction is displayed. 
        /// </summary>
        [JsonProperty("issuerUrl")]
        public string IssuerUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("statusUrl")]
        public string StatusUrl { get; set; }

    }
}
