using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticTurnirAsisten
{
    public class SQLConnector : IDataConnection
    {
        // napravi napraviNagradu nacin da se spremi u databazu  
        /// <summary>
        /// Spremi novu nagradu u data bazu
        /// </summary>
        /// <param name="model">Informacija o nagradi</param>
        /// <returns>Infoprtmacija u nagradi ukljucujuci uniqe identifier</returns>
        public NagradaModel CreatePrize(NagradaModel model)
        {
            model.Id = 1;
            return model;  
        }
    }
}
