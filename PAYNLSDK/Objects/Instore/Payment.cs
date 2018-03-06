using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.Objects.Instore
{
    /// <summary>
    /// Transactions once started using iDeal, MisterCash, Creditcard etc., and are not completed yest, can be completed by PIN. 
    /// Use the transactionId/orderId and entranceCode of the original transaction to start a PIN transaction.
    /// The amount of the PIN transaction is copied from the original transaction and cannot be changed.
    /// If you own multiple PIN terminals, you can provide the ID of the terminal to be used to complete the transaction.
    /// If no terminal ID is provided, a terminal will be selected automatically.
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Transaction information.
        /// </summary>
        [JsonProperty("transaction")]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// Terminal information.
        /// </summary>
        [JsonProperty("terminal")]
        public TerminalInformation Terminal { get; set; }

        /// <summary>
        /// A terminal transaction lasts up to 45 seconds. 
        /// The progress indicates how long the terminal is not available/the customer has time to complete the transaction.
        /// </summary>
        [JsonProperty("progress")]
        public Progress Progress { get; set; }
        
    }


}
