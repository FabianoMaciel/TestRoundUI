using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestRound.Models
{
    [Serializable]
    public class CompanyModel
    {

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Exchange")]
        public string Exchange { get; set; }

        [Display(Name = "Ticker")]
        public string Ticker { get; set; }

        [Display(Name = "ISIN")]
        public string ISIN { get; set; }
        [Display(Name = "WebSitexx")]
        public string WebSite { get; set; }
    }
}
