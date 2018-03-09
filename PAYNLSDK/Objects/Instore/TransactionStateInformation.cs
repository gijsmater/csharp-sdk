using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.Objects.Instore
{
    public class TransactionStateInformation
    {
        private string state;

        /// <summary>
        /// The status of the transaction. Possible values:
        /// init: payment initialized
        /// approved: payment successful
        /// cancelled: payment cancelled by customer
        /// expired: transaction not completed in time
        /// error: an error occured while processing the payment
        /// </summary>
        [JsonProperty("state")]
        public Enums.TransactionState State
        {
            get
            {
                return Enums.EnumUtil.ToEnum<Enums.TransactionState>(state);
            }
            set
            {
                state = Enums.EnumUtil.ToEnumString(value);
            }
        }
    }
}
