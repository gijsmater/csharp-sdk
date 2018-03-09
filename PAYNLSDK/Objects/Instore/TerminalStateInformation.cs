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
    public class TerminalStateInformation
    {
        private string state;

        /// <summary>
        /// The state of the terminal.
        /// </summary>
        [JsonProperty("state")]
        public Enums.TerminalState State
        {
            get
            {
                return Enums.EnumUtil.ToEnum<Enums.TerminalState>(state);
            }
            set
            {
                state = Enums.EnumUtil.ToEnumString(value);
            }
        }
    }
}
