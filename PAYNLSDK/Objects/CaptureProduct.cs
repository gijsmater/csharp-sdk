using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.Objects
{
    /// <summary>
    /// Product information that needs to be send with a capture action
    /// </summary>
    public class CaptureProduct
    {
        /// <summary>
        /// The productId as provided on creation fo the transaction
        /// </summary>
        [JsonProperty("productId")]
        public string productId { get; set; }

        /// <summary>
        /// The quantity of items to be captured
        /// </summary>
        [JsonProperty("quantity")]
        public int quantity { get; set; }
    }
}
