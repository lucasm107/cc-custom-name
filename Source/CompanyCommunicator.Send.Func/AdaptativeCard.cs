using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Teams.Apps.CompanyCommunicator.Send.Func
{
    class AdaptativeCard
    {
        public IList<Action> Actions { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }

        public IList<AdaptativeCardBody> Body { get; set; }

    }

}
