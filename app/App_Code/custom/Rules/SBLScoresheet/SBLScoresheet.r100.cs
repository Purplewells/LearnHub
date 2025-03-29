using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using zLearnHub.Data;
using zLearnHub.Models;

namespace zLearnHub.Rules
{
    public partial class SBLScoresheetBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "calculatePWS" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Calculate|New|Update".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(SBLScoresheetModel instance)
        {
            // This is the placeholder for method implementation.
            if (instance.EarnedScore.HasValue)
            {
                instance.ExtPBSG = (instance.EarnedScore / instance.ExtMaxScore) * 100;
                
                //Calculate the partial contribution of current score relative to the overall score
                instance.ExtPWS = (instance.EarnedScore / instance.MaxScore) * instance.Weight;

            }
        }
    }
}
