using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticTurnirAsisten
{
    public class EkipaModel
    {
        /// <summary>
        /// Lista clanova ove ekipe
        /// </summary>

        public List<OsobaModel> ClanoviEkipe { get; set; } = new List<OsobaModel>();
        /// <summary>
        /// Naziv ove ekipe
        /// </summary>
        
        public string ImeEkipe { get; set; }

    }
}
