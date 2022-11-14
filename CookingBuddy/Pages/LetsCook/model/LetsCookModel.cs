using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingBuddy.Pages.LetsCook.model
{

    public class LetsCookModel
    {
        public string videourl;
        public (string, string)[] StepDescritpionPair;
        public LetsCookModel(string url, (string, string)[] steps)
        {
            this.videourl = url;
            this.StepDescritpionPair = steps;
        }

    }
}
