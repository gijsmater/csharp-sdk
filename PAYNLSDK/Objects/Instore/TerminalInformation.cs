using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.Objects.Instore
{

    /// <summary>
    /// Basic terminal information.
    /// </summary>
    public class TerminalInformation
    {
        /// <summary>
        /// The state of the terminal.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
    }
}
