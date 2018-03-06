using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.Objects.Instore
{
    /// <summary>
    /// Pin Terminal object.
    /// </summary>
    public partial class Terminal : TerminalInformation
    {
        /// <summary>
        /// ID of the terminal. Can be used to start a transaction for a specific terminal. See: API_Terminal_v1::payment(); 
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Self chosen name for the terminal.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The state of the terminal.
        /// </summary>
        [JsonProperty("ecrProtocol")]
        public string ECRProtocol { get; set; }
    }
}
