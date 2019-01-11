using Newtonsoft.Json;
using PAYNLSDK.Exceptions;
using PAYNLSDK.Objects;
using PAYNLSDK.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.API.Transaction.Capture
{
    /// <summary>
    /// Function to start capture of reserved payments.
    /// TODO: PULL REQUEST
    /// </summary>
    public class Request : RequestBase
    {
        /// <summary>
        /// The order ID or EX code of the transaction
        /// </summary>
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Amount to be captured in cents. If not specified (or 0) the entire reservation will be captured
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }


        /// <summary>
        /// List of productIds to be captured. If left empty it is assumed the entire order is to be captured
        /// </summary>
        [JsonProperty("products")]
        public List<CaptureProduct> Products { get; set; }

        /// <summary>
        /// Some payment methods require proof of shipment. Provide the Track &amp; Trace code if available/applicable
        /// </summary>
        [JsonProperty("tracktrace")]
        public string Tracktrace { get; set; }

        /* overrides */
        /// <summary>
        /// API version
        /// </summary>
        public override int Version
        {
            get { return 7; }
        }

        /// <summary>
        /// API Controller
        /// </summary>
        public override string Controller
        {
            get { return "Transaction"; }
        }

        /// <summary>
        /// API method name
        /// </summary>
        public override string Method
        {
            get { return "capture"; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override string Querystring
        {
            get { return ""; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override NameValueCollection GetParameters()
        {
            NameValueCollection nvc = base.GetParameters();

            ParameterValidator.IsNotEmpty(TransactionId, "TransactionId");
            nvc.Add("transactionId", TransactionId);


            return nvc;
        }

        /// <summary>
        /// 
        /// </summary>
        public Response Response { get { return (Response)response; } }

        /// <summary>
        /// 
        /// </summary>
        public override void SetResponse()
        {
            if (ParameterValidator.IsEmpty(rawResponse))
            {
                throw new ErrorException("rawResponse is empty!");
            }
            response = JsonConvert.DeserializeObject<Response>(RawResponse);
        }
    }
}
