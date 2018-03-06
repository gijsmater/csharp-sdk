using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.API.Instore.getAllTerminals
{
    public class Response : ResponseBase
    {
        /// <summary>
        /// API will return a list of terminals linked to the merchant.
        /// </summary>
        public PAYNLSDK.Objects.Instore.Terminal[] Terminals { get; set; }
    }
}
