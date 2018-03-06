using Newtonsoft.Json;
using PAYNLSDK.Exceptions;
using PAYNLSDK.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.API.Instore.payment
{
    /// <summary>
    /// API will return a list of terminals linked to the merchant.
    /// </summary>
    public class Request : RequestBase
    {
        public override bool RequiresApiToken
        {
            get
            {
                return true;
            }
        }

        public override bool RequiresServiceId
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// The order ID or EX code of the original transaction
        /// </summary>
        [JsonProperty("transactionId")]
        [JsonRequired]
        public string TransactionId { get; set; }

        /// <summary>
        /// The ID of the terminal to be used
        /// </summary>
        [JsonProperty("terminalId")]
        public string TerminalId { get; set; }
        
        public override int Version
        {
            get { return 2; }
        }

        public override string Controller
        {
            get { return "Instore"; }
        }
        
        public override string Method
        {
            get { return "payment"; }
        }

        public override string Querystring
        {
            get { return ""; }
        }


        public override System.Collections.Specialized.NameValueCollection GetParameters()
        {
            NameValueCollection nvc = base.GetParameters();

            ParameterValidator.IsNotNull(TransactionId, "TerminalState");
            nvc.Add("transactionId", TransactionId);

            ParameterValidator.IsNotNull(TerminalId, "TerminalId");
            nvc.Add("terminalId", TerminalId);

            return nvc;
        }

        public Response Response { get { return (Response)response; } }


        public override void SetResponse()
        {
            if (ParameterValidator.IsEmpty(rawResponse))
            {
                throw new ErrorException("rawResponse is empty!");
            }
            response = JsonConvert.DeserializeObject<Response>(RawResponse);
            if (!Response.Request.Result)
            {
                // toss
                throw new ErrorException(Response.Request.Message);
            }
        }
    }
}
