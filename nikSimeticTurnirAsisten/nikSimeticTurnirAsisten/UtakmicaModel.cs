using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticTurnirAsisten
{
    public class UtakmicaModel
    {
        /// <summary>
        /// Lista svih sudionika u toj utakmici 
        /// </summary>

        public List<SudionikModel> Natjecatelji { get; set; } = new List<SudionikModel>();
        /// <summary>
        /// Pobjednik te utakmice
        /// </summary>
        
        public EkipaModel Pobjednik { get; set; }
        /// <summary>
        /// Broj runde u kojoj se odrzava utakmic
        /// </summary>
        
        public int BrojRunde { get; set; }
    }
}
