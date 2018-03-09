using Newtonsoft.Json;
using PAYNLSDK.Exceptions;
using PAYNLSDK.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.API.Instore.status
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
        [JsonProperty("hash")]
        [JsonRequired]
        public string Hash { get; set; }
        
        
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
            get { return "status"; }
        }

        public override string Querystring
        {
            get { return ""; }
        }


        public override System.Collections.Specialized.NameValueCollection GetParameters()
        {
            NameValueCollection nvc = base.GetParameters();

            ParameterValidator.IsNotNull(Hash, "Hash");
            nvc.Add("hash", Hash);

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
